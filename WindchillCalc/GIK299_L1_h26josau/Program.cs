namespace GIK299_L1_h26josau;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till WindChill kalkylatorn.");
        bool tempraturFunkar = false;
        double temprat = 0;
        while (!tempraturFunkar)
        {
            Console.WriteLine("Ange tempraturen i celcius:");
            string tempraturInfo = Console.ReadLine();
            if (double.TryParse(tempraturInfo, out temprat))
            {
                tempraturFunkar = true;
            }
            else
            {
                Console.WriteLine("Fel, Ange tempraturen i celcius med siffror.");
            }

        }

        bool enhetFunkar = false;
        string vindEnhet = "";
        while (!enhetFunkar)
        {
            Console.WriteLine("Välj vilken enhet du vill räkna vindhastigheten med, m/s eller km/h");
            vindEnhet = Console.ReadLine();
            if (vindEnhet == "m/s")
            {
                enhetFunkar = true;
            }
            else if ( vindEnhet == "km/h")
            {
                enhetFunkar = true; 
            }
            else
            {
                Console.WriteLine("Fel enhet , välj skriv antigen m/s eller km/h.");
            }
        }
        bool vindhFunkar = false;
        
        double vindHastigheten = 0; 
        while (!vindhFunkar)
        {
            Console.WriteLine("Ange vindhastigheten:");
            string vindHast  = Console.ReadLine();
            if (double.TryParse(vindHast, out vindHastigheten))
            {
                if (vindHastigheten >= 0)
                {
                    vindhFunkar = true;
                }
                else
                {
                    Console.WriteLine("Fel, vindhastigheten kan inte vara negativ."); 
                }
            }
            else
            {
                Console.WriteLine("Fel, Ange vindhastigheten med siffror.");
            }
            

        }
        
        if (vindEnhet == ("m/s"))
        {
            vindHastigheten = vindHastigheten * 3.6;
           
        }

        double wct = 0;
        wct = 13.12 + 0.6215 * temprat - 11.37 * Math.Pow(vindHastigheten, 0.16) + 0.3965 * temprat * Math.Pow(vindHastigheten, 0.16);
        Console.WriteLine("Enligt Wind Chill kalkylatorn känns tempraturen som  " + wct.ToString("f1") + " grader."); 







    }





            

}    


    