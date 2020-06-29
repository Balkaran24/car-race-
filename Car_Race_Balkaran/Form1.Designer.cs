namespace Car_Race_Balkaran
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
            this.bettingParlor = new System.Windows.Forms.GroupBox();
            this.raceBttn = new System.Windows.Forms.Button();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownForBet = new System.Windows.Forms.NumericUpDown();
            this.betBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.samsherBetLabel = new System.Windows.Forms.Label();
            this.rajdeepBetLabel = new System.Windows.Forms.Label();
            this.balkaranBetLabel = new System.Windows.Forms.Label();
            this.radioButtonSamsher = new System.Windows.Forms.RadioButton();
            this.radioButtonRajdeep = new System.Windows.Forms.RadioButton();
            this.radioButtonBalkaran = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.trk4 = new System.Windows.Forms.PictureBox();
            this.trk3 = new System.Windows.Forms.PictureBox();
            this.trk2 = new System.Windows.Forms.PictureBox();
            this.trk1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bettingParlor
            // 
            this.bettingParlor.BackColor = System.Drawing.Color.Gainsboro;
            this.bettingParlor.Controls.Add(this.raceBttn);
            this.bettingParlor.Controls.Add(this.numericUpDownNumber);
            this.bettingParlor.Controls.Add(this.label3);
            this.bettingParlor.Controls.Add(this.numericUpDownForBet);
            this.bettingParlor.Controls.Add(this.betBttn);
            this.bettingParlor.Controls.Add(this.label2);
            this.bettingParlor.Controls.Add(this.samsherBetLabel);
            this.bettingParlor.Controls.Add(this.rajdeepBetLabel);
            this.bettingParlor.Controls.Add(this.balkaranBetLabel);
            this.bettingParlor.Controls.Add(this.radioButtonSamsher);
            this.bettingParlor.Controls.Add(this.radioButtonRajdeep);
            this.bettingParlor.Controls.Add(this.radioButtonBalkaran);
            this.bettingParlor.Controls.Add(this.minimumBetLabel);
            this.bettingParlor.Location = new System.Drawing.Point(410, 261);
            this.bettingParlor.Name = "bettingParlor";
            this.bettingParlor.Size = new System.Drawing.Size(411, 276);
            this.bettingParlor.TabIndex = 6;
            this.bettingParlor.TabStop = false;
            this.bettingParlor.Text = "Betting Place";
            // 
            // raceBttn
            // 
            this.raceBttn.BackColor = System.Drawing.Color.Black;
            this.raceBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceBttn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.raceBttn.Location = new System.Drawing.Point(31, 221);
            this.raceBttn.Name = "raceBttn";
            this.raceBttn.Size = new System.Drawing.Size(237, 49);
            this.raceBttn.TabIndex = 22;
            this.raceBttn.Text = "Race!";
            this.raceBttn.UseVisualStyleBackColor = false;
            this.raceBttn.Click += new System.EventHandler(this.raceBttn_Click);
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(286, 170);
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownNumber.TabIndex = 21;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "bets on truck number";
            // 
            // numericUpDownForBet
            // 
            this.numericUpDownForBet.Location = new System.Drawing.Point(117, 172);
            this.numericUpDownForBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownForBet.Name = "numericUpDownForBet";
            this.numericUpDownForBet.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownForBet.TabIndex = 19;
            this.numericUpDownForBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betBttn
            // 
            this.betBttn.BackColor = System.Drawing.Color.Black;
            this.betBttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.betBttn.Location = new System.Drawing.Point(31, 170);
            this.betBttn.Name = "betBttn";
            this.betBttn.Size = new System.Drawing.Size(76, 23);
            this.betBttn.TabIndex = 18;
            this.betBttn.Text = "Bet";
            this.betBttn.UseVisualStyleBackColor = false;
            this.betBttn.Click += new System.EventHandler(this.betBttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bets";
            // 
            // samsherBetLabel
            // 
            this.samsherBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.samsherBetLabel.Location = new System.Drawing.Point(163, 126);
            this.samsherBetLabel.Name = "samsherBetLabel";
            this.samsherBetLabel.Size = new System.Drawing.Size(197, 17);
            this.samsherBetLabel.TabIndex = 15;
            this.samsherBetLabel.Text = "SamsherBetLabel";
            // 
            // rajdeepBetLabel
            // 
            this.rajdeepBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rajdeepBetLabel.Location = new System.Drawing.Point(163, 93);
            this.rajdeepBetLabel.Name = "rajdeepBetLabel";
            this.rajdeepBetLabel.Size = new System.Drawing.Size(197, 17);
            this.rajdeepBetLabel.TabIndex = 14;
            this.rajdeepBetLabel.Text = "RajdeepBetLabel";
            // 
            // balkaranBetLabel
            // 
            this.balkaranBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balkaranBetLabel.Location = new System.Drawing.Point(163, 62);
            this.balkaranBetLabel.Name = "balkaranBetLabel";
            this.balkaranBetLabel.Size = new System.Drawing.Size(197, 17);
            this.balkaranBetLabel.TabIndex = 13;
            this.balkaranBetLabel.Text = "BalkaranBetLabel";
            // 
            // radioButtonSamsher
            // 
            this.radioButtonSamsher.AutoSize = true;
            this.radioButtonSamsher.Location = new System.Drawing.Point(31, 126);
            this.radioButtonSamsher.Name = "radioButtonSamsher";
            this.radioButtonSamsher.Size = new System.Drawing.Size(120, 17);
            this.radioButtonSamsher.TabIndex = 3;
            this.radioButtonSamsher.TabStop = true;
            this.radioButtonSamsher.Text = "radioButtonSamsher";
            this.radioButtonSamsher.UseVisualStyleBackColor = true;
            // 
            // radioButtonRajdeep
            // 
            this.radioButtonRajdeep.AutoSize = true;
            this.radioButtonRajdeep.Location = new System.Drawing.Point(31, 93);
            this.radioButtonRajdeep.Name = "radioButtonRajdeep";
            this.radioButtonRajdeep.Size = new System.Drawing.Size(119, 17);
            this.radioButtonRajdeep.TabIndex = 2;
            this.radioButtonRajdeep.TabStop = true;
            this.radioButtonRajdeep.Text = "radioButtonRajdeep";
            this.radioButtonRajdeep.UseVisualStyleBackColor = true;
            // 
            // radioButtonBalkaran
            // 
            this.radioButtonBalkaran.AutoSize = true;
            this.radioButtonBalkaran.Location = new System.Drawing.Point(31, 61);
            this.radioButtonBalkaran.Name = "radioButtonBalkaran";
            this.radioButtonBalkaran.Size = new System.Drawing.Size(121, 17);
            this.radioButtonBalkaran.TabIndex = 1;
            this.radioButtonBalkaran.TabStop = true;
            this.radioButtonBalkaran.Text = "radioButtonBalkaran";
            this.radioButtonBalkaran.UseVisualStyleBackColor = true;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(28, 32);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(83, 16);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimum Bet";
            // 
            // trk4
            // 
            this.trk4.BackColor = System.Drawing.Color.White;
            this.trk4.Image = global::Car_Race_Balkaran.Properties.Resources.t111;
            this.trk4.Location = new System.Drawing.Point(221, 42);
            this.trk4.Name = "trk4";
            this.trk4.Size = new System.Drawing.Size(31, 50);
            this.trk4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trk4.TabIndex = 11;
            this.trk4.TabStop = false;
            this.trk4.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // trk3
            // 
            this.trk3.BackColor = System.Drawing.Color.White;
            this.trk3.Image = global::Car_Race_Balkaran.Properties.Resources.t44;
            this.trk3.Location = new System.Drawing.Point(171, 42);
            this.trk3.Name = "trk3";
            this.trk3.Size = new System.Drawing.Size(31, 50);
            this.trk3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trk3.TabIndex = 10;
            this.trk3.TabStop = false;
            // 
            // trk2
            // 
            this.trk2.BackColor = System.Drawing.Color.White;
            this.trk2.Image = global::Car_Race_Balkaran.Properties.Resources.t33;
            this.trk2.Location = new System.Drawing.Point(122, 42);
            this.trk2.Name = "trk2";
            this.trk2.Size = new System.Drawing.Size(31, 50);
            this.trk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trk2.TabIndex = 9;
            this.trk2.TabStop = false;
            // 
            // trk1
            // 
            this.trk1.BackColor = System.Drawing.Color.White;
            this.trk1.Image = global::Car_Race_Balkaran.Properties.Resources.t22;
            this.trk1.Location = new System.Drawing.Point(72, 42);
            this.trk1.Name = "trk1";
            this.trk1.Size = new System.Drawing.Size(31, 50);
            this.trk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trk1.TabIndex = 8;
            this.trk1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_Race_Balkaran.Properties.Resources.track22;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 566);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 566);
            this.Controls.Add(this.trk4);
            this.Controls.Add(this.trk3);
            this.Controls.Add(this.trk2);
            this.Controls.Add(this.trk1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bettingParlor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bettingParlor.ResumeLayout(false);
            this.bettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bettingParlor;
        private System.Windows.Forms.Button raceBttn;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownForBet;
        private System.Windows.Forms.Button betBttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label samsherBetLabel;
        private System.Windows.Forms.Label rajdeepBetLabel;
        private System.Windows.Forms.Label balkaranBetLabel;
        private System.Windows.Forms.RadioButton radioButtonSamsher;
        private System.Windows.Forms.RadioButton radioButtonRajdeep;
        private System.Windows.Forms.RadioButton radioButtonBalkaran;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox trk1;
        private System.Windows.Forms.PictureBox trk2;
        private System.Windows.Forms.PictureBox trk3;
        private System.Windows.Forms.PictureBox trk4;
        private System.Windows.Forms.Timer timer1;
    }
}

