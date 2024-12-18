namespace Enoteca_Cerioni
{
    partial class FrmVino
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
            this.btSalva = new System.Windows.Forms.Button();
            this.btAnnulla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblProva = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProduttore = new System.Windows.Forms.TextBox();
            this.nudAnno = new System.Windows.Forms.NumericUpDown();
            this.nudPrezzo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIndirizzo = new System.Windows.Forms.TextBox();
            this.pnlParametri = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).BeginInit();
            this.pnlParametri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSalva
            // 
            this.btSalva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSalva.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSalva.Location = new System.Drawing.Point(106, 252);
            this.btSalva.Name = "btSalva";
            this.btSalva.Size = new System.Drawing.Size(210, 66);
            this.btSalva.TabIndex = 9;
            this.btSalva.Text = "Salva";
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click);
            // 
            // btAnnulla
            // 
            this.btAnnulla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnulla.Location = new System.Drawing.Point(12, 252);
            this.btAnnulla.Name = "btAnnulla";
            this.btAnnulla.Size = new System.Drawing.Size(88, 66);
            this.btAnnulla.TabIndex = 8;
            this.btAnnulla.Text = "Annulla";
            this.btAnnulla.UseVisualStyleBackColor = true;
            this.btAnnulla.Click += new System.EventHandler(this.btAnnulla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome :";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(140, 9);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 6;
            // 
            // lblProva
            // 
            this.lblProva.AutoSize = true;
            this.lblProva.BackColor = System.Drawing.Color.White;
            this.lblProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProva.Location = new System.Drawing.Point(10, 9);
            this.lblProva.Name = "lblProva";
            this.lblProva.Size = new System.Drawing.Size(158, 20);
            this.lblProva.TabIndex = 5;
            this.lblProva.Text = "Inserisci / Modifica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Anno :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Produttore :";
            // 
            // tbProduttore
            // 
            this.tbProduttore.Location = new System.Drawing.Point(141, 41);
            this.tbProduttore.Name = "tbProduttore";
            this.tbProduttore.Size = new System.Drawing.Size(100, 20);
            this.tbProduttore.TabIndex = 12;
            // 
            // nudAnno
            // 
            this.nudAnno.Location = new System.Drawing.Point(140, 75);
            this.nudAnno.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nudAnno.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nudAnno.Name = "nudAnno";
            this.nudAnno.Size = new System.Drawing.Size(101, 20);
            this.nudAnno.TabIndex = 14;
            this.nudAnno.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // nudPrezzo
            // 
            this.nudPrezzo.Location = new System.Drawing.Point(140, 111);
            this.nudPrezzo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudPrezzo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrezzo.Name = "nudPrezzo";
            this.nudPrezzo.Size = new System.Drawing.Size(101, 20);
            this.nudPrezzo.TabIndex = 16;
            this.nudPrezzo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Prezzo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "€";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "Indirizzo Produttore :";
            // 
            // tbIndirizzo
            // 
            this.tbIndirizzo.Location = new System.Drawing.Point(140, 146);
            this.tbIndirizzo.Name = "tbIndirizzo";
            this.tbIndirizzo.Size = new System.Drawing.Size(100, 20);
            this.tbIndirizzo.TabIndex = 21;
            // 
            // pnlParametri
            // 
            this.pnlParametri.Controls.Add(this.mtbTelefono);
            this.pnlParametri.Controls.Add(this.label6);
            this.pnlParametri.Controls.Add(this.tbNome);
            this.pnlParametri.Controls.Add(this.label7);
            this.pnlParametri.Controls.Add(this.label1);
            this.pnlParametri.Controls.Add(this.tbIndirizzo);
            this.pnlParametri.Controls.Add(this.label2);
            this.pnlParametri.Controls.Add(this.label5);
            this.pnlParametri.Controls.Add(this.tbProduttore);
            this.pnlParametri.Controls.Add(this.nudPrezzo);
            this.pnlParametri.Controls.Add(this.label3);
            this.pnlParametri.Controls.Add(this.label4);
            this.pnlParametri.Controls.Add(this.nudAnno);
            this.pnlParametri.Location = new System.Drawing.Point(12, 41);
            this.pnlParametri.Name = "pnlParametri";
            this.pnlParametri.Size = new System.Drawing.Size(301, 205);
            this.pnlParametri.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 23;
            this.label6.Text = "Telefono :";
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(140, 179);
            this.mtbTelefono.Mask = "0000000000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(67, 20);
            this.mtbTelefono.TabIndex = 24;
            // 
            // FrmVino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(325, 330);
            this.Controls.Add(this.pnlParametri);
            this.Controls.Add(this.btSalva);
            this.Controls.Add(this.btAnnulla);
            this.Controls.Add(this.lblProva);
            this.MaximumSize = new System.Drawing.Size(341, 369);
            this.MinimumSize = new System.Drawing.Size(341, 369);
            this.Name = "FrmVino";
            this.Text = "FrmVino";
            ((System.ComponentModel.ISupportInitialize)(this.nudAnno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).EndInit();
            this.pnlParametri.ResumeLayout(false);
            this.pnlParametri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalva;
        private System.Windows.Forms.Button btAnnulla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblProva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProduttore;
        private System.Windows.Forms.NumericUpDown nudAnno;
        private System.Windows.Forms.NumericUpDown nudPrezzo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIndirizzo;
        private System.Windows.Forms.Panel pnlParametri;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.Label label6;
    }
}