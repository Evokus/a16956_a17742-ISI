namespace WeatherIPMA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLocal = new System.Windows.Forms.ComboBox();
            this.ButtonConfirmarLocal = new System.Windows.Forms.Button();
            this.groupBoxWeather = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelMes2 = new System.Windows.Forms.Label();
            this.labelDia2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMes3 = new System.Windows.Forms.Label();
            this.labelDia3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMes4 = new System.Windows.Forms.Label();
            this.labelDia4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMes5 = new System.Windows.Forms.Label();
            this.labelDia5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMes1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPrec2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelPrec3 = new System.Windows.Forms.Label();
            this.labelDia1 = new System.Windows.Forms.Label();
            this.labelPrec4 = new System.Windows.Forms.Label();
            this.labelPrec5 = new System.Windows.Forms.Label();
            this.labelPrec1 = new System.Windows.Forms.Label();
            this.windDir2 = new System.Windows.Forms.Label();
            this.windDir3 = new System.Windows.Forms.Label();
            this.windDir4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.windDir5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.windDir1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelTmax2 = new System.Windows.Forms.Label();
            this.labelTmin1 = new System.Windows.Forms.Label();
            this.labelTmin2 = new System.Windows.Forms.Label();
            this.labelTmax1 = new System.Windows.Forms.Label();
            this.labelTmax3 = new System.Windows.Forms.Label();
            this.labelTmin5 = new System.Windows.Forms.Label();
            this.labelTmin3 = new System.Windows.Forms.Label();
            this.labelTmax5 = new System.Windows.Forms.Label();
            this.labelTmax4 = new System.Windows.Forms.Label();
            this.labelTmin4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.labelAmpMin = new System.Windows.Forms.Label();
            this.labelAmpMax = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha a localização:";
            // 
            // comboBoxLocal
            // 
            this.comboBoxLocal.FormattingEnabled = true;
            this.comboBoxLocal.Items.AddRange(new object[] {
            "Aveiro",
            "Beja",
            "Braga",
            "Bragança",
            "Castelo Branco",
            "Coimbra",
            "Évora",
            "Faro",
            "Guarda",
            "Leiria",
            "Lisboa",
            "Portalegre",
            "Porto",
            "Santarém",
            "Setúbal",
            "Viana do Castelo",
            "Vila Real",
            "Viseu",
            "Funchal",
            "Porto Santo",
            "Vila do Porto",
            "Ponta Delgada",
            "Angra do Heroísmo",
            "Santa Cruz da Graciosa",
            "Velas",
            "Madalena",
            "Horta",
            "Santa Cruz das Flores",
            "Vila do Corvo"});
            this.comboBoxLocal.Location = new System.Drawing.Point(164, 41);
            this.comboBoxLocal.Name = "comboBoxLocal";
            this.comboBoxLocal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocal.TabIndex = 1;
            this.comboBoxLocal.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocal_SelectedIndexChanged);
            // 
            // ButtonConfirmarLocal
            // 
            this.ButtonConfirmarLocal.Location = new System.Drawing.Point(317, 41);
            this.ButtonConfirmarLocal.Name = "ButtonConfirmarLocal";
            this.ButtonConfirmarLocal.Size = new System.Drawing.Size(75, 23);
            this.ButtonConfirmarLocal.TabIndex = 2;
            this.ButtonConfirmarLocal.Text = "Confirmar";
            this.ButtonConfirmarLocal.UseVisualStyleBackColor = true;
            this.ButtonConfirmarLocal.Click += new System.EventHandler(this.ButtonConfirmarLocal_Click);
            // 
            // groupBoxWeather
            // 
            this.groupBoxWeather.Controls.Add(this.label8);
            this.groupBoxWeather.Controls.Add(this.label7);
            this.groupBoxWeather.Controls.Add(this.label5);
            this.groupBoxWeather.Controls.Add(this.label4);
            this.groupBoxWeather.Controls.Add(this.label12);
            this.groupBoxWeather.Controls.Add(this.labelMes2);
            this.groupBoxWeather.Controls.Add(this.labelDia2);
            this.groupBoxWeather.Controls.Add(this.label9);
            this.groupBoxWeather.Controls.Add(this.labelMes3);
            this.groupBoxWeather.Controls.Add(this.labelDia3);
            this.groupBoxWeather.Controls.Add(this.label6);
            this.groupBoxWeather.Controls.Add(this.labelMes4);
            this.groupBoxWeather.Controls.Add(this.labelDia4);
            this.groupBoxWeather.Controls.Add(this.label3);
            this.groupBoxWeather.Controls.Add(this.labelMes5);
            this.groupBoxWeather.Controls.Add(this.labelDia5);
            this.groupBoxWeather.Controls.Add(this.label2);
            this.groupBoxWeather.Controls.Add(this.labelMes1);
            this.groupBoxWeather.Controls.Add(this.pictureBox1);
            this.groupBoxWeather.Controls.Add(this.labelPrec2);
            this.groupBoxWeather.Controls.Add(this.pictureBox4);
            this.groupBoxWeather.Controls.Add(this.labelPrec3);
            this.groupBoxWeather.Controls.Add(this.labelDia1);
            this.groupBoxWeather.Controls.Add(this.labelPrec4);
            this.groupBoxWeather.Controls.Add(this.labelPrec5);
            this.groupBoxWeather.Controls.Add(this.labelPrec1);
            this.groupBoxWeather.Controls.Add(this.windDir2);
            this.groupBoxWeather.Controls.Add(this.windDir3);
            this.groupBoxWeather.Controls.Add(this.windDir4);
            this.groupBoxWeather.Controls.Add(this.pictureBox2);
            this.groupBoxWeather.Controls.Add(this.windDir5);
            this.groupBoxWeather.Controls.Add(this.pictureBox3);
            this.groupBoxWeather.Controls.Add(this.windDir1);
            this.groupBoxWeather.Controls.Add(this.pictureBox5);
            this.groupBoxWeather.Controls.Add(this.labelTmax2);
            this.groupBoxWeather.Controls.Add(this.labelTmin1);
            this.groupBoxWeather.Controls.Add(this.labelTmin2);
            this.groupBoxWeather.Controls.Add(this.labelTmax1);
            this.groupBoxWeather.Controls.Add(this.labelTmax3);
            this.groupBoxWeather.Controls.Add(this.labelTmin5);
            this.groupBoxWeather.Controls.Add(this.labelTmin3);
            this.groupBoxWeather.Controls.Add(this.labelTmax5);
            this.groupBoxWeather.Controls.Add(this.labelTmax4);
            this.groupBoxWeather.Controls.Add(this.labelTmin4);
            this.groupBoxWeather.Location = new System.Drawing.Point(48, 112);
            this.groupBoxWeather.Name = "groupBoxWeather";
            this.groupBoxWeather.Size = new System.Drawing.Size(704, 261);
            this.groupBoxWeather.TabIndex = 33;
            this.groupBoxWeather.TabStop = false;
            this.groupBoxWeather.Text = "País -> Cidade";
            this.groupBoxWeather.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Prob Chuva ->";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Direção Vento ->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Temperaturas (mín, máx) ->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Dias (dia, mês) ->";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "-";
            // 
            // labelMes2
            // 
            this.labelMes2.AutoSize = true;
            this.labelMes2.Location = new System.Drawing.Point(285, 53);
            this.labelMes2.Name = "labelMes2";
            this.labelMes2.Size = new System.Drawing.Size(27, 13);
            this.labelMes2.TabIndex = 47;
            this.labelMes2.Text = "Mês";
            // 
            // labelDia2
            // 
            this.labelDia2.AutoSize = true;
            this.labelDia2.Location = new System.Drawing.Point(260, 53);
            this.labelDia2.Name = "labelDia2";
            this.labelDia2.Size = new System.Drawing.Size(32, 13);
            this.labelDia2.TabIndex = 46;
            this.labelDia2.Text = "Dia 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "-";
            // 
            // labelMes3
            // 
            this.labelMes3.AutoSize = true;
            this.labelMes3.Location = new System.Drawing.Point(381, 53);
            this.labelMes3.Name = "labelMes3";
            this.labelMes3.Size = new System.Drawing.Size(27, 13);
            this.labelMes3.TabIndex = 44;
            this.labelMes3.Text = "Mês";
            // 
            // labelDia3
            // 
            this.labelDia3.AutoSize = true;
            this.labelDia3.Location = new System.Drawing.Point(356, 53);
            this.labelDia3.Name = "labelDia3";
            this.labelDia3.Size = new System.Drawing.Size(32, 13);
            this.labelDia3.TabIndex = 43;
            this.labelDia3.Text = "Dia 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "-";
            // 
            // labelMes4
            // 
            this.labelMes4.AutoSize = true;
            this.labelMes4.Location = new System.Drawing.Point(463, 53);
            this.labelMes4.Name = "labelMes4";
            this.labelMes4.Size = new System.Drawing.Size(27, 13);
            this.labelMes4.TabIndex = 41;
            this.labelMes4.Text = "Mês";
            // 
            // labelDia4
            // 
            this.labelDia4.AutoSize = true;
            this.labelDia4.Location = new System.Drawing.Point(438, 53);
            this.labelDia4.Name = "labelDia4";
            this.labelDia4.Size = new System.Drawing.Size(32, 13);
            this.labelDia4.TabIndex = 40;
            this.labelDia4.Text = "Dia 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "-";
            // 
            // labelMes5
            // 
            this.labelMes5.AutoSize = true;
            this.labelMes5.Location = new System.Drawing.Point(556, 53);
            this.labelMes5.Name = "labelMes5";
            this.labelMes5.Size = new System.Drawing.Size(27, 13);
            this.labelMes5.TabIndex = 38;
            this.labelMes5.Text = "Mês";
            // 
            // labelDia5
            // 
            this.labelDia5.AutoSize = true;
            this.labelDia5.Location = new System.Drawing.Point(531, 53);
            this.labelDia5.Name = "labelDia5";
            this.labelDia5.Size = new System.Drawing.Size(32, 13);
            this.labelDia5.TabIndex = 37;
            this.labelDia5.Text = "Dia 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "-";
            // 
            // labelMes1
            // 
            this.labelMes1.AutoSize = true;
            this.labelMes1.Location = new System.Drawing.Point(188, 53);
            this.labelMes1.Name = "labelMes1";
            this.labelMes1.Size = new System.Drawing.Size(27, 13);
            this.labelMes1.TabIndex = 35;
            this.labelMes1.Text = "Mês";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(162, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // labelPrec2
            // 
            this.labelPrec2.AutoSize = true;
            this.labelPrec2.Location = new System.Drawing.Point(271, 222);
            this.labelPrec2.Name = "labelPrec2";
            this.labelPrec2.Size = new System.Drawing.Size(27, 13);
            this.labelPrec2.TabIndex = 32;
            this.labelPrec2.Text = "25%";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(441, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // labelPrec3
            // 
            this.labelPrec3.AutoSize = true;
            this.labelPrec3.Location = new System.Drawing.Point(366, 222);
            this.labelPrec3.Name = "labelPrec3";
            this.labelPrec3.Size = new System.Drawing.Size(27, 13);
            this.labelPrec3.TabIndex = 31;
            this.labelPrec3.Text = "25%";
            // 
            // labelDia1
            // 
            this.labelDia1.AutoSize = true;
            this.labelDia1.Location = new System.Drawing.Point(163, 53);
            this.labelDia1.Name = "labelDia1";
            this.labelDia1.Size = new System.Drawing.Size(32, 13);
            this.labelDia1.TabIndex = 0;
            this.labelDia1.Text = "Dia 1";
            // 
            // labelPrec4
            // 
            this.labelPrec4.AutoSize = true;
            this.labelPrec4.Location = new System.Drawing.Point(449, 222);
            this.labelPrec4.Name = "labelPrec4";
            this.labelPrec4.Size = new System.Drawing.Size(27, 13);
            this.labelPrec4.TabIndex = 30;
            this.labelPrec4.Text = "25%";
            // 
            // labelPrec5
            // 
            this.labelPrec5.AutoSize = true;
            this.labelPrec5.Location = new System.Drawing.Point(542, 222);
            this.labelPrec5.Name = "labelPrec5";
            this.labelPrec5.Size = new System.Drawing.Size(27, 13);
            this.labelPrec5.TabIndex = 29;
            this.labelPrec5.Text = "25%";
            // 
            // labelPrec1
            // 
            this.labelPrec1.AutoSize = true;
            this.labelPrec1.Location = new System.Drawing.Point(173, 222);
            this.labelPrec1.Name = "labelPrec1";
            this.labelPrec1.Size = new System.Drawing.Size(27, 13);
            this.labelPrec1.TabIndex = 28;
            this.labelPrec1.Text = "25%";
            // 
            // windDir2
            // 
            this.windDir2.AutoSize = true;
            this.windDir2.Location = new System.Drawing.Point(271, 187);
            this.windDir2.Name = "windDir2";
            this.windDir2.Size = new System.Drawing.Size(25, 13);
            this.windDir2.TabIndex = 27;
            this.windDir2.Text = "SW";
            // 
            // windDir3
            // 
            this.windDir3.AutoSize = true;
            this.windDir3.Location = new System.Drawing.Point(366, 187);
            this.windDir3.Name = "windDir3";
            this.windDir3.Size = new System.Drawing.Size(25, 13);
            this.windDir3.TabIndex = 26;
            this.windDir3.Text = "SW";
            // 
            // windDir4
            // 
            this.windDir4.AutoSize = true;
            this.windDir4.Location = new System.Drawing.Point(449, 187);
            this.windDir4.Name = "windDir4";
            this.windDir4.Size = new System.Drawing.Size(25, 13);
            this.windDir4.TabIndex = 25;
            this.windDir4.Text = "SW";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(263, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // windDir5
            // 
            this.windDir5.AutoSize = true;
            this.windDir5.Location = new System.Drawing.Point(542, 187);
            this.windDir5.Name = "windDir5";
            this.windDir5.Size = new System.Drawing.Size(25, 13);
            this.windDir5.TabIndex = 24;
            this.windDir5.Text = "SW";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(358, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // windDir1
            // 
            this.windDir1.AutoSize = true;
            this.windDir1.Location = new System.Drawing.Point(173, 187);
            this.windDir1.Name = "windDir1";
            this.windDir1.Size = new System.Drawing.Size(25, 13);
            this.windDir1.TabIndex = 23;
            this.windDir1.Text = "SW";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(534, 69);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // labelTmax2
            // 
            this.labelTmax2.AutoSize = true;
            this.labelTmax2.Location = new System.Drawing.Point(294, 151);
            this.labelTmax2.Name = "labelTmax2";
            this.labelTmax2.Size = new System.Drawing.Size(30, 13);
            this.labelTmax2.TabIndex = 22;
            this.labelTmax2.Text = "tMax";
            // 
            // labelTmin1
            // 
            this.labelTmin1.AutoSize = true;
            this.labelTmin1.Location = new System.Drawing.Point(163, 151);
            this.labelTmin1.Name = "labelTmin1";
            this.labelTmin1.Size = new System.Drawing.Size(27, 13);
            this.labelTmin1.TabIndex = 13;
            this.labelTmin1.Text = "tMin";
            // 
            // labelTmin2
            // 
            this.labelTmin2.AutoSize = true;
            this.labelTmin2.Location = new System.Drawing.Point(261, 151);
            this.labelTmin2.Name = "labelTmin2";
            this.labelTmin2.Size = new System.Drawing.Size(27, 13);
            this.labelTmin2.TabIndex = 21;
            this.labelTmin2.Text = "tMin";
            // 
            // labelTmax1
            // 
            this.labelTmax1.AutoSize = true;
            this.labelTmax1.Location = new System.Drawing.Point(196, 151);
            this.labelTmax1.Name = "labelTmax1";
            this.labelTmax1.Size = new System.Drawing.Size(30, 13);
            this.labelTmax1.TabIndex = 14;
            this.labelTmax1.Text = "tMax";
            // 
            // labelTmax3
            // 
            this.labelTmax3.AutoSize = true;
            this.labelTmax3.Location = new System.Drawing.Point(389, 151);
            this.labelTmax3.Name = "labelTmax3";
            this.labelTmax3.Size = new System.Drawing.Size(30, 13);
            this.labelTmax3.TabIndex = 20;
            this.labelTmax3.Text = "tMax";
            // 
            // labelTmin5
            // 
            this.labelTmin5.AutoSize = true;
            this.labelTmin5.Location = new System.Drawing.Point(528, 151);
            this.labelTmin5.Name = "labelTmin5";
            this.labelTmin5.Size = new System.Drawing.Size(27, 13);
            this.labelTmin5.TabIndex = 15;
            this.labelTmin5.Text = "tMin";
            // 
            // labelTmin3
            // 
            this.labelTmin3.AutoSize = true;
            this.labelTmin3.Location = new System.Drawing.Point(356, 151);
            this.labelTmin3.Name = "labelTmin3";
            this.labelTmin3.Size = new System.Drawing.Size(27, 13);
            this.labelTmin3.TabIndex = 19;
            this.labelTmin3.Text = "tMin";
            // 
            // labelTmax5
            // 
            this.labelTmax5.AutoSize = true;
            this.labelTmax5.Location = new System.Drawing.Point(561, 151);
            this.labelTmax5.Name = "labelTmax5";
            this.labelTmax5.Size = new System.Drawing.Size(30, 13);
            this.labelTmax5.TabIndex = 16;
            this.labelTmax5.Text = "tMax";
            // 
            // labelTmax4
            // 
            this.labelTmax4.AutoSize = true;
            this.labelTmax4.Location = new System.Drawing.Point(472, 151);
            this.labelTmax4.Name = "labelTmax4";
            this.labelTmax4.Size = new System.Drawing.Size(30, 13);
            this.labelTmax4.TabIndex = 18;
            this.labelTmax4.Text = "tMax";
            // 
            // labelTmin4
            // 
            this.labelTmin4.AutoSize = true;
            this.labelTmin4.Location = new System.Drawing.Point(439, 151);
            this.labelTmin4.Name = "labelTmin4";
            this.labelTmin4.Size = new System.Drawing.Size(27, 13);
            this.labelTmin4.TabIndex = 17;
            this.labelTmin4.Text = "tMin";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Céu Limpo.png");
            this.imageList1.Images.SetKeyName(1, "Céu Pouco Nublado.png");
            this.imageList1.Images.SetKeyName(2, "Céu Parcialmente Nublado.png");
            this.imageList1.Images.SetKeyName(3, "Céu muito nublado ou encoberto.png");
            this.imageList1.Images.SetKeyName(4, "Céu nublado por nuvens altas.png");
            this.imageList1.Images.SetKeyName(5, "Aguaceiros.png");
            this.imageList1.Images.SetKeyName(6, "Aguaceiros Fracos.png");
            this.imageList1.Images.SetKeyName(7, "Aguaceiros Fortes.png");
            this.imageList1.Images.SetKeyName(8, "Chuva.png");
            this.imageList1.Images.SetKeyName(9, "Chuva.png");
            this.imageList1.Images.SetKeyName(10, "Chuva.png");
            this.imageList1.Images.SetKeyName(11, "Períodos de Chuva.png");
            this.imageList1.Images.SetKeyName(12, "Períodos de Chuva.png");
            this.imageList1.Images.SetKeyName(13, "Períodos de Chuva.png");
            this.imageList1.Images.SetKeyName(14, "Chuvisco.png");
            this.imageList1.Images.SetKeyName(15, "Neblina.png");
            this.imageList1.Images.SetKeyName(16, "Nevoeiro ou Nuvens Baixas.png");
            this.imageList1.Images.SetKeyName(17, "Neve.png");
            this.imageList1.Images.SetKeyName(18, "Trovoada.png");
            this.imageList1.Images.SetKeyName(19, "Aguaceiros e Trovoada.png");
            this.imageList1.Images.SetKeyName(20, "Granizo.png");
            this.imageList1.Images.SetKeyName(21, "Geada.png");
            this.imageList1.Images.SetKeyName(22, "Aguaceiros e Trovoada.png");
            this.imageList1.Images.SetKeyName(23, "Nevoeiro ou Nuvens Baixas.png");
            this.imageList1.Images.SetKeyName(24, "Céu Parcialmente Nublado.png");
            this.imageList1.Images.SetKeyName(25, "Nevoeiro ou Nuvens Baixas.png");
            this.imageList1.Images.SetKeyName(26, "Nevoeiro ou Nuvens Baixas.png");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Amplitude Térmica dos 5 dias";
            // 
            // labelAmpMin
            // 
            this.labelAmpMin.AutoSize = true;
            this.labelAmpMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmpMin.Location = new System.Drawing.Point(543, 37);
            this.labelAmpMin.Name = "labelAmpMin";
            this.labelAmpMin.Size = new System.Drawing.Size(0, 25);
            this.labelAmpMin.TabIndex = 35;
            // 
            // labelAmpMax
            // 
            this.labelAmpMax.AutoSize = true;
            this.labelAmpMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmpMax.Location = new System.Drawing.Point(606, 37);
            this.labelAmpMax.Name = "labelAmpMax";
            this.labelAmpMax.Size = new System.Drawing.Size(0, 25);
            this.labelAmpMax.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(549, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Mínima";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(615, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Máxima";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelAmpMax);
            this.Controls.Add(this.labelAmpMin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBoxWeather);
            this.Controls.Add(this.ButtonConfirmarLocal);
            this.Controls.Add(this.comboBoxLocal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "IPMA Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxWeather.ResumeLayout(false);
            this.groupBoxWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLocal;
        private System.Windows.Forms.Button ButtonConfirmarLocal;
        private System.Windows.Forms.GroupBox groupBoxWeather;
        private System.Windows.Forms.Label labelPrec2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelPrec3;
        private System.Windows.Forms.Label labelDia1;
        private System.Windows.Forms.Label labelPrec4;
        private System.Windows.Forms.Label labelPrec5;
        private System.Windows.Forms.Label labelPrec1;
        private System.Windows.Forms.Label windDir2;
        private System.Windows.Forms.Label windDir3;
        private System.Windows.Forms.Label windDir4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label windDir5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label windDir1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelTmax2;
        private System.Windows.Forms.Label labelTmin1;
        private System.Windows.Forms.Label labelTmin2;
        private System.Windows.Forms.Label labelTmax1;
        private System.Windows.Forms.Label labelTmax3;
        private System.Windows.Forms.Label labelTmin5;
        private System.Windows.Forms.Label labelTmin3;
        private System.Windows.Forms.Label labelTmax5;
        private System.Windows.Forms.Label labelTmax4;
        private System.Windows.Forms.Label labelTmin4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMes1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelMes2;
        private System.Windows.Forms.Label labelDia2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelMes3;
        private System.Windows.Forms.Label labelDia3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMes4;
        private System.Windows.Forms.Label labelDia4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMes5;
        private System.Windows.Forms.Label labelDia5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelAmpMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelAmpMax;
    }
}

