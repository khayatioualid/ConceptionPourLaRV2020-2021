using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Version 1 qui travaille avec la collection Vectorian
            /*
            Chair ch = new ChairVectorian();
            ch.affiche();
            Sofa so = new SofaVectorian();
            so.affiche();
            */
            //Version 2 qui travaille avec la collection ArtDeco
            /*
            Chair ch = new ChairArtDeco();
            ch.affiche();
            Sofa so = new SofaArtDeco();
            so.affiche();
            Console.ReadLine();
            */
            FabriqueAbstraite fabrique = new ArtDecoFactory();
            Chair ch = fabrique.CreateChair();
            ch.affiche();
            Sofa so = fabrique.CreateSofa();
            so.affiche();
            Console.ReadLine();
        }
    }
}
