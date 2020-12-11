namespace budicPolugodiste
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
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.labelMarka = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelSnaga = new System.Windows.Forms.Label();
            this.labelPovezivost = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxSnaga = new System.Windows.Forms.TextBox();
            this.comboBoxPovezivost = new System.Windows.Forms.ComboBox();
            this.listBoxIspis = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(154, 29);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(217, 178);
            this.btnUnesi.TabIndex = 0;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(390, 29);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(210, 178);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Obradi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(632, 29);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(192, 178);
            this.btnIspisi.TabIndex = 2;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Location = new System.Drawing.Point(9, 9);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(47, 17);
            this.labelMarka.TabIndex = 3;
            this.labelMarka.Text = "Marka";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(12, 64);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(46, 17);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Model";
            // 
            // labelSnaga
            // 
            this.labelSnaga.AutoSize = true;
            this.labelSnaga.Location = new System.Drawing.Point(12, 109);
            this.labelSnaga.Name = "labelSnaga";
            this.labelSnaga.Size = new System.Drawing.Size(49, 17);
            this.labelSnaga.TabIndex = 5;
            this.labelSnaga.Text = "Snaga";
            // 
            // labelPovezivost
            // 
            this.labelPovezivost.AutoSize = true;
            this.labelPovezivost.Location = new System.Drawing.Point(12, 163);
            this.labelPovezivost.Name = "labelPovezivost";
            this.labelPovezivost.Size = new System.Drawing.Size(76, 17);
            this.labelPovezivost.TabIndex = 6;
            this.labelPovezivost.Text = "Povezivost";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(12, 29);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(100, 22);
            this.textBoxMarka.TabIndex = 7;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(12, 84);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 22);
            this.textBoxModel.TabIndex = 8;
            // 
            // textBoxSnaga
            // 
            this.textBoxSnaga.Location = new System.Drawing.Point(12, 129);
            this.textBoxSnaga.Name = "textBoxSnaga";
            this.textBoxSnaga.Size = new System.Drawing.Size(100, 22);
            this.textBoxSnaga.TabIndex = 9;
            // 
            // comboBoxPovezivost
            // 
            this.comboBoxPovezivost.FormattingEnabled = true;
            this.comboBoxPovezivost.Items.AddRange(new object[] {
            "Žičano",
            "Bežično"});
            this.comboBoxPovezivost.Location = new System.Drawing.Point(12, 183);
            this.comboBoxPovezivost.Name = "comboBoxPovezivost";
            this.comboBoxPovezivost.Size = new System.Drawing.Size(118, 24);
            this.comboBoxPovezivost.TabIndex = 10;
            // 
            // listBoxIspis
            // 
            this.listBoxIspis.FormattingEnabled = true;
            this.listBoxIspis.ItemHeight = 16;
            this.listBoxIspis.Location = new System.Drawing.Point(12, 227);
            this.listBoxIspis.Name = "listBoxIspis";
            this.listBoxIspis.Size = new System.Drawing.Size(812, 244);
            this.listBoxIspis.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 483);
            this.Controls.Add(this.listBoxIspis);
            this.Controls.Add(this.comboBoxPovezivost);
            this.Controls.Add(this.textBoxSnaga);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.labelPovezivost);
            this.Controls.Add(this.labelSnaga);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMarka);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.btnUnesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelSnaga;
        private System.Windows.Forms.Label labelPovezivost;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxSnaga;
        private System.Windows.Forms.ComboBox comboBoxPovezivost;
        private System.Windows.Forms.ListBox listBoxIspis;
    }
}

