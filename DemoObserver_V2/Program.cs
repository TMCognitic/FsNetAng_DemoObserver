using DemoObserver.Models;

namespace DemoObserver
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produit eau = new Produit("Eau 50cl");
            Acheteur michael = new Acheteur("Michael");
            Acheteur thierry = new Acheteur("Thierry");

            eau.Attach(michael.Update);
            eau.Attach(thierry.Update);

            eau.Prix = .80;
        }
    }
}
