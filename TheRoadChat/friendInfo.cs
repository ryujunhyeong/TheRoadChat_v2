using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRoadChat
{
    public class friendInfo
    {
        public int i_user { get; set; }
        public string name { get; set; }

        public friendInfo(int _i_user, string _name)
        {
            this.i_user = _i_user;
            this.name = _name;
        }

    }
}
