using System.Collections.Generic;

namespace _20180803_B_TP_heritage
{
    public class Agence
    {
        public Agence()
        {
            Parc = new List<Vehicule>();
            Personnel = new List<Employé>();
        }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }

        public List<Employé> Personnel { get; set; }
        public List<Vehicule> Parc { get; set; }

    }

}
