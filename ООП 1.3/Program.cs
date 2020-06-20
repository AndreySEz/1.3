using System;

namespace ООП_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ZooShop zoo1 = new ZooShop();
            Console.WriteLine("Создана ячейка для зоомагазина. Заполните её:\nНазвание животного");
            zoo1.animal = Console.ReadLine();
            Console.WriteLine("Введите пол животного");
            zoo1.sex = Console.ReadLine();
            Console.WriteLine("Имя животного");
            zoo1.name = Console.ReadLine();
            Console.WriteLine("Цена животного");
            zoo1.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество");
            zoo1.number = Convert.ToInt32(Console.ReadLine());
            zoo1.outText();
        }
        class ZooShop
        {
            public void outText()
            {
                Console.WriteLine($"Животное: {animal}\nПол: {sex}\nИмя: {name}\nЦена: ${price}\nКоличество: {number}");
            }

            public string animal;
            public string sex;
            public string name;
            public int price;
            public int number;
        }
    }
}
