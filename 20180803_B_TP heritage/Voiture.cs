namespace _20180803_B_TP_heritage
{
    public class Voiture : Vehicule
    {
        public int NombreDePorte { get; set; } = 5; //ne pas oublier le get set

        public CategorieVoiture Categorie { get; set; }
    }

}
