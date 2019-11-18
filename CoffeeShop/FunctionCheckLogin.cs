using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheCoffeeCafe
{
    public class FunctionCheckLogin
    {
            public static int kiemTra(string uid, string pw)
            {
                if (uid == "admin" && pw == "1")
                    return 0;
                else
                    return 1;
            }

    }
}
