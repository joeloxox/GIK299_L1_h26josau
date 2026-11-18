namespace GIK299_L1_h26josau;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till WindChill kalkylatorn.");
        bool tempraturFunkar = false;
        while (!tempraturFunkar)
        {
        Console.Write("Ange tempraturen i celcius: ");
        string tempraturInfo = Console.ReadLine();
        if ( double.TryParse ( tempraturInfo, out double temprat))
        {
            Console.WriteLine(temprat);
            tempraturFunkar = true;
        }
        else
        {
            Console.WriteLine("Fel, Ange tempraturen i celcius med siffror.");
        }
                       
    }    }            
    
    
    
    
}    


    