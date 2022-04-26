using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class NormalOrder : Order  
    {
        public NormalOrder(DateTime дата, int номер)
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
        public void Receive()
        {

        }
    }
}
