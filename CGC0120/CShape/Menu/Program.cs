using System;

namespace Menu
{
    class Program
    {
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
                    Calculator('+');
                    break;
                }
                case 2:{
                    Calculator('-');
                    break;
                }
                case 3:{
                    Calculator('x');
                    break;
                }
                case 4:{
                    Calculator('/');
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

        public static void Calculator(char operation){
            float a = EnterFloat();
            float b = EnterFloat();

            switch(operation){
                case '+':
                {
                    ShowResult(a, b, '+');
                    break;
                }
                case '-':
                {
                    ShowResult(a, b, '-');
                    break;
                }
                case 'x':
                {
                    ShowResult(a, b, 'x');
                    break;
                }
                case '/':
                {
                    ShowResult(a, b, '/');
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

        public static void ShowResult(float a, float b, char operation){
            Console.WriteLine("---------- Result ----------");
            switch(operation){
                case '+':{
                    Console.WriteLine("{0} + {1} = {2}", a, b, (a+b));
                    break;
                }
                case '-':{
                    Console.WriteLine("{0} - {1} = {2}", a, b, (a-b));
                    break;
                }
                case 'x':{
                    Console.WriteLine("{0} x {1} = {2}", a, b, (a*b));
                    break;
                }
                case '/':{
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
}
