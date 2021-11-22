using System;
using System.Collections.Generic;
using System.Threading;


namespace MultifabrikenAB{
public class Orders : Snorer  {
private int numberForMenu;
private bool continueToMenu;



protected void setContinueToMenu(bool continueToMenu){
    this.continueToMenu = continueToMenu;
    }

protected bool getContinueToMenu(){
    return this.continueToMenu;
}

// to print all orders 
public void printAllOrders(){
    printCarsOrder();
    printCandiesOrder();
    printSnorerOrder();
    printTofuOrder();
}

//Function to start the menu and make a new order 
public void startMenuOrders(){
    setContinueToMenu(true);
    while(getContinueToMenu()){
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Thread.Sleep(1000);
    Console.WriteLine("\n Välkommen till vår fabrik. Du kan beställa vad du vill från våra produkter.Våra produkter är bilar, godis, snören och tofu Välj en från menyn t.ex. 2 eller 4 \n");
    Console.WriteLine("1. Beställ Bil");
    Console.WriteLine("2. Beställ Godis");
    Console.WriteLine("3. Beställ Snören");
    Console.WriteLine("4. Beställ Tofu");
    Console.WriteLine("5. Din beställning lista");
    Console.WriteLine("6. Avsluta");
    Console.ResetColor();
    numberForMenu = int.Parse(Console.ReadLine());
    switch(numberForMenu){
        case 1 :
           newCarsOrder();
        break;
        case 2 : 
           newCandiesOrder();
        break;
        case 3 : 
           newSnorerOrder();
        break;
        case 4 : 
            newTofuOrder();
        break;
        case 5 :
            printAllOrders();
        break ;
        case 6 :
           setContinueToMenu(false);
        break;
        default : 
            Console.WriteLine("Only numbers!");
        break;

    }
    }

}

}
}