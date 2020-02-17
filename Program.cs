using System;
using CommandLine;

namespace Factory
{
    class Program
    {
        public class Options
        {
            [Option('c', "choice", Required = false, HelpText = "Give Feature")]
            public string Slogan { get; set; }
        }
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
              .WithParsed(RunOptions);

            static void RunOptions(Options opts)
            {
                FactoryPresident.CreatePresident(opts.Slogan);
            }
            
            Console.ReadKey();
        }
    }

    class FactoryPresident
    {
        public static President CreatePresident(string feature)
        {
            switch (feature)
            {
                case "Vénal":
                    Console.WriteLine("new president LREM");
                    President president = new LREM();
                    Console.WriteLine(president.Slogan);
                    return president;
                    break;
                case "Indécis":
                    Console.WriteLine("new president Center");
                    President president1= new Center();
                    Console.WriteLine(president1.Slogan);
                    return president1;
                    break;
                case "Fou":
                    Console.WriteLine("new president Communist");
                    President president2 = new Communist();
                    Console.WriteLine(president2.Slogan);
                    return president2;
                    break;
                case "Végétarien":
                    Console.WriteLine("new president Green");
                    President president3 = new Green();
                    Console.WriteLine(president3.Slogan);
                    return president3;
                    break;
                case "Profiteur":
                    Console.WriteLine("new president Socialist");
                    President president4 = new Socialist();
                    Console.WriteLine(president4.Slogan);
                    return president4;
                    break;
               case "Psychopathe":
                    Console.WriteLine("new president RightParti");
                    President president5= new RightParti();
                    Console.WriteLine(president5.Slogan);
                    return president5;
                    break;
                case "Xénophobe":
                    Console.WriteLine("new president Naz");
                    President president6 = new Naz();
                    Console.WriteLine(president6.Slogan);
                    return president6;
                    break;
                default:
                    Console.WriteLine("insert a choice");
                    feature = Console.ReadLine();
                    return CreatePresident(feature);
            }
        }             
    }
    abstract class President
    {
        public abstract string Feature { get; }
        public abstract string Slogan { get; }
    }
    class LREM : President
    {
        public override string Feature => "Vénal";
        public override string Slogan => "Chiao people";
    }
    class Center : President
    {
        public override string Feature => "Indécis";
        public override string Slogan => "Chiao people";
    }
    class Communist : President
    {
        public override string Feature => "Fou";
        public override string Slogan => "Chiao people";
    }
    class Green : President
    {
        public override string Feature => "Végétarien";
        public override string Slogan => "Chiao people";
    }
    class Socialist: President
    {
        public override string Feature => "Profiteur";
        public override string Slogan => "Chiao people";
    }
    class RightParti : President
    {
        public override string Feature => "Psychopathe";
        public override string Slogan => "Chiao people";
    }
    class Naz : President
    {
        public override string Feature => "Xénophobe";
        public override string Slogan => "Chiao people";
    }
}
