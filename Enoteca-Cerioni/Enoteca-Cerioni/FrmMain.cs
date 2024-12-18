using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Enoteca_Cerioni
{
    public partial class FrmMain : Form
    {
        public static ClsCatalogoVini Catalogo = new ClsCatalogoVini(); // inizializzo la lista dal costruttore della classe catalogo
        
        public FrmMain()
        {
            InitializeComponent();
            pnlButtons.Enabled = false;
            btRicerca.Enabled = false;
        }

        #region Crud
        private void btModifica_Click(object sender, EventArgs e)
        {
            string item = LvVini.SelectedItems[0].Text;
            int index = Convert.ToInt16(item) - 1;
            FrmVino frmVino = new FrmVino(index);

            pnlButtons.Enabled = false;

            if (frmVino.ShowDialog() == DialogResult.OK)
                AggiornaListView(Catalogo.Bottiglie);
        }

        private void btInserisci_Click(object sender, EventArgs e)
        {
            FrmVino frmVino = new FrmVino();

            if (frmVino.ShowDialog() == DialogResult.OK)
                AggiornaListView(Catalogo.Bottiglie);
        }

        private void btElimina_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = LvVini.SelectedItems[0];
            string valueAsString = selectedItem.SubItems[0].Text;
            int index = Convert.ToInt16(valueAsString) - 1;

            Catalogo.Bottiglie.RemoveAt(index);

            pnlButtons.Enabled = false;
            AggiornaListView(Catalogo.Bottiglie);
        }

        private void btRicerca_Click(object sender, EventArgs e)
        {
            string NomeVinoDaTrovare = tbNomeVino.Text;
            string NomeProduttoreDaTrovare = tbProduttore.Text;

            LvVini.Items.Clear();

            if (Program.AreValidGenericStrings(NomeProduttoreDaTrovare, NomeVinoDaTrovare))
            {
                foreach (var bottiglia in Catalogo.Bottiglie) //entrambi i filtri
                {
                    if (bottiglia.Nome == NomeVinoDaTrovare 
                        && bottiglia.Produttore.Nome == NomeProduttoreDaTrovare)
                    {
                        CreaListViewItem(LvVini, bottiglia);
                    }
                }
            }
            else if (Program.AreValidGenericStrings(NomeVinoDaTrovare))
            {
                foreach (var bottiglia in Catalogo.Bottiglie) //solo il nome del vino
                {
                    if (bottiglia.Nome == NomeVinoDaTrovare)
                    {
                        CreaListViewItem(LvVini, bottiglia);
                    }
                }
            }
            else if (Program.AreValidGenericStrings(NomeProduttoreDaTrovare))
            {
                foreach (var bottiglia in Catalogo.Bottiglie) //solo il nome del produttore
                {
                    if (bottiglia.Produttore.Nome == NomeProduttoreDaTrovare)
                    {
                        CreaListViewItem(LvVini, bottiglia);
                    }
                }
            }
        }

        #endregion     

        #region  Metodi
        private void AggiornaListView(List<ClsBottigliaDiVino> Bottiglie)
        {
            LvVini.Items.Clear();

            foreach(ClsBottigliaDiVino b in Bottiglie)
            {
                CreaListViewItem(LvVini, b);
            }
        }
        private void CreaListViewItem(ListView lv, ClsBottigliaDiVino b)
        {
            //decidere cosa inserire nella list view
            ListViewItem lvi = new ListViewItem(b.Id.ToString());
            lvi.SubItems.Add(b.Nome);
            lvi.SubItems.Add(b.Anno.ToString());
            lvi.SubItems.Add(b.Produttore.Nome);
            lvi.SubItems.Add(b.Prezzo.ToString());
            lv.Items.Add(lvi);
        }
        #endregion

        #region File
        private void btSalvaFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(); //uso della finestra di dialogo salva file
            sfd.FileName = "Enoteca.csv";
            sfd.Filter = "File di testo (*.csv)|*.txt|Tutti i file (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.OverwritePrompt = true; //chiedo all'utente di sovrascrivere il file
            sfd.CheckFileExists = false;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Thread trd = new Thread(() => ScriviSuFile(sfd, Catalogo.Bottiglie));
                trd.Start();
            }
        }

        private void ScriviSuFile(SaveFileDialog sfd, List<ClsBottigliaDiVino> Bottiglie)
        {
            StreamWriter sw = new StreamWriter(sfd.FileName, false);

            foreach (ClsBottigliaDiVino b in Bottiglie)
            {
                sw.WriteLine
                (
                    b.Id + ", " + b.Nome + ", " + b.Anno + ", " + b.Prezzo + ", " +
                    b.Produttore.Nome + ", " + b.Produttore.Indirizzo + ", " + b.Produttore.Telefono
                );
            }

            sw.Close(); //chiusura del file csv obbligatoria
        }
        #endregion

        #region Eventi Form
        private void tbProduttore_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNomeVino.Text) || string.IsNullOrWhiteSpace(tbProduttore.Text))
                btRicerca.Enabled = false;
            else
                btRicerca.Enabled = true;          
        }

        private void LvVini_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlButtons.Enabled = true;
        }

        private void btOrdina_Click(object sender, EventArgs e)
        {
            LvVini.Items.Clear();
            Catalogo.Bottiglie.Sort((b1, b2) => b1.Nome.CompareTo(b2.Nome)); //ordinamento modificabile con altre proprietà

            pnlButtons.Enabled = false;
            AggiornaListView(Catalogo.Bottiglie);
        }
        #endregion
    }
}
