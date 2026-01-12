using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CoffeeMachine
{
    public class CoffeeMachine
    {
        int water;
        int coffee;
        int milk;
        int chocolate;

        // constructor
        public CoffeeMachine(int water, int coffee, int milk, int chocolate)
        {
            this.water = water;
            this.coffee = coffee;
            this.milk = milk;
            this.chocolate = chocolate;
        }

        void Refill()
        {
            Console.WriteLine("วัตถุดิบไม่พอ กำลังเติม...");
            water += 500;
            coffee += 50;
            milk += 30;
            chocolate += 30;
        }

        public void MakeBlackCoffee()
        {
            if (water < 300 || coffee < 20)
                Refill();

            water -= 300;
            coffee -= 20;
            Console.WriteLine("ชงกาแฟดำเสร็จแล้ว ☕");
        }

        public void MakeMocha()
        {
            if (water < 300 || coffee < 20 || chocolate < 10)
                Refill();

            water -= 300;
            coffee -= 20;
            chocolate -= 10;
            Console.WriteLine("ชงมอคค่าเสร็จแล้ว ☕");
        }

        public void MakeLatte()
        {
            if (water < 300 || coffee < 20 || milk < 10)
                Refill();

            water -= 300;
            coffee -= 20;
            milk -= 10;
            Console.WriteLine("ชงลาเต้เสร็จแล้ว ☕");
        }

        public void MakeChocolate()
        {
            if (water < 300 || chocolate < 20)
                Refill();

            water -= 300;
            chocolate -= 20;
            Console.WriteLine("ชงช็อกโกแลตเสร็จแล้ว ☕");
        }

        public void ShowStock()
        {
            Console.WriteLine("\nวัตถุดิบคงเหลือ:");
            Console.WriteLine("น้ำ: " + water + " g");
            Console.WriteLine("กาแฟ: " + coffee + " g");
            Console.WriteLine("นม: " + milk + " g");
            Console.WriteLine("ช็อกโกแลต: " + chocolate + " g");
        }
    }
}