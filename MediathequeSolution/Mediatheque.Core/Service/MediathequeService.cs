using System.Collections.Generic;
using Mediatheque.Core.Model;

namespace Mediatheque.Core.Service
{
    public class MediathequeService
    {
        private List<ObjetDePret> _fondDeCommerce = new List<ObjetDePret>();
        private INotationService _notationService;

        public MediathequeService(INotationService notationService)
        {
            _notationService = notationService;
        }

        public void AddObjet(ObjetDePret objet)
        {
            _fondDeCommerce.Add(objet);
        }

        public int GetNombreObjet()
        {
            return _fondDeCommerce.Count;
        }

        public List<string> PresentationJeuxDeSociete()
        {
            List<string> result = new List<string>();

            bool jeuxDeSocieteExistent = false;

            foreach (var objet in _fondDeCommerce)
            {
                if (objet is JeuxDeSociete)
                {
                    jeuxDeSocieteExistent = true;
                    JeuxDeSociete jeu = (JeuxDeSociete)objet;

                    double note = _notationService.GetNoteJeuxSociete(jeu.Nom);
                    string description = $"Nom: {jeu.Nom}, Editeur: {jeu.Editeur}, Tranches d'âge: {jeu.AgeMinimum}-{jeu.AgeMaximum}, Note: {note}/5";
                    result.Add(description);
                }
            }

            if (!jeuxDeSocieteExistent)
            {
                result.Add("Il n'y a pas de jeux de société à afficher.");
            }

            return result;
        }
    }
}
