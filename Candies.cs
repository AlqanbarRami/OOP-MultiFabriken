using System;
using System.Collections.Generic;
using System.Threading;

namespace MultifabrikenAB
{
    public class Candies : Cars
    {
        private List<Candies> candiesListOrder = new List<Candies>();
        private string flavour;
        private int antal;

        //Setter And Getter functions
        public void setFlavour(string flavour)
        {
            this.flavour = flavour;
        }
        public string getFlavour()
        {
            return this.flavour;
        }

        public void setAntal(int antal)
        {
            this.antal = antal;
        }

        public int getAntal()
        {
            return this.antal;
        }

        // two different constructor
        public Candies()
        {

        }
        public Candies(string flavour, int antal)
        {
            this.flavour = flavour;
            this.antal = antal;
        }

        // function take 2 parameters and add them to obj list
        public void makeDirectCandiesOrder(string flavour, int antal)
        {
            setFlavour(flavour);
            setAntal(antal);
            candiesListOrder.Add(new Candies(getFlavour(), getAntal()));
        }

        // make a new order 
        public void newCandiesOrder()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nu kommer du att beställa Godis");
            Console.ResetColor();
            Console.Write("Ange Smak : ");
            setFlavour(Console.ReadLine());
            Console.Write("\n Ange Antal :");
            setAntal(int.Parse(Console.ReadLine()));
            makeDirectCandiesOrder(getFlavour(), getAntal());
        }


        // print order 
        public void printCandiesOrder()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du har beställt Godis : ");
            Console.ResetColor();
            Thread.Sleep(1000);
            if (candiesListOrder.Count == 0)
            {
                Console.WriteLine("Inga\n");
            }
            else
            {
                foreach (Candies order in candiesListOrder)
                {
                    Console.WriteLine($" Flavour: {order.getFlavour()} Antal: {order.getAntal()} \n");
                }

            }
        }

    }
}