/// Week 9 Lab 1
/// File Name: week9lab1.cs
/// Author: Lucas Smith
/// Date:  October 25, 2021
///
/// Problem Statement: Create a class named Pizza that stores information about a single pizza.
/// 
/// 
/// Overall Plan:
/// 1) Declare public class Pizza
/// 2) Declare the methods inside, along with the private scope variable count that will be used inside.
/// 3) Test each method in the Main class

using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the pizza (small, medium or large): ");
            string size = Console.ReadLine();

            Console.WriteLine("Enter the number of cheese toppings: ");
            int cheeseTop = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of pepperoni toppings: ");
            int pepTop = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of ham toppings: ");
            int hamTop = Convert.ToInt32(Console.ReadLine());

            Pizza myPizza = new Pizza();

            myPizza.setSize(size);
            myPizza.setCheeseToppers(cheeseTop);
            myPizza.setHamToppers(hamTop);
            myPizza.setPepToppers(pepTop);

            double cost = myPizza.CalculateCost();

            Console.WriteLine(myPizza.ToString());
            Console.WriteLine("Testing CalculateCost Method: $" + cost);
        }
    }
}


class Pizza
{
    private string size;
    private int cheeseToppings;
    private int pepperoniToppings;
    private int hamToppings;
    private double cost;

    public void setSize(string s)
    {
        size = s;
    }

    public void setCheeseToppers(int c)
    {
        cheeseToppings = c;
    }

    public void setPepToppers(int p)
    {
        pepperoniToppings = p;
    }

    public void setHamToppers(int h)
    {
        hamToppings = h;
    }

    public double CalculateCost()
    {
        string pizzaSize = size.ToLower();

        if(pizzaSize == "small")
        {
            cost += 10;
        } else if (pizzaSize == "medium")
        {
            cost += 12;
        } else if (pizzaSize == "large")
        {
            cost += 14;
        }

        int totalToppings = (cheeseToppings * 2) + (hamToppings * 2) + (pepperoniToppings * 2);

        cost = cost + totalToppings;

        return cost;
    }

    public override string ToString()
    {
        return "Cost for your pizza: $" + cost;
    }
}