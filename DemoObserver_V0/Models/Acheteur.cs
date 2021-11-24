using DemoObserver.Patterns.Observers;

namespace DemoObserver.Models
{
    public class Acheteur : Observer
    {
        public string Nom { get; init; }

        public Acheteur(string nom)
        {
            Nom = nom;
        }

        public override void Update(Subject subject)
        {
            if(subject is Produit p)
            {
                Console.WriteLine($"{Nom} signale que le produit '{p.Nom}' change de prix : {p.Prix}");
            }
        }
    }
}
