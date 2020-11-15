using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarijableVjezba4
{
    class Program
    {
        static void Main(string[] args)
        {
            string znakovi, sMala, sVelika, sZadnjihPet, sPrvaTri, s8_11;
            int odabir;


            Console.WriteLine("upisite rijec: ");
            znakovi = Console.ReadLine();
            Console.Write("Upisite 1 za pretvorbu u velika slova, 2 za pretvorbu u mala slova,3 za ispis prva tri znaka, 4 ispis zadnjih 5 znakova,5 ispis od 8 znaka do 11 znaka: ");
            odabir = Convert.ToInt32(Console.ReadLine());


            switch (odabir)
            {
                case 1:
                    sVelika = znakovi.ToUpper(); Console.WriteLine("U velika slova  " + sVelika);
                    break;
                case 2:
                    sMala = znakovi.ToLower(); Console.WriteLine("U mala slova  " + sMala);
                    break;
                case 3:
                    sPrvaTri = znakovi.Substring(0, 3); Console.WriteLine("Prva tri " + sPrvaTri);
                    break;
                case 4:
                    sZadnjihPet = znakovi.Substring(Math.Max(0, znakovi.Length - 5)); Console.WriteLine("Zadnja 5" + sZadnjihPet);
                    break;
                case 5:
                    s8_11 = znakovi.Substring(Math.Max(7, 6)); Console.WriteLine("8 do 11 " + s8_11);
                    break;


            }




            Console.ReadLine();

        }
    }
}

