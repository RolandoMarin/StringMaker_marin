using System;
using System.Collections.Generic;
// Rolando Marin
// IT113
// BEHAVIORS NOT IMPLIMENTED AND WHY: Very diffiult for me to implement to string. I tried multiple things and saddly gioven up :(
namespace StringMaker_marin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringManager fancy = new StringManager();

            Console.WriteLine("reverse: " + fancy.Reverse("Sunbeam Tiger" ));

            //Console.WriteLine("\nTostring: " + fancy.Tostring("one two five four"));

            Console.WriteLine("\nreverse with case: " + fancy.Reverse("Sunbeam Tiger", true));

            Console.WriteLine("equals: " + fancy.Equals("Sunbeam Tiger"));

            Console.WriteLine("\nis ABBA symetric?" + fancy.Symetric("ABBA"));

            Console.WriteLine("\nis ABA symetric?" + fancy.Symetric("ABA"));

            Console.WriteLine("\nis ABba symetric?" + fancy.Symetric("ABba"));














            //Queue<StringManager> myqueue = new Queue<StringManager>();

            //StringManager fancy = new StringManager("Dan");



            //string hi = "Sunbeam Tiger";

            //myqueue.Enqueue(new StringManager(hi));

            //StringManager next = myqueue.Dequeue();

            //Console.WriteLine(next.Reverse(hi));

            //Console.WriteLine("Tostring: " + fancy.Equals("Dan"));







            //Console.WriteLine("Enter a string to reverse: ");
            //string rev =  Console.ReadLine();

            //StringManager sm = new StringManager(rev);


            //sm.Reverse(rev);

            //Console.WriteLine(sm.Reverse(rev));


            //Console.WriteLine("Enter a string to reverse & cases: ");

            //string caseRev = Console.ReadLine();







        }
    }
}
