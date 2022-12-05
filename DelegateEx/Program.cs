using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//example of extension method and delegation
namespace DelegateEx
{
    //delegate int MyDel(int x, int y);

    internal class Program
    {
        //static int Add (int x,int y)
        //{
        //    return x + y;
        //}
        //static int Mul(int x,int y)
        //{
        //    return x * y;
        //}
        static void Main()
        {
            string fin = "rithish";
            string Res = fin.concatstr();
            
            Console.WriteLine(Res); 
            //MyDel del = new MyDel(Add);
            
            //int res = del(1, 2);
            //int res2= del.Invoke(12, 12);

            //Console.WriteLine(res);
           

            //Console.WriteLine(res2);
            Console.ReadKey();


        }
    }
}
