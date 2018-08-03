using System.Collections.Generic;

namespace _20180803_B_TP_heritage
{
    public class Client : Personne
    {
        public string Numero { get; set; }

        public List<ContratLocation> Contrats { get; set; }
    }

}
