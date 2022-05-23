
namespace PraktikumWeek14
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnKanan = new System.Windows.Forms.Button();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.labelNoPunggung = new System.Windows.Forms.Label();
            this.labelTeam = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelLahir = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.dtpLahir = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.labelAvail = new System.Windows.Forms.Label();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(55, 30);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 40);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(146, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(243, 30);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnKanan
            // 
            this.btnKanan.Location = new System.Drawing.Point(340, 30);
            this.btnKanan.Name = "btnKanan";
            this.btnKanan.Size = new System.Drawing.Size(75, 40);
            this.btnKanan.TabIndex = 3;
            this.btnKanan.Text = ">>";
            this.btnKanan.UseVisualStyleBackColor = true;
            this.btnKanan.Click += new System.EventHandler(this.btnKanan_Click);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(155, 133);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(269, 20);
            this.tbNama.TabIndex = 49;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(155, 102);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(269, 20);
            this.tbId.TabIndex = 48;
            // 
            // labelNoPunggung
            // 
            this.labelNoPunggung.AutoSize = true;
            this.labelNoPunggung.Location = new System.Drawing.Point(46, 270);
            this.labelNoPunggung.Name = "labelNoPunggung";
            this.labelNoPunggung.Size = new System.Drawing.Size(74, 13);
            this.labelNoPunggung.TabIndex = 47;
            this.labelNoPunggung.Text = "Team Number";
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(46, 239);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(34, 13);
            this.labelTeam.TabIndex = 46;
            this.labelTeam.Text = "Team";
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(46, 208);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(56, 13);
            this.labelNationality.TabIndex = 45;
            this.labelNationality.Text = "Nationality";
            // 
            // labelLahir
            // 
            this.labelLahir.AutoSize = true;
            this.labelLahir.Location = new System.Drawing.Point(46, 177);
            this.labelLahir.Name = "labelLahir";
            this.labelLahir.Size = new System.Drawing.Size(54, 13);
            this.labelLahir.TabIndex = 44;
            this.labelLahir.Text = "Birth Date";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(46, 140);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(67, 13);
            this.labelNama.TabIndex = 43;
            this.labelNama.Text = "Player Name";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(46, 109);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(48, 13);
            this.labelId.TabIndex = 42;
            this.labelId.Text = "Player Id";
            // 
            // dtpLahir
            // 
            this.dtpLahir.Location = new System.Drawing.Point(155, 169);
            this.dtpLahir.Name = "dtpLahir";
            this.dtpLahir.Size = new System.Drawing.Size(269, 20);
            this.dtpLahir.TabIndex = 54;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(55, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 24);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(243, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 24);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(155, 270);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(163, 20);
            this.nudNumber.TabIndex = 57;
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            // 
            // cbNationality
            // 
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Items.AddRange(new object[] {
            "Algeria",
            "Argentina",
            "Australia",
            "Austria",
            "Belgium",
            "Benin",
            "Bosnia and Herzegovina",
            "Brazil",
            "Burkina Faso",
            "Cameroon",
            "Canada",
            "Chile",
            "Colombia",
            "Congo",
            "Costa Rica",
            "Croatia",
            "Curaçao",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "DR Congo",
            "Ecuador",
            "Egypt",
            "England",
            "Finland",
            "France",
            "Gambia",
            "Germany",
            "Ghana",
            "Greece",
            "Hungary",
            "Iceland",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Kenya",
            "Lithuania",
            "Macedonia",
            "Mali",
            "Mexico",
            "Morocco",
            "Netherlands",
            "New Zealand",
            "Nigeria",
            "Northern Ireland",
            "Norway",
            "Poland",
            "Portugal",
            "Republic of Ireland",
            "Romania",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Scotland",
            "Senegal",
            "Serbia",
            "Slovakia",
            "Slovenia",
            "South Africa",
            "South Korea",
            "Spain",
            "Sweden",
            "Switzerland",
            "Togo",
            "Tunisia",
            "Turkey",
            "United States",
            "Uruguay",
            "Venezuela",
            "Wales",
            "Yugoslavia",
            "Zimbabwe"});
            this.cbNationality.Location = new System.Drawing.Point(155, 199);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(269, 21);
            this.cbNationality.TabIndex = 58;
            // 
            // labelAvail
            // 
            this.labelAvail.AutoSize = true;
            this.labelAvail.Location = new System.Drawing.Point(324, 273);
            this.labelAvail.Name = "labelAvail";
            this.labelAvail.Size = new System.Drawing.Size(35, 13);
            this.labelAvail.TabIndex = 59;
            this.labelAvail.Text = "label1";
            // 
            // cbTeam
            // 
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Items.AddRange(new object[] {
            "Arsenal",
            "Aston Villa",
            "Bournemouth",
            "Chelsea",
            "Crystal Palace",
            "Everton",
            "Leicester City",
            "Liverpool",
            "Manchester City",
            "Manchester United",
            "Newcastle United",
            "Norwich City",
            "Southampton",
            "Stoke City",
            "Sunderland",
            "Swansea City",
            "Tottenham Hotspur",
            "Watford",
            "West Bromwich Albion",
            "West Ham United"});
            this.cbTeam.Location = new System.Drawing.Point(155, 239);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(269, 21);
            this.cbTeam.TabIndex = 60;
            this.cbTeam.SelectedIndexChanged += new System.EventHandler(this.cbTeam_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 376);
            this.Controls.Add(this.cbTeam);
            this.Controls.Add(this.labelAvail);
            this.Controls.Add(this.cbNationality);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpLahir);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.labelNoPunggung);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.labelLahir);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnKanan);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrevious);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnKanan;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label labelNoPunggung;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelLahir;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.DateTimePicker dtpLahir;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.Label labelAvail;
        private System.Windows.Forms.ComboBox cbTeam;
    }
}

