using DemoObserver.Patterns.Observers;

namespace DemoObserver.Models
{
    public class Produit : Subject
    {
        private double _prix;
        public string Nom { get; init; }
        public double Prix
        {
            get { return _prix; } 
            set
            {
                if(_prix != value)
                {
                    _prix = value;
                    Notify();
                }
            } 
        }

        public Produit(string nom)
        {
            Nom = nom;
        }
    }
}
