using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class SpecialOrder : Order
    {
        public string privateClient;
        public SpecialOrder(DateTime дата, int номер)
: base(дата, номер)
        {
        }
        public override void Close()
        {
            base.Close();
        }
        public override void Confirm()
        {
            base.Confirm();
        }
        public void Dispatch()
        {

        }
    }
}
