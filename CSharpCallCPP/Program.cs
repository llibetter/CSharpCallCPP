using System;
using System.Runtime.InteropServices;  
namespace CSharpCallCPP
{
    class CPPDLL
    {
        //引入dll，并设置字符集   
        [DllImport("Alg.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] 
        public static extern int add(int a, int b,String s);
    }
    class Program
    {
        static void Main(string[] args)
        {
            int sum = CPPDLL.add(55,444,"HelloWorld");
            Console.WriteLine($"[from CSharp] result:{sum}");
            Console.ReadLine();
        }
    }
}