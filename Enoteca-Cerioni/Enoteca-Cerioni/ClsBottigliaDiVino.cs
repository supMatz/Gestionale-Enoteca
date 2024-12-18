using System;

namespace Enoteca_Cerioni
{
    public class ClsBottigliaDiVino
    {
        #region Var
        private int _id;
        private string _nome;
        private short _anno;
        private decimal _prezzo;
        #endregion

        public ClsBottigliaDiVino()
        {
            Produttore = new ClsProduttore();
        }

        #region Proprietà
        public int Id
        {
            get => _id;
            set
            {
                if (value > 0)
                    _id = value;
                else
                    throw new ArgumentException("Id non valido");
            }
        }
        public string Nome
        {
            get => _nome;
            set
            {
                if (Program.AreValidGenericStrings(value))
                    _nome = value;
                else
                    throw new ArgumentException("Nome non valido");
            }
        }
        public short Anno
        {
            get => _anno;
            set
            {
                if (value > 0)
                    _anno = value;
                else
                    throw new ArgumentException("Anno di produzione non valido");
            }
        }
        public decimal Prezzo
        {
            get => _prezzo;
            set
            {
                if (value > 0)
                    _prezzo = value;
                else
                    throw new ArgumentException("Prezzo bottiglia non valido");
            }
        }
        public ClsProduttore Produttore { get; set; }
        #endregion
    }
}
