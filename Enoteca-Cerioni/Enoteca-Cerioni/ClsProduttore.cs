using System;
using System.Collections.Generic;

namespace Enoteca_Cerioni
{
    public class ClsProduttore //ogni produttore dovrebbe avere una lista di bottiglie per essere più realistico
    {
        public ClsProduttore()
        {
            //Bottiglie = new List<ClsBottigliaDiVino>();
        }

        #region Var
        private int _id;
        private string _nome;
        private string _indirizzo;
        private uint _telefono;
        #endregion

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
        public string Indirizzo
        {
            get => _indirizzo;
            set
            {
                if (Program.AreValidGenericStrings(value))
                    _indirizzo = value;
                else
                    throw new ArgumentException("Indirizzo non valido");
            }
        }
        public uint Telefono
        {
            get => _telefono;
            set
            {
                if (value > 0)
                    _telefono = value;
                else
                    throw new ArgumentException("Numero telefonico non valido");
            }
        }
        //public List<ClsBottigliaDiVino> Bottiglie { get; set; }
        #endregion
    }

}
