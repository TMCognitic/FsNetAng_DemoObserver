using DemoObserver.Patterns.Observers;

namespace DemoObserver.Models
{
    public class Acheteur
    {
        public string Nom { get; init; }

        public Acheteur(string nom)
        {
            Nom = nom;
        }

        public void Update(ISubject subject)
        {
            if(subject is Produit p)
            {
                Console.WriteLine($"{Nom} signale que le produit '{p.Nom}' change de prix : {p.Prix}");
            }
        }
    }
}
