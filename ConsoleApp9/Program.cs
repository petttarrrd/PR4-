using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer chel = new Customer("Андрухленко", "Пушкина-колотушкина");
            string pos = "Null";
            while (pos != "0")
            {
                Console.Write("0. Выход\n1. Отправить посылку\n2. Получить посылку\n3. Фейковый заказ с номером 10\nВвод: ");
                pos = Console.ReadLine();
                Console.WriteLine();
                switch (pos)
                {
                    case "1":
                        chel.SendOrder();//отправка заказа
                        break;
                    case "2":
                        chel.ReceivedOrder();//получение заказа
                        break;
                    case "3":
                        chel.receivedOrders.Add(new Order(DateTime.Now, 10));//получение заказа из вне
                        break;
                    case "0":
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
