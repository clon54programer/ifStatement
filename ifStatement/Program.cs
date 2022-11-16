using System;

namespace ifStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anyValue = 16;
            string message = "";

            if(anyValue <= 7)
            {
                message = "omg, it's a miracle any value is 7 ";
                Console.WriteLine($"{message}{anyValue}");
            }
            else if(anyValue ==14){
                message = "hey, no esxpmple";
                Console.WriteLine(message);
            }
            else if(anyValue <= 15)
            {
                Console.WriteLine("hey no bangs");
            }
            else
            {
                Console.WriteLine("omg, it's not value 7 is "+ anyValue);
            }
        }
    }
}
