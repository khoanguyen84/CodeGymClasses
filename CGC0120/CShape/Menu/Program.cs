using System;
using System.ComponentModel;

namespace Menu
{
    class Program
    {
        public const char additionOperand = '+';
        public const char subtractOperand = '-';
        public static void Main(string[] args)
        {
            CreateMenu();
        }

        public static void CreateMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("CALCULATOR");
                Console.WriteLine("Please select an option from 1 to 5:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtract (-)");
                Console.WriteLine("3. Multiple (*)");
                Console.WriteLine("4. Divide (/)");
                Console.WriteLine("5. Exit");
                Console.Write("option: ");
                
                if(int.TryParse(Console.ReadLine(), out int number)){
                    option = number;
                }
            }
            while(option > 5 || option < 1);

            Process(option);
        }

        public static void Process(int opt){
            Console.Clear();
            switch(opt){
                case 1:{
                    Calculator(Operator.Addition);
                    break;
                }
                case 2:{
                    Calculator(Operator.Subtract);
                    break;
                }
                case 3:{
                    Calculator(Operator.Multiple);
                    break;
                }
                case 4:{
                    Calculator(Operator.Divide);
                    break;
                }
                case 5:{
                    Environment.Exit(Environment.ExitCode);
                    break;
                }
            }
            CreateMenu();
        }

        // public static void Addition(){
        //     float a = EnterFloat();
        //     float b = EnterFloat();

        //     ShowResult(a, b, '+');
        // }

        // public static void Subtract(){
        //     float a = EnterFloat();
        //     float b = EnterFloat();

        //     ShowResult(a, b, '-');
        // }

        // public static void Multiple(){
        //     float a = EnterFloat();
        //     float b = EnterFloat();

        //     ShowResult(a, b, 'x');
        // }

        // public static void Devide(){
        //     float a = EnterFloat();
        //     float b = EnterFloat();

        //     ShowResult(a, b, '/');
        // }

        public static void Calculator(Operator operation){
            float a = EnterFloat();
            float b = EnterFloat();

            switch(operation){
                case Operator.Addition:
                {
                    ShowResult(a, b, Operator.Addition);
                    break;
                }
                case Operator.Subtract:
                {
                    ShowResult(a, b, Operator.Subtract);
                    break;
                }
                case Operator.Multiple:
                {
                    ShowResult(a, b, Operator.Multiple);
                    break;
                }
                case Operator.Divide:
                {
                    ShowResult(a, b, Operator.Divide);
                    break;
                }
            }
        }
        
        public static float EnterFloat(){
            Console.Write("Please input a number: ");
            float a = 0;
            float.TryParse(Console.ReadLine(), out a);
            return a;
        }

        public static void ShowResult(float a, float b, Operator operation){
            Console.WriteLine("---------- Result ----------");
            switch(operation){
                case Operator.Addition:{
                    Console.WriteLine("{0} + {1} = {2}", a, b, (a+b));
                    break;
                }
                case Operator.Subtract:{
                    Console.WriteLine("{0} - {1} = {2}", a, b, (a-b));
                    break;
                }
                case Operator.Multiple:{
                    Console.WriteLine("{0} x {1} = {2}", a, b, (a*b));
                    break;
                }
                case Operator.Divide:{
                    if(b != 0){
                        Console.WriteLine("{0} : {1} = {2}", a, b, (a/b));
                    }
                    else{
                        Console.WriteLine("Devide by zero!");
                    }
                    break;
                }
            }
            Console.WriteLine("----------------------------");
        }
    }

    public enum Operator{
        [Description("Phép cộng")]
        Addition = '+',
        Subtract = '-',
        Multiple = '*',
        Divide = '/'
    }

    public struct Operand
    {
        public char Addition { get; set; }
        public char Subtract { get; set; }
        public char Muliple { get; set; }
        public char Division { get; set; }

        public string Display(){
            return $"";
        }
    }
}
