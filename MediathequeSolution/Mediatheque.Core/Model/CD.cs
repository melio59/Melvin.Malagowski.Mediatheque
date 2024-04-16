namespace Mediatheque.Core.Model
{
    public class CD : ObjetDePret
    {
        public string GroupeDeMusique { get; set; }
        public DateTime DateDeSortie { get; set; }

        public CD() : base("")
        {

        }

        public CD(string titreDeLObjet, string groupe) : base(titreDeLObjet)
        {
            GroupeDeMusique = groupe;
        }
    }
}