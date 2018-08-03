namespace _20180803_B_TP_heritage
{
    public class Voiture : Vehicule
    {
        public int NombreDePorte { get; set; } = 5;
        //ne pas oublier le get set sinon c'est un champ et pas un parametre 
        //finir par =X; donne une valeur par defaut

        public CategorieVoiture Categorie { get; set; }
    }

}
