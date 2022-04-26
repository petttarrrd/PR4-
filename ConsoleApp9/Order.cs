using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Order
    {
        public DateTime date;
        public int number;
        public Order(DateTime дата, int номер)
        {
            date = дата;
            number = номер;
        }

        public virtual void Confirm()
        {

        }
        public virtual void Close()
        {

        }
    }
}
