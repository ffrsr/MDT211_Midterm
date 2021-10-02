using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string decide = "y";
            FlowerStore flowerStore = new FlowerStore();
            do
            {
                PrintSelectNumberForBuy();

                FlowerList();

                CaseFlower();

                PrintStopProgess();
           
                decide = Console.ReadLine();
                if (decide == "exit")
                {
                    CurrentCart();
                    flowerStore.showCart();
                }
            }

            while(decide != "exit");           
        }

        static void PrintSelectNumberForBuy()
        {
            Console.WriteLine("Select number for buy flower :");
        }

        static void PrintNotAddToCart()
        {
            Console.WriteLine("Not Added to cart. found select number of flower");
        }

        static void PrintStopProgess()
        {
            Console.WriteLine("You can stop this progress ? exit for >> exit << progress and press any key for continue");
        }

        static void CurrentCart()
        {
            Console.Write("Current my cart");
        }

        static void FlowerList()
        {
            FlowerStore flowerStore = new FlowerStore();

            foreach (string i in flowerStore.flowerList)
            {
                Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + " ");
                Console.WriteLine(i);
            }
        }
       
        static void CaseFlower()
        {            
            string selectFlower;
            FlowerStore flowerStore = new FlowerStore();

            selectFlower = Console.ReadLine();
            switch (selectFlower)
            {

                case "1":
                    flowerStore.addToCart(flowerStore.flowerList[0]);
                    Console.WriteLine("Added " + flowerStore.flowerList[0]);
                    break;

                case "2":
                    flowerStore.addToCart(flowerStore.flowerList[1]);
                    Console.WriteLine("Added " + flowerStore.flowerList[1]);
                    break;

                default:
                    PrintNotAddToCart();
                    break;
            }
        }
    }


    class FlowerStore 
    {
        public List<string> flowerList = new List<string>();
        List<string> cart = new List<string>();
        public FlowerStore()
        {
            flowerList.Add("Rose");            
            flowerList.Add("Lotus");
        }
        public void addToCart(string name)
        {
            cart.Add(name);
        }

        public void showCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                Console.WriteLine("My Cart :");
                foreach (string i in cart)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}
