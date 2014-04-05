namespace XmlDasta
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
            this.btnReadDisXML = new System.Windows.Forms.Button();
            this.listBoxTDG = new System.Windows.Forms.ListBox();
            this.lbKod = new System.Windows.Forms.Label();
            this.tBKod = new System.Windows.Forms.TextBox();
            this.lblNaz = new System.Windows.Forms.Label();
            this.tbNazev = new System.Windows.Forms.TextBox();
            this.lbldg = new System.Windows.Forms.Label();
            this.tBDiagnosa = new System.Windows.Forms.TextBox();
            this.lblPlatnost = new System.Windows.Forms.Label();
            this.tbPlatnostOd = new System.Windows.Forms.TextBox();
            this.btnNewDis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSpoj = new System.Windows.Forms.Button();
            this.listBoxSWHO = new System.Windows.Forms.ListBox();
            this.listBoxMKN = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReadDisXML
            // 
            this.btnReadDisXML.Location = new System.Drawing.Point(35, 24);
            this.btnReadDisXML.Name = "btnReadDisXML";
            this.btnReadDisXML.Size = new System.Drawing.Size(88, 43);
            this.btnReadDisXML.TabIndex = 0;
            this.btnReadDisXML.Text = "NactiXML MKN";
            this.btnReadDisXML.UseVisualStyleBackColor = true;
            this.btnReadDisXML.Click += new System.EventHandler(this.btnReadDisXMLMKN_Click);
            // 
            // listBoxTDG
            // 
            this.listBoxTDG.FormattingEnabled = true;
            this.listBoxTDG.Location = new System.Drawing.Point(35, 85);
            this.listBoxTDG.Name = "listBoxTDG";
            this.listBoxTDG.Size = new System.Drawing.Size(206, 95);
            this.listBoxTDG.TabIndex = 1;
            this.listBoxTDG.SelectedIndexChanged += new System.EventHandler(this.listBoxTDG_SelectedIndexChanged);
            // 
            // lbKod
            // 
            this.lbKod.AutoSize = true;
            this.lbKod.Location = new System.Drawing.Point(32, 200);
            this.lbKod.Name = "lbKod";
            this.lbKod.Size = new System.Drawing.Size(26, 13);
            this.lbKod.TabIndex = 2;
            this.lbKod.Text = "Kod";
            // 
            // tBKod
            // 
            this.tBKod.Location = new System.Drawing.Point(35, 231);
            this.tBKod.Name = "tBKod";
            this.tBKod.Size = new System.Drawing.Size(100, 20);
            this.tBKod.TabIndex = 3;
            // 
            // lblNaz
            // 
            this.lblNaz.AutoSize = true;
            this.lblNaz.Location = new System.Drawing.Point(138, 200);
            this.lblNaz.Name = "lblNaz";
            this.lblNaz.Size = new System.Drawing.Size(38, 13);
            this.lblNaz.TabIndex = 2;
            this.lblNaz.Text = "Nazev";
            // 
            // tbNazev
            // 
            this.tbNazev.Location = new System.Drawing.Point(141, 231);
            this.tbNazev.Name = "tbNazev";
            this.tbNazev.Size = new System.Drawing.Size(100, 20);
            this.tbNazev.TabIndex = 3;
            // 
            // lbldg
            // 
            this.lbldg.AutoSize = true;
            this.lbldg.Location = new System.Drawing.Point(32, 261);
            this.lbldg.Name = "lbldg";
            this.lbldg.Size = new System.Drawing.Size(52, 13);
            this.lbldg.TabIndex = 2;
            this.lbldg.Text = "Diagnosa";
            // 
            // tBDiagnosa
            // 
            this.tBDiagnosa.Location = new System.Drawing.Point(35, 277);
            this.tBDiagnosa.Name = "tBDiagnosa";
            this.tBDiagnosa.Size = new System.Drawing.Size(100, 20);
            this.tBDiagnosa.TabIndex = 3;
            // 
            // lblPlatnost
            // 
            this.lblPlatnost.AutoSize = true;
            this.lblPlatnost.Location = new System.Drawing.Point(138, 261);
            this.lblPlatnost.Name = "lblPlatnost";
            this.lblPlatnost.Size = new System.Drawing.Size(60, 13);
            this.lblPlatnost.TabIndex = 2;
            this.lblPlatnost.Text = "Platnost od";
            // 
            // tbPlatnostOd
            // 
            this.tbPlatnostOd.Location = new System.Drawing.Point(141, 277);
            this.tbPlatnostOd.Name = "tbPlatnostOd";
            this.tbPlatnostOd.Size = new System.Drawing.Size(100, 20);
            this.tbPlatnostOd.TabIndex = 3;
            // 
            // btnNewDis
            // 
            this.btnNewDis.Location = new System.Drawing.Point(35, 319);
            this.btnNewDis.Name = "btnNewDis";
            this.btnNewDis.Size = new System.Drawing.Size(75, 37);
            this.btnNewDis.TabIndex = 4;
            this.btnNewDis.Text = "Nova Nemoc";
            this.btnNewDis.UseVisualStyleBackColor = true;
            this.btnNewDis.Click += new System.EventHandler(this.btnNewDis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "NactiXML poh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReadDisXMLPoh_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 43);
            this.button2.TabIndex = 0;
            this.button2.Text = "NactiXML pum";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnReadDisXMLPumrti_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 43);
            this.button3.TabIndex = 0;
            this.button3.Text = "NactiXML SWHO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnReadDisXMLSWHO_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(235, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 43);
            this.button4.TabIndex = 0;
            this.button4.Text = "NactiXML tdg";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnReadDisXMLTDG_Click);
            // 
            // btnSpoj
            // 
            this.btnSpoj.Location = new System.Drawing.Point(548, 24);
            this.btnSpoj.Name = "btnSpoj";
            this.btnSpoj.Size = new System.Drawing.Size(119, 43);
            this.btnSpoj.TabIndex = 5;
            this.btnSpoj.Text = "Spoj";
            this.btnSpoj.UseVisualStyleBackColor = true;
            this.btnSpoj.Click += new System.EventHandler(this.btnSpoj_Click);
            // 
            // listBoxSWHO
            // 
            this.listBoxSWHO.FormattingEnabled = true;
            this.listBoxSWHO.Location = new System.Drawing.Point(247, 85);
            this.listBoxSWHO.Name = "listBoxSWHO";
            this.listBoxSWHO.Size = new System.Drawing.Size(206, 95);
            this.listBoxSWHO.TabIndex = 1;
            this.listBoxSWHO.SelectedIndexChanged += new System.EventHandler(this.listBoxSWH_SelectedIndexChanged);
            // 
            // listBoxMKN
            // 
            this.listBoxMKN.FormattingEnabled = true;
            this.listBoxMKN.Location = new System.Drawing.Point(470, 85);
            this.listBoxMKN.Name = "listBoxMKN";
            this.listBoxMKN.Size = new System.Drawing.Size(206, 95);
            this.listBoxMKN.TabIndex = 1;
            this.listBoxMKN.SelectedIndexChanged += new System.EventHandler(this.listBoxTDG_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kod";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazev";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(353, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diagnosa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Platnost od";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(247, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(353, 277);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kod";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(470, 231);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nazev";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(576, 231);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Diagnosa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Platnost od";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(470, 277);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(576, 277);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 379);
            this.Controls.Add(this.btnSpoj);
            this.Controls.Add(this.btnNewDis);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tbPlatnostOd);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tBDiagnosa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlatnost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbldg);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbNazev);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBKod);
            this.Controls.Add(this.lbKod);
            this.Controls.Add(this.listBoxMKN);
            this.Controls.Add(this.listBoxSWHO);
            this.Controls.Add(this.listBoxTDG);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReadDisXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadDisXML;
        private System.Windows.Forms.ListBox listBoxTDG;
        private System.Windows.Forms.Label lbKod;
        private System.Windows.Forms.TextBox tBKod;
        private System.Windows.Forms.Label lblNaz;
        private System.Windows.Forms.TextBox tbNazev;
        private System.Windows.Forms.Label lbldg;
        private System.Windows.Forms.TextBox tBDiagnosa;
        private System.Windows.Forms.Label lblPlatnost;
        private System.Windows.Forms.TextBox tbPlatnostOd;
        private System.Windows.Forms.Button btnNewDis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSpoj;
        private System.Windows.Forms.ListBox listBoxSWHO;
        private System.Windows.Forms.ListBox listBoxMKN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
    }
}

