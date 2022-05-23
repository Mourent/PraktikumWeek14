using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PraktikumWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league;Convert Zero Datetime=True";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;
        DataTable dtTypePemain = new DataTable();
        int posisiPemain = 0;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select p.player_id, p.player_name, p.birthdate, n.nation, t.team_name, p.team_number from player p, team t, nationality n where p.nationality_id = n.nationality_id and p.team_id = t.team_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain);
            isiDataPemain(0);
            labelAvail.Text = "Available";
        }
        public void isiDataPemain(int Posisi)
        {
            tbId.Text = dtTypePemain.Rows[Posisi][0].ToString();
            tbNama.Text = dtTypePemain.Rows[Posisi][1].ToString();
            dtpLahir.Text = dtTypePemain.Rows[Posisi][2].ToString();
            cbNationality.Text = dtTypePemain.Rows[Posisi][3].ToString();
            cbTeam.Text = dtTypePemain.Rows[Posisi][4].ToString();
            nudNumber.Text = dtTypePemain.Rows[Posisi][5].ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            isiDataPemain(0);
            posisiPemain = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (posisiPemain == 0)
            {
                MessageBox.Show("Data Pertama");
            }
            else
                isiDataPemain(posisiPemain - 1);
            posisiPemain--;
        }

        private void btnKanan_Click(object sender, EventArgs e)
        {
            isiDataPemain(dtTypePemain.Rows.Count - 1);
            posisiPemain = dtTypePemain.Rows.Count - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (posisiPemain == dtTypePemain.Rows.Count - 1)
            {
                MessageBox.Show("Data Terakhir");
            }
            else
                isiDataPemain(posisiPemain + 1);
            posisiPemain++;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            if (labelAvail.Text == "Available")
            {
                sqlQuery = "update player p, team t, nationality n set p.player_name = '" + tbNama.Text + "', p.birthdate = '" + dtpLahir.Value.ToString("yyyyMMdd") + "', n.nation = '" + cbNationality.Text + "', t.team_name = '" + cbTeam.Text + "', p.team_number = '" + nudNumber.Value + "' where p.player_id = '" + tbId.Text + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
            }
            else if (labelAvail.Text == "Not Available")
            {
                MessageBox.Show("Tidak Bisa Di Save");
            }
            sqlConnect.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            string sqlQuery = "select p.player_name as Name,p.team_number as Number from team t,player p where p.team_id=t.team_id and t.team_id='" + cbTeam.Text + "' having p.team_number='" + nudNumber.Value + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtNumber = new DataTable();
            sqlAdapter.Fill(dtNumber);
            if (dtNumber.Rows.Count == 0)
            {
                labelAvail.Text = "Available";
            }
            else
            {
                labelAvail.Text = "Not Available";
            }
        }

        private void cbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
