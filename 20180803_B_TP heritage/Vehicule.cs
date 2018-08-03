namespace _20180803_B_TP_heritage
{
    public abstract class Vehicule
    {
        public string Marque { get; set; }
        public string Modele { get; set; }

        public abstract double GetPrixJour(); //passage en abstract
        /*
        {
            return 0;
        }
        */
    }

}
