using System;
using System.Collections.Generic;
using System.Threading;

namespace MultifabrikenAB
{
    public class Cars : Tofu
    {
        private List<Cars> carListOrders = new List<Cars>();
        private string registerAlphabet;
        private string registerNumbers;
        private string carColor;
        private string carCompany;


        //Setter And Getter functions
        public void setRegisterAlphabet(string registerAlphabet)
        {
            this.registerAlphabet = registerAlphabet;
        }

        public string getRegisterAlphabet()
        {
            return this.registerAlphabet;
        }

        public void setRegisterNumbers(string registerNumbers)
        {
            this.registerNumbers = registerNumbers;
        }

        public string getRegisterNumbers()
        {
            return this.registerNumbers;
        }

        public void setCarColor(string carColor)
        {

            this.carColor = carColor;
        }

        public string getCarColor()
        {
            return this.carColor;

        }

        public string getCarCompany()
        {

            return this.carCompany;
        }

        public void setCarCompany(string carCompany)
        {
            this.carCompany = carCompany;
        }

        // two different constructor
        public Cars()
        {

        }
        public Cars(string registerAlphabet, string registerNumbers, string carColor, string carCompany)
        {
            this.registerAlphabet = registerAlphabet;
            this.registerNumbers = registerNumbers;
            this.carColor = carColor;
            this.carCompany = carCompany;
        }
        // function take 4 parameters and add them to obj list
        public void makeDirectCarsOrder(string registerAlphabet, string registerNumbers, string carColor, string carCompany)
        {
            setRegisterAlphabet(registerAlphabet);
            setRegisterNumbers(registerNumbers);
            setCarColor(carColor);
            setCarCompany(carCompany);
            carListOrders.Add(new Cars(getRegisterAlphabet(), getRegisterNumbers(), getCarColor(), getCarCompany()));
        }

        // make a new order
        public void newCarsOrder()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nu kommer du att beställa Car : ");
            Console.ResetColor();
            Console.Write("Ange register Alphabet (ex : ABC) : ");
            setRegisterAlphabet(Console.ReadLine());
            Console.Write("\n Ange register Nummer (ex 123) : ");
            setRegisterNumbers(Console.ReadLine());
            Console.Write("\n Ange Color : ");
            setCarColor(Console.ReadLine());
            Console.Write("\n Ange Märke (ex : Volvo) : ");
            setCarCompany(Console.ReadLine());
            makeDirectCarsOrder(getRegisterAlphabet(), getRegisterNumbers(), getCarColor(), getCarCompany());

        }

        // print order
        public void printCarsOrder()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("Du har beställt Bil : ");
            Console.ResetColor();
            Thread.Sleep(1000);
            if (carListOrders.Count == 0)
            {
                Console.WriteLine("Inga\n");
            }
            else
            {
                foreach (Cars order in carListOrders)
                {
                    Console.WriteLine($" REGISTERNUMMER: {order.getRegisterAlphabet().ToUpper() + " " + order.getRegisterNumbers().ToUpper()} COLOR: {order.getCarColor()} CONPANY: {order.getCarCompany()} \n");
                }
            }

        }

    }
}
