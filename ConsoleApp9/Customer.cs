using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    //клиент может получить 
    internal class Customer
    {
        protected string name;
        protected string address;

        internal List<Order> receivedOrders = new List<Order>();//принятые заказы
        internal List<Order> awaiting = new List<Order>();//ожидающие получения заказы
        internal List<Order> sendOrders = new List<Order>();//отправленные заказы
        public Customer(string клиент, string адресс)
        {
            name = клиент;
            address = адресс;
        }
        //Отправка
        public void SendOrder()
        {
            //создание посылки
            Console.Write("Укажите номер заказа отправки(Только цифры): ");
            Order package = new Order(DateTime.Now, Convert.ToInt32(Console.ReadLine()));
            //отчёт о посылки
            Console.WriteLine($"\nПосылка отправлена\nДата: {package.date}\tНомер: {package.number}");
            //запоминание посылки
            sendOrders.Add(package);
        }
        //Получение
        public void ReceivedOrder()
        {
            if (receivedOrders.Count == 0)
            {
                Console.WriteLine("Никто вам ничего не отправил :(");
                return;
            }
            //поиск посылки
            Console.Write("Укажите номер заказа получения(Только цифры): ");         
            foreach(Order package in receivedOrders)
            {
                //посылка есть
                if(package.number == Convert.ToInt32(Console.ReadLine()))
                {
                    Console.WriteLine($"\nПосылка получена\nДата: {package.date}\tНомер: {package.number}");
                    receivedOrders.Add(package);
                    break;
                }
                //посылки нет
                else
                {
                    Console.Write("Посылки с таким номером нет!");
                    break;
                }
            }

        }
        
    }
}
