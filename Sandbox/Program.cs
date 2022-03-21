using System;
using c = System.Console;
using mybsallsa;
//using GenericLinkedList;
using System.Security.Cryptography;
using System.Security;
using System.Text;
using ADIS;
using NodeBasedML;
using System.Drawing;
using System.Diagnostics;

namespace Sandbox
{
#pragma warning disable CA1416
    public class Program
    {

        public static AKG1.PublicKey key;
        public static bool finished;
        public static void Main(string[] vs)
        {
            #region uhe
            ////// create a new node
            ////var myNode = new Node<String>("beuh!");
            ////myNode.id = "hey";
            ////var myll = new GenericLinkedList.LinkedList<String>(myNode);

            ////// create a new node and append it to the head
            ////var myNode2 = new Node<String>("Ethan Norton");
            ////myll.Append(myNode2);

            ////// try to access the node with the id hey
            ////if (myll.TryGetNodeAt("hey", out var outputNode))
            ////    c.WriteLine(!ReferenceEquals(outputNode, null)
            ////    ? $"My node with the ID \"{outputNode.id}\" comntains the data \"{outputNode.data}\""
            ////    : "Node with id \"hey\" does not exist");

            ////// print out the entirety of mll
            ////c.WriteLine(myll.ToString());

            ////// create a new linked list of type char[] and set the characters world as the head
            ////var charLl = new GenericLinkedList.LinkedList<char[]>(new char[] { 'w', 'o', 'r', 'l', 'd'});
            ////charLl.head.id = "this is the head id";

            ////// create another node with the chars hello and prepend it to the head
            ////var nodeToPrepend = new Node<char[]>(new char[] { 'h', 'e', 'l', 'l', 'o' });
            ////charLl.Prepend(charLl.head, nodeToPrepend);

            ////// print out the previous node first, then print the head
            ////try
            ////{
            ////    foreach (char ch in (!ReferenceEquals(charLl.head.previous, null))
            ////    ? charLl.head.previous.data
            ////    : throw new NullReferenceException("The previous node from the head doesnt exist."))
            ////        c.Write(ch);
            ////} catch (NullReferenceException e)
            ////{ c.WriteLine(e.ToString()); }

            ////c.Write(" ");
            ////foreach (char ch in charLl.head.data)
            ////    c.Write(ch);

            #endregion

            #region yo mama joke generator

            //string yoMamaStart = "Yo mama is so ";
            //var yoMamaP1ll = new GenericLinkedList.LinkedList<string>("stupid, ");
            //yoMamaP1ll.Append(new Node<string>("fat, "));
            //yoMamaP1ll.Append(new Node<string>("short, "));
            //yoMamaP1ll.Append(new Node<string>("hot, "));
            //yoMamaP1ll.Append(new Node<string>("skinny, "));
            //yoMamaP1ll.Append(new Node<string>("old, "));
            //yoMamaP1ll.Append(new Node<string>("ugly, "));
            //yoMamaP1ll.Append(new Node<string>("poor, "));

            //var yoMamaP2ll = new GenericLinkedList.LinkedList<string>("XBOX LIVE!");
            //yoMamaP2ll.Append(new Node<string>("she was a waitress at the Last Supper."));
            //yoMamaP2ll.Append(new Node<string>("she makes Godzilla look like an action figure."));
            //yoMamaP2ll.Append(new Node<string>("she has a sign in her garden saying, ‘Beware of the dog!’"));
            //yoMamaP2ll.Append(new Node<string>("she was floating in the ocean and Spain claimed her for their new world."));
            //yoMamaP2ll.Append(new Node<string>("she thought light sabers had less calories."));
            //yoMamaP2ll.Append(new Node<string>("she puts lipstick on her forehead to make-up her mind."));
            //yoMamaP2ll.Append(new Node<string>("when she fell I didn't laugh, but the sidewalk cracked up."));
            //yoMamaP2ll.Append(new Node<string>("when she skips a meal, the stock market drops."));
            //yoMamaP2ll.Append(new Node<string>("it took me two buses and a train to get to her good side."));
            //yoMamaP2ll.Append(new Node<string>("she stepped on a scale and it said: \"To be continued.\""));
            //yoMamaP2ll.Append(new Node<string>("her car has stretch marks."));
            //yoMamaP2ll.Append(new Node<string>("she threw a boomerang and it refused to come back."));
            //yoMamaP2ll.Append(new Node<string>("her social security number is one."));
            //yoMamaP2ll.Append(new Node<string>("she made a blind kid cry"));
            //yoMamaP2ll.Append(new Node<string>("she chases the garbage truck with a grocery list."));
            //yoMamaP2ll.Append(new Node<string>("you can see her feet on her driver's license."));
            //yoMamaP2ll.Append(new Node<string>("her belt size is \"equator.\""));
            //yoMamaP2ll.Append(new Node<string>("the government moved Halloween to her birthday."));
            //yoMamaP2ll.Append(new Node<string>("she went to the eye doctor to get an iPhone."));

            //c.Write("How many yo mama jokes do you want to hear? ");
            //int count = int.Parse(c.ReadLine() ?? "1");

            //for (int i = 0; i < count; i++)
            //    c.WriteLine($"{yoMamaStart}{GetTheJoke(yoMamaP1ll).data}{GetTheJoke(yoMamaP2ll).data}");

            //c.WriteLine($"\n{yoMamaP1ll}");
            //c.WriteLine($"\n{yoMamaP2ll}");

            #endregion

            #region ai shenanigans

            //// setup network
            //// input neurons
            //List<Neuron> inputs = new();
            //inputs.Add(new(true));
            //inputs.Add(new(true));

            //// create the outputs
            //List<Neuron> outputs = new();
            //outputs.Add(new Neuron(false));

            //// layer 1 neurons
            //List<Neuron> l0 = new();
            //l0.Add(new(inputs, outputs));
            //l0.Add(new(inputs, outputs));

            //outputs[0].incoming = l0;

            //Random random = new();
            //// randomize weights and biases
            //for (int i = 0; i < 2; i++)
            //{
            //    inputs[i].weight = GetRandomNumber(-1f, 1f);
            //    inputs[i].bias = GetRandomNumber(-1f, 1f);
            //    l0[i].weight = GetRandomNumber(-1f, 1f);
            //    l0[i].bias = GetRandomNumber(-1f, 1f);
            //}

            //float[][] tinputs = new float[][] { 
            //    new float[] { 0f, 0f }, 
            //    new float[] { 0f, 1f }, 
            //    new float[] { 1f, 0f }, 
            //    new float[] { 1f, 1f } 
            //};

            //float[] toutputs = new float[] { 0, 1, 1, 0 };

            //// test activation
            //while(true)
            //{
            //    #nullable disable
            //    c.WriteLine("Enter x0, then x1 (true or false)");
            //    int x0 = int.Parse(c.ReadLine());
            //    int x1 = int.Parse(c.ReadLine());

            //    inputs[0].Activate(x0);
            //    inputs[1].Activate(x1);

            //    l0[0].Activate();
            //    l0[1].Activate();

            //    outputs[0].Activate();

            //    c.WriteLine($"According to the network, {x0} ^ {x1} = {(outputs[0].activation > 0.5 ? "1" : "0")} (Actual value is {outputs[0].activation})");
            //}
#nullable enable

            #endregion

            #region image encryption

            //var img = Image.FromFile(@"C:\Users\naqui\Pictures\VS22 Themes\Botl\frame_003_delay-0.02s.gif");

            //var arc = new ARC128();
            //var bimg = imgToByteArray(img);

            //bimg = arc.Encrypt(bimg);

            //var img2 = Image.FromStream(new MemoryStream(bimg));

            //img2.Save(@"D:\");

            #endregion

            #region AKG testing

            //c.WriteLine("Computing keypair...");

            //var thread = new Thread(new ThreadStart(GO));
            //thread.Name = "keygen";
            //thread.Start();
            //var stopw = new Stopwatch();
            //stopw.Start();
            //for (; ; )
            //{
            //    if (finished)
            //        break;
            //    c.Write($"\rElapsed time: {stopw.Elapsed}.");
            //    Thread.Sleep(500);
            //}

            #endregion

            #region sort algorithms

            // mrs strout moment



            #endregion
        }

        #region shenanigans

        //static void GO()
        //{
        //    key = AKG1.GenerateKey();
        //    finished = true;
        //    c.WriteLine($"Modulus: {key._modulus}, Base: {key._base}");
        //}

        ////convert image to bytearray
        //public static byte[] imgToByteArray(Image img)
        //{
        //    using (MemoryStream mStream = new MemoryStream())
        //    {
        //        img.Save(mStream, img.RawFormat);
        //        return mStream.ToArray();
        //    }
        //}
        ////convert bytearray to image
        //public static Image byteArrayToImage(byte[] byteArrayIn)
        //{
        //    using (MemoryStream mStream = new MemoryStream(byteArrayIn))
        //    {
        //        return Image.FromStream(mStream);
        //    }
        //}


        //public static float GetRandomNumber(float minimum, float maximum)
        //{
        //    Random random = new Random();
        //    return random.NextSingle() * (maximum - minimum) + minimum;
        //}

        //static Node<string> GetTheJoke(GenericLinkedList.LinkedList<string> list)
        //{
        //    if (list.TryGetNodeAt(new Random().Next((int)list.size - 1), out var result) && !ReferenceEquals(result, null))
        //        return result;
        //    else
        //        return GetTheJoke(list);
        //}

        #endregion
    }
}