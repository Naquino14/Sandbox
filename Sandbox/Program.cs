using System;
using c = System.Console;
using mybsallsa;
using ARC;
using GenericLinkedList;
using System.Security.Cryptography;
using System.Security;
using System.Text;


namespace Sandbox
{
    public class Program
    {
        public static void Main(string[] vs)
        {
            //using (Aes aes = Aes.Create())
            //{
            //    aes.Key = Encoding.ASCII.GetBytes("funnie key moment");
            //    // nah this is inconvenient to use
            //}

            #pragma warning disable IDE0063
            using (var arc = new ARC128())
            {
                c.Write("IV: ");
                var iv = arc.GenerateIV();
                foreach (var x in iv)
                    c.Write(x.ToString("X"));
                c.WriteLine($" Size: {iv.Length}");

                c.Write(" K: ");
                var key = arc.GenerateKey();
                foreach (var y in key)
                    c.Write(y.ToString("X"));
                c.WriteLine($" Size: {key.Length}");


            }
        }
    }
}