using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace _20180803_B_TP_heritage
{
    class Program
    {
        static void Main(string[] args)
        {

            var agence = new Agence();
            agence.Nom = "budget";
            agence.Ville = "Paris";

            var client = new Client();
            client.Nom = "Turiot";
            client.Prenom = "Fred";
            client.Numero = "0001";

            var categorieCompacte = new CategorieVoiture();
            categorieCompacte.Nom = "compacte";
            categorieCompacte.PrixJour = 40;

            var categorieFamiliale = new CategorieVoiture();
            categorieFamiliale.Nom = "familiale";
            categorieFamiliale.PrixJour = 75;

            var voiture1 = new Voiture();
            voiture1.Categorie = categorieCompacte;
            voiture1.Marque = "Peugeot";
            voiture1.Modele = "308";

           
            agence.Parc.Add(voiture1);   //possible car le tableau est cree par une methode lors de l'instanciation de agence
            Console.WriteLine($"Nombre de voiture: {agence.Parc.Count}");

            var contratLocation = new ContratLocation();
            contratLocation.Client = client;
            contratLocation.DateDebut = DateTime.Today;
            contratLocation.DateFin = DateTime.Today.AddDays(5);
            contratLocation.KilometrageMaximum = 500;
            contratLocation.Vehicule = voiture1;

            Console.WriteLine($"contrat pour {contratLocation.Client.Nom} {contratLocation.Client.Prenom}" +
                $" {contratLocation.ClaculerMontantLocation()}EUR");




        }
    }

}
