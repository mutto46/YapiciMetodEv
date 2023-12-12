using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetodEv
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Home home = new Home();
            Console.WriteLine("Oda sayıs:{0} Metre Kare:{1}",home.OdaSayisi,home.MetreKare);
        }
       
    }
    class Home
    {
        int odaSayisi;
        int metreKare;
        public Home()  
        {
            odaSayisi = 12;
            metreKare = 30;
        }
        public int OdaSayisi
        {
            get { return odaSayisi; }
        }
        public int MetreKare
        {
            get
            {
                return metreKare;
            }
        }
    }

}
