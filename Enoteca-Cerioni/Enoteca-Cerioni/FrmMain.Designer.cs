namespace Enoteca_Cerioni
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSalvaSuFile = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btElimina = new System.Windows.Forms.Button();
            this.btModifica = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProduttore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomeVino = new System.Windows.Forms.TextBox();
            this.btRicerca = new System.Windows.Forms.Button();
            this.lblFiltri = new System.Windows.Forms.Label();
            this.btInserisci = new System.Windows.Forms.Button();
            this.LvVini = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNomeProduttore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btOrdina = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSalvaSuFile
            // 
            this.btSalvaSuFile.Location = new System.Drawing.Point(519, 316);
            this.btSalvaSuFile.Name = "btSalvaSuFile";
            this.btSalvaSuFile.Size = new System.Drawing.Size(75, 23);
            this.btSalvaSuFile.TabIndex = 7;
            this.btSalvaSuFile.Text = "Salva su File";
            this.btSalvaSuFile.UseVisualStyleBackColor = true;
            this.btSalvaSuFile.Click += new System.EventHandler(this.btSalvaFile_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btElimina);
            this.pnlButtons.Controls.Add(this.btModifica);
            this.pnlButtons.Location = new System.Drawing.Point(516, 221);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(83, 60);
            this.pnlButtons.TabIndex = 5;
            // 
            // btElimina
            // 
            this.btElimina.Location = new System.Drawing.Point(3, 32);
            this.btElimina.Name = "btElimina";
            this.btElimina.Size = new System.Drawing.Size(75, 23);
            this.btElimina.TabIndex = 3;
            this.btElimina.Text = "Elimina";
            this.btElimina.UseVisualStyleBackColor = true;
            this.btElimina.Click += new System.EventHandler(this.btElimina_Click);
            // 
            // btModifica
            // 
            this.btModifica.Location = new System.Drawing.Point(3, 3);
            this.btModifica.Name = "btModifica";
            this.btModifica.Size = new System.Drawing.Size(75, 23);
            this.btModifica.TabIndex = 2;
            this.btModifica.Text = "Modifica";
            this.btModifica.UseVisualStyleBackColor = true;
            this.btModifica.Click += new System.EventHandler(this.btModifica_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbProduttore);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbNomeVino);
            this.panel1.Controls.Add(this.btRicerca);
            this.panel1.Controls.Add(this.lblFiltri);
            this.panel1.Location = new System.Drawing.Point(13, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 95);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Produttore :";
            // 
            // tbProduttore
            // 
            this.tbProduttore.Location = new System.Drawing.Point(269, 45);
            this.tbProduttore.Name = "tbProduttore";
            this.tbProduttore.Size = new System.Drawing.Size(100, 20);
            this.tbProduttore.TabIndex = 8;
            this.tbProduttore.TextChanged += new System.EventHandler(this.tbProduttore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome :";
            // 
            // tbNomeVino
            // 
            this.tbNomeVino.Location = new System.Drawing.Point(74, 45);
            this.tbNomeVino.Name = "tbNomeVino";
            this.tbNomeVino.Size = new System.Drawing.Size(100, 20);
            this.tbNomeVino.TabIndex = 5;
            // 
            // btRicerca
            // 
            this.btRicerca.Location = new System.Drawing.Point(393, 31);
            this.btRicerca.Name = "btRicerca";
            this.btRicerca.Size = new System.Drawing.Size(55, 46);
            this.btRicerca.TabIndex = 4;
            this.btRicerca.Text = "Ricerca";
            this.btRicerca.UseVisualStyleBackColor = true;
            this.btRicerca.Click += new System.EventHandler(this.btRicerca_Click);
            // 
            // lblFiltri
            // 
            this.lblFiltri.AutoSize = true;
            this.lblFiltri.BackColor = System.Drawing.Color.White;
            this.lblFiltri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltri.Location = new System.Drawing.Point(4, 4);
            this.lblFiltri.Name = "lblFiltri";
            this.lblFiltri.Size = new System.Drawing.Size(122, 20);
            this.lblFiltri.TabIndex = 0;
            this.lblFiltri.Text = "Filtri di ricerca";
            // 
            // btInserisci
            // 
            this.btInserisci.Location = new System.Drawing.Point(519, 192);
            this.btInserisci.Name = "btInserisci";
            this.btInserisci.Size = new System.Drawing.Size(75, 23);
            this.btInserisci.TabIndex = 6;
            this.btInserisci.Text = "Inserisci";
            this.btInserisci.UseVisualStyleBackColor = true;
            this.btInserisci.Click += new System.EventHandler(this.btInserisci_Click);
            // 
            // LvVini
            // 
            this.LvVini.BackColor = System.Drawing.SystemColors.Window;
            this.LvVini.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNome,
            this.chAnno,
            this.chNomeProduttore,
            this.chPrezzo});
            this.LvVini.FullRowSelect = true;
            this.LvVini.HideSelection = false;
            this.LvVini.Location = new System.Drawing.Point(13, 136);
            this.LvVini.Name = "LvVini";
            this.LvVini.Size = new System.Drawing.Size(470, 239);
            this.LvVini.TabIndex = 4;
            this.LvVini.UseCompatibleStateImageBehavior = false;
            this.LvVini.View = System.Windows.Forms.View.Details;
            this.LvVini.SelectedIndexChanged += new System.EventHandler(this.LvVini_SelectedIndexChanged);
            // 
            // chId
            // 
            this.chId.Text = "Id";
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 79;
            // 
            // chAnno
            // 
            this.chAnno.Text = "Anno";
            this.chAnno.Width = 96;
            // 
            // chNomeProduttore
            // 
            this.chNomeProduttore.Text = "Produttore";
            this.chNomeProduttore.Width = 105;
            // 
            // chPrezzo
            // 
            this.chPrezzo.Text = "Prezzo";
            this.chPrezzo.Width = 92;
            // 
            // btOrdina
            // 
            this.btOrdina.Location = new System.Drawing.Point(519, 287);
            this.btOrdina.Name = "btOrdina";
            this.btOrdina.Size = new System.Drawing.Size(75, 23);
            this.btOrdina.TabIndex = 8;
            this.btOrdina.Text = "Ordina";
            this.btOrdina.UseVisualStyleBackColor = true;
            this.btOrdina.Click += new System.EventHandler(this.btOrdina_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(608, 388);
            this.Controls.Add(this.btOrdina);
            this.Controls.Add(this.btSalvaSuFile);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btInserisci);
            this.Controls.Add(this.LvVini);
            this.MaximumSize = new System.Drawing.Size(624, 427);
            this.MinimumSize = new System.Drawing.Size(624, 427);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.pnlButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSalvaSuFile;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btElimina;
        private System.Windows.Forms.Button btModifica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRicerca;
        private System.Windows.Forms.Label lblFiltri;
        private System.Windows.Forms.Button btInserisci;
        private System.Windows.Forms.ListView LvVini;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProduttore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomeVino;
        private System.Windows.Forms.ColumnHeader chAnno;
        private System.Windows.Forms.ColumnHeader chNomeProduttore;
        private System.Windows.Forms.ColumnHeader chPrezzo;
        private System.Windows.Forms.Button btOrdina;
    }
}

