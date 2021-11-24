using DemoObserver.Models;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Input;

namespace DemoObserver
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produit eau = new Produit("Eau 50cl");
            Produit coca = new Produit("Coca 50cl");
            Acheteur michael = new Acheteur("Michael");
            Acheteur thierry = new Acheteur("Thierry");

            eau.OnNotify += michael.Update;
            eau.OnNotify += thierry.Update;

            eau.Prix = .80;
        }
    }
}
