using System;

namespace Thomas_Stephen_DvpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //CAtch number va[lue

            //call Menu one function
            MenuOne codeChallenge = new MenuOne("[1] Swap Name","\r\n[2] Backwords","\r\n[3] Age Convert","\r\n[4] Temp Convert","\r\n[5] Big Blue Fish","[0] Exit");


            Console.WriteLine("Coding Challenge Menu:\r\nPlease enter the number for the challenge you...");
           
            //Console getters and setters
            Console.WriteLine(codeChallenge.getSwapName()+codeChallenge.getBackwards()+codeChallenge.getAgeConvet()+codeChallenge.getTempConvert()+codeChallenge.getBigBlueFish());

            Console.WriteLine("\r\n"+codeChallenge.getExit());


            Console.WriteLine("\r\n =======================");
            Console.Write("Make your selection: ");
            string userEnter = Console.ReadLine();

            int numSwap;
          
            int.TryParse(userEnter, out numSwap);


            






           

            
            



            
            
            
             



        }
    }
}
