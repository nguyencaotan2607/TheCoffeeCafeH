using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheCoffeeCafe
{
    public class FunctionCheckHome
    {
        public static bool kiemTraBan(int soban)
        {
            if (soban != 0)
                return true;
            return false;
        }

        public static bool kiemTraListView(int data)
        {
            if (data != 0)
                return true;
            return false;
        }

        public static bool kiemTraDel(int soban)
        {
            if (soban == 0)
                return false;
            return true;
        }
    }
}
