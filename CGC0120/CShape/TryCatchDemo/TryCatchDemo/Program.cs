using System;

namespace TryCatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //if(b != 0)
            //{
            //    int c = a / b;
            //    Console.WriteLine(c);
            //}
            //else
            //{
            //    Console.WriteLine("Division by zero");
            //}
            //try
            //{
            //    Console.Write("a = ");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.Write("b = ");
            //    int b = int.Parse(Console.ReadLine());
            //    int c = a / b;
            //    Console.WriteLine(c);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine($"{e.GetType().Name}: {e.Message}, at time: {DateTime.Now.ToLocalTime()}");
            //}
            //catch(OverflowException e)
            //{
            //    Console.WriteLine($"{e.GetType().Name}: {e.Message}, at time: {DateTime.Now.ToLocalTime()}");
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine($"{e.GetType().Name}: {e.Message}, at time: {DateTime.Now.ToLocalTime()}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"{e.GetType().Name}: {e.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("go to finally");
            //}

            //try
            //{
            //    int a = 6;
            //    if (a != 5)
            //        throw new CustomException(a);
            //}
            //catch(CustomException e)
            //{
            //    Console.WriteLine($"{e.GetType().Name}: {e.Message}. at time: {DateTime.Now.ToLocalTime()}");
            //}

            A a = new A();
            a.AM();
        }
    }


    class CustomException : Exception
    {
        public CustomException() : base()
        {
        }

        public CustomException(int value) : base($"{value} is not a prime")
        {

        }
    }

    class A : B
    {
        public void AM()
        {
            BM();
        }
    }

    class B : C 
    { 
        public void BM()
        {
            CM();
        }
    }

    class C
    {
        public Response<int> CM()
        {
            var result = new Response<int>()
            {
                ResponseCode = ResCode.E400,
                Message = $"System error",
                Payload = new int()
            };
            try
            {
                int a = 8;
                int b = 2;
                int c = a / b;

                result.ResponseCode = ResCode.E200;
                result.Payload = c;
                result.Message = "Success";
                Console.WriteLine($"ResCode: {result.ResponseCode}, Payload: {result.Payload}, Message: {result.Message}");
                return result;
            }
            catch(Exception e)
            {
                //throw e;
                Console.WriteLine($"ResCode: {result.ResponseCode}, Payload: {result.Payload}, Message: {result.Message}");
                return result;
            }
            
        }
    }

    public class Response<T>
    {
        public ResCode ResponseCode { get; set; }
        public T Payload;
        public string Message;
    }

    public enum ResCode
    {
        E400 = 400,
        E404 = 404,
        E500 = 500,
        E200 = 200
    }
}
