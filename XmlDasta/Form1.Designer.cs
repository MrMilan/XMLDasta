namespace XmlDasta
{
    partial class NacitaniXML
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
            this.lbTDG = new System.Windows.Forms.Label();
            this.btnNewDis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSpoj = new System.Windows.Forms.Button();
            this.listBoxSWHO = new System.Windows.Forms.ListBox();
            this.listBoxMKN = new System.Windows.Forms.ListBox();
            this.lbSWHO = new System.Windows.Forms.Label();
            this.lbMKN = new System.Windows.Forms.Label();
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
            // lbTDG
            // 
            this.lbTDG.AutoSize = true;
            this.lbTDG.Location = new System.Drawing.Point(32, 200);
            this.lbTDG.Name = "lbTDG";
            this.lbTDG.Size = new System.Drawing.Size(30, 13);
            this.lbTDG.TabIndex = 2;
            this.lbTDG.Text = "TDG";
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
            this.button2.Location = new System.Drawing.Point(235, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 43);
            this.button2.TabIndex = 0;
            this.button2.Text = "NactiXML pum";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnReadDisXMLPumrti_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 43);
            this.button3.TabIndex = 0;
            this.button3.Text = "NactiXML SWHO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnReadDisXMLSWHO_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(423, 24);
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
            this.listBoxMKN.SelectedIndexChanged += new System.EventHandler(this.listBoxMKN_SelectedIndexChanged);
            // 
            // lbSWHO
            // 
            this.lbSWHO.AutoSize = true;
            this.lbSWHO.Location = new System.Drawing.Point(244, 200);
            this.lbSWHO.Name = "lbSWHO";
            this.lbSWHO.Size = new System.Drawing.Size(41, 13);
            this.lbSWHO.TabIndex = 2;
            this.lbSWHO.Text = "SWHO";
            // 
            // lbMKN
            // 
            this.lbMKN.AutoSize = true;
            this.lbMKN.Location = new System.Drawing.Point(467, 200);
            this.lbMKN.Name = "lbMKN";
            this.lbMKN.Size = new System.Drawing.Size(31, 13);
            this.lbMKN.TabIndex = 2;
            this.lbMKN.Text = "MKN";
            // 
            // NacitaniXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 379);
            this.Controls.Add(this.btnSpoj);
            this.Controls.Add(this.btnNewDis);
            this.Controls.Add(this.lbMKN);
            this.Controls.Add(this.lbSWHO);
            this.Controls.Add(this.lbTDG);
            this.Controls.Add(this.listBoxMKN);
            this.Controls.Add(this.listBoxSWHO);
            this.Controls.Add(this.listBoxTDG);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReadDisXML);
            this.Name = "NacitaniXML";
            this.Text = "NacitaniXML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadDisXML;
        private System.Windows.Forms.ListBox listBoxTDG;
        private System.Windows.Forms.Label lbTDG;
        private System.Windows.Forms.Button btnNewDis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSpoj;
        private System.Windows.Forms.ListBox listBoxSWHO;
        private System.Windows.Forms.ListBox listBoxMKN;
        private System.Windows.Forms.Label lbSWHO;
        private System.Windows.Forms.Label lbMKN;
    }
}

