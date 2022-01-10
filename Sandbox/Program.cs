using System;
using c = System.Console;

using GenericLinkedList;

namespace Sandbox
{
    public class Program
    {
        public static void Main(string[] vs)
        {
            var baseNode = new Node<string>("pee pee", "brr");
            var mll = new GenericLinkedList.LinkedList<string>(baseNode);

            var newNodeLole = new Node<string>("poo poo");
            mll.Append(newNodeLole);

            var cock = new Node<string>("cock and balls");
            mll.Append(cock);

            var lole = new Node<string>("wee wee", "wee wee id");
            mll.Append(lole);

            if (mll.TryGetNodeAt(3, out var o)) {

                if (o == null) o = new Node<string>("nul");

                c.WriteLine(o.data);
            } else
                throw new NullReferenceException();

            if (mll.TryGetNodeAt("brr", out var oh))
            {
                oh ??= new Node<string>("nul");
                c.WriteLine(oh.data);
            }
            else
                throw new NullReferenceException();
        }
    }
}