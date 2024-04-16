using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Mediatheque.Core.Model
{
    public class ObjetDePret
    {

        public int Id { get; set; }
        public string TitreDeLObjet { get; set; }
        public string Emprunteur { get; set; }

        public ObjetDePret(string titreDeLObjet)
        {
            TitreDeLObjet = titreDeLObjet;
        }

        public bool Emprunte(string emprunteur)
        {
            if (Emprunteur == null)
            {
                Emprunteur = emprunteur;
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }
}
