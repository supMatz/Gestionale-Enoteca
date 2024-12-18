using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enoteca_Cerioni
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }

        #region Controlli generici
        public static bool AreValidGenericStrings(params string[] stringhe)
        {
            for(int i = 0; i < stringhe.Length; i++)
                if (string.IsNullOrWhiteSpace(stringhe[i])) //gestione parametri anche nulli
                    return false;
            return true;
        }
        #endregion
    }
}
