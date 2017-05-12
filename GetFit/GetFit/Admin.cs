using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetFit
{
    class Admin
    {
        private bool b;
        public Admin(bool b)
        {
            this.b = b;
        }
        public Admin()
        {
        }
        public bool isAdminLoggedIn()
        {
            bool bo;
            bo = b;
            return bo;
        }
    }
}
