namespace _20180803_B_TP_heritage
{
    public class Camionette : Vehicule
    {
        public int PoidsMaxEnKilo { get; set; }
        public int PrixJour { get; set; }

        public override double GetPrixJour() // a cause du abstract sur vehicule
        {
            return PrixJour;           
        }
    }

}
