using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyekResponsi
{
    class Departemen
    {
        private string _id;
        private string _name;

        public string Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public Departemen() { }
        public Departemen(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
