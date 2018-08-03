using System;

namespace _20180803_B_TP_heritage
{
    public class ContratLocation
    {
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int KilometrageMaximum { get; set; }

        public Vehicule Vehicule { get; set; }
        public Client Client { get; set; }

        public double ClaculerMontantLocation()// tunning
        //public double ClaculerMontantLocation(DateTime dateDebut, DateTime datefin) //BIEN METTRE LE TYPE "double" AVANT
        {

            var nombreDeJour = (DateFin - DateDebut).TotalDays;
            return Vehicule.GetPrixJour() * nombreDeJour; // on peut appeler vehicule car :  public Vehicule Vehicule { get; set; }
            

            //return 0;

           // return default(double);      Variante qui renvoie un zero
        }

        
    }

}
