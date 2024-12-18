using System;
using System.Linq;
using System.Windows.Forms;

namespace Enoteca_Cerioni
{
    public partial class FrmVino : Form
    {
        #region Var
        bool IsModifica;
        int Num;
        #endregion

        public FrmVino(int index) //per modifiche
        {
            InitializeComponent();
            IsModifica = true;
            Num = index;
        }
        public FrmVino() //per inserimenti
        {
            InitializeComponent();
            IsModifica = false;
        }

        #region Eventi form
        private void btSalva_Click(object sender, EventArgs e)
        {
            //acquisizione variabili
            string NomeBottiglia = tbNome.Text;
            string NomeProduttore = tbProduttore.Text;
            short Anno = (short)nudAnno.Value;
            decimal Prezzo = nudPrezzo.Value;
            uint Telefono = (uint)Convert.ToInt64(mtbTelefono.Text);
            string Indirizzo = tbIndirizzo.Text;

            //aggiornamento
            AggiornamentoLista(NomeBottiglia, NomeProduttore, Anno, Prezzo, Telefono, Indirizzo, IsModifica);
        }
        private void btAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodi
        private void AggiornamentoLista(string nome, string nomeProduttore, short anno, decimal prezzo, uint telefono, string indirizzo, bool IsModifica)
        {
            if (IsModifica)
            {
                var temp = FrmMain.Catalogo.Bottiglie[Num];
                temp.Nome = nome;
                temp.Produttore.Nome = nomeProduttore;
                temp.Anno = anno;
                temp.Prezzo = prezzo;
                temp.Produttore.Telefono = telefono;
                temp.Produttore.Indirizzo = indirizzo;

                FrmMain.Catalogo.Bottiglie[Num] = temp;
            }
            else
            {
                ClsBottigliaDiVino bottiglia = new ClsBottigliaDiVino();
                bottiglia.Nome = nome;
                bottiglia.Produttore.Nome = nomeProduttore;
                bottiglia.Anno = anno;
                bottiglia.Prezzo = prezzo;
                bottiglia.Produttore.Telefono = telefono;
                bottiglia.Produttore.Indirizzo = indirizzo;

                FrmMain.Catalogo.Bottiglie.Add(bottiglia);
                bottiglia.Id = FrmMain.Catalogo.Bottiglie.Count();
            }
        }
        #endregion
    }
}
