using System;
using System.Collections.Generic;
using System.Threading;

namespace MultifabrikenAB
{
    public class Snorer : Candies
    {
        private List<Snorer> snorerListOrder = new List<Snorer>();
        private string color;
        private int length;

        //Setter And Getter functions
        public void setLength(int length)
        {
            this.length = length;
        }
        public int getLength()
        {
            return this.length;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return this.color;
        }

        // two different constructor
        public Snorer()
        {

        }
        public Snorer(string color, int length)
        {
            this.color = color;
            this.length = length;
        }

        // function take 2 parameters and add them to obj list
        public void makeDirectSnorerOrder(string color, int length)
        {
            setColor(color);
            setLength(length);
            snorerListOrder.Add(new Snorer(getColor(), getLength()));
        }



        // make a new order 
        public void newSnorerOrder()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nu kommer du att beställa SNÖREN");
            Console.ResetColor();
            Console.Write("Ange Color : ");
            setColor(Console.ReadLine());
            Console.Write("\n Ange Length :");
            setLength(int.Parse(Console.ReadLine()));
            makeDirectSnorerOrder(getColor(), getLength());
        }



        // print order 
        public void printSnorerOrder()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du har beställt Snören : ");
            Console.ResetColor();
            Thread.Sleep(1000);
            if (snorerListOrder.Count == 0)
            {
                Console.WriteLine("Inga\n");
            }
            else
            {
                foreach (Snorer order in snorerListOrder)
                {
                    Console.WriteLine($" Color : {order.getColor()} Length : {order.getLength()} \n");
                }
            }

        }

    }
}