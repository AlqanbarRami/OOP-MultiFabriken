using System;
using System.Collections.Generic;
using System.Threading;

namespace MultifabrikenAB
{
    public class Tofu
    {
        private List<Tofu> tofuListOrder = new List<Tofu>();
        private int volume;
        private string seasoning;

        //Setter And Getter functions
        public void setVolume(int volume)
        {
            this.volume = volume;
        }
        public int getVolume()
        {
            return this.volume;
        }

        public void setSeasoning(string seasoning)
        {
            this.seasoning = seasoning;
        }

        public string getSeasoning()
        {
            return this.seasoning;
        }

        // two different constructor
        public Tofu()
        {

        }
        public Tofu(string seasoning, int volume)
        {
            this.seasoning = seasoning;
            this.volume = volume;
        }

        // function take 2 parameters and add them to obj list
        public void makeDirectTofuOrder(string seasoning, int volume)
        {
            setSeasoning(seasoning);
            setVolume(volume);
            tofuListOrder.Add(new Tofu(getSeasoning(), getVolume()));
        }

        // make a new order 
        public void newTofuOrder()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nu kommer du att beställa Tofu");
            Console.ResetColor();
            Console.Write("Ange kryddning : ");
            setSeasoning(Console.ReadLine());
            Console.Write("\n Ange volym :");
            setVolume(int.Parse(Console.ReadLine()));
            makeDirectTofuOrder(getSeasoning(), getVolume());

        }


        // print order 
        public void printTofuOrder()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du har beställt Tofu : ");
            Console.ResetColor();
            Thread.Sleep(1000);
            if (tofuListOrder.Count == 0)
            {
                Console.WriteLine("Inga \n");
            }
            else
            {
                foreach (Tofu order in tofuListOrder)
                {
                    Console.WriteLine($"kryddning: {order.getSeasoning()} volym: {order.getVolume()} \n");
                }
            }

        }

    }
}
