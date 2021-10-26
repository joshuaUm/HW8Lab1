/// Homework No. 8 Lab No. 1
/// File Name : Program.cs
/// @author : Joshua Um
/// Date : Oct 25 2021
/// 
/// Problem Statement : Create a class named Pizza that stores information about a single pizza. 
/// 
/// Plan:
/// 1. Test default constructor.
/// 2. Test full constructor
/// 3. Test getters and calculateCost() using toString().
/// 4. Test setters.




using System;

namespace HW8Lab1
{
    enum Size
    {
        Small,
        Medium,
        Large
    }



    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Pizza default constructor test : " + new Pizza());



            Pizza p = new Pizza(Size.Small, 2, 1, 0);

            Console.WriteLine(p);

            p.PizzaSize = Size.Medium;

            Console.WriteLine(p);

            p.NumCheeseToppings = 3;

            Console.WriteLine(p);            
            
            p.NumPepperoniToppings = 5;

            Console.WriteLine(p);


            p.NumHamToppings = 4;

            Console.WriteLine(p);
        }
    }



    class Pizza
    {

        private Size pizzaSize;
        private int numCheeseToppings, numPepperoniToppings, numHamToppings;
        public Size PizzaSize { get { return pizzaSize; } set { pizzaSize = value; } }
        public int NumCheeseToppings { get { return numCheeseToppings; } set { numCheeseToppings = value; } }
        public int NumPepperoniToppings { get { return numPepperoniToppings; } set { numPepperoniToppings = value; } }
        public int NumHamToppings { get { return numHamToppings; } set { numHamToppings = value; } }


        public Pizza()
        {
            pizzaSize = 0;
            numCheeseToppings = 0;
            numPepperoniToppings = 0;
            numHamToppings = 0;
        }


        public Pizza(Size pizzaSize, int numCheeseToppings, int numPepperoniToppings, int numHamToppings)
        {
            this.pizzaSize = pizzaSize;
            this.numCheeseToppings = numCheeseToppings;
            this.numPepperoniToppings = numPepperoniToppings;
            this.numHamToppings = numHamToppings;
        }


        public double calculateCost()
        {
            return (10 + ( 2 * (int) pizzaSize ) ) + (2 * numCheeseToppings) + (2 * numHamToppings) + (2 * numPepperoniToppings);
        }


        public override string ToString()
        {
            return "\nPizza Size : " + (pizzaSize == Size.Small ? "Small" : pizzaSize == Size.Medium ? "Medium" : "Large") + "\n" +
                   "numCheeseToppings : " + numCheeseToppings + "\n" +
                   "numPepperoniToppings : " + numPepperoniToppings + "\n" +
                   "numHamToppings : " + numHamToppings + "\n" +
                   "Pizza Cost : $" + calculateCost();
        }

       



    }
}
