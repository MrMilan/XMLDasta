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
            this.listBoxNemoci = new System.Windows.Forms.ListBox();
            this.lbKod = new System.Windows.Forms.Label();
            this.tBKod = new System.Windows.Forms.TextBox();
            this.lblNaz = new System.Windows.Forms.Label();
            this.tbNazev = new System.Windows.Forms.TextBox();
            this.lbldg = new System.Windows.Forms.Label();
            this.tBDiagnosa = new System.Windows.Forms.TextBox();
            this.lblPlatnost = new System.Windows.Forms.Label();
            this.tbPlatnostOd = new System.Windows.Forms.TextBox();
            this.btnNewDis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadDisXML
            // 
            this.btnReadDisXML.Location = new System.Drawing.Point(35, 24);
            this.btnReadDisXML.Name = "btnReadDisXML";
            this.btnReadDisXML.Size = new System.Drawing.Size(88, 43);
            this.btnReadDisXML.TabIndex = 0;
            this.btnReadDisXML.Text = "NactiXML Nemoci";
            this.btnReadDisXML.UseVisualStyleBackColor = true;
            this.btnReadDisXML.Click += new System.EventHandler(this.btnReadDisXML_Click);
            // 
            // listBoxNemoci
            // 
            this.listBoxNemoci.FormattingEnabled = true;
            this.listBoxNemoci.Location = new System.Drawing.Point(35, 85);
            this.listBoxNemoci.Name = "listBoxNemoci";
            this.listBoxNemoci.Size = new System.Drawing.Size(206, 95);
            this.listBoxNemoci.TabIndex = 1;
            this.listBoxNemoci.SelectedIndexChanged += new System.EventHandler(this.listBoxNemoci_SelectedIndexChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 379);
            this.Controls.Add(this.btnNewDis);
            this.Controls.Add(this.tbPlatnostOd);
            this.Controls.Add(this.tBDiagnosa);
            this.Controls.Add(this.lblPlatnost);
            this.Controls.Add(this.lbldg);
            this.Controls.Add(this.tbNazev);
            this.Controls.Add(this.lblNaz);
            this.Controls.Add(this.tBKod);
            this.Controls.Add(this.lbKod);
            this.Controls.Add(this.listBoxNemoci);
            this.Controls.Add(this.btnReadDisXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadDisXML;
        private System.Windows.Forms.ListBox listBoxNemoci;
        private System.Windows.Forms.Label lbKod;
        private System.Windows.Forms.TextBox tBKod;
        private System.Windows.Forms.Label lblNaz;
        private System.Windows.Forms.TextBox tbNazev;
        private System.Windows.Forms.Label lbldg;
        private System.Windows.Forms.TextBox tBDiagnosa;
        private System.Windows.Forms.Label lblPlatnost;
        private System.Windows.Forms.TextBox tbPlatnostOd;
        private System.Windows.Forms.Button btnNewDis;
    }
}

