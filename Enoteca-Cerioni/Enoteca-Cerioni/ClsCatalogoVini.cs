using System.Collections.Generic;
using System.Linq;

namespace Enoteca_Cerioni
{
    public class ClsCatalogoVini
    {
        public List<ClsBottigliaDiVino> Bottiglie { get; set; }

        public ClsCatalogoVini()
        {
            Bottiglie = new List<ClsBottigliaDiVino>();
        }
    }
}

