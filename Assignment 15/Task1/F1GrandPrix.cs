using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class F1GrandPrix
    {
        private string _name;
        private string _location;
        private int _totalLaps;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public int TotalLaps
        {
            get { return _totalLaps; }
            set { _totalLaps = value; }
        }
    }
}
