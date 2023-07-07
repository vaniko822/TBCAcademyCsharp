using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    public class F1GrandPrixList
    {
        private List<F1GrandPrix> _f1GrandPrixes;

        public F1GrandPrixList()
        {
            _f1GrandPrixes = new List<F1GrandPrix>();
        }

        public void AddF1GrandPrix(string name, string location, int totalLaps)
        {
            var f1GrandPrix = new F1GrandPrix
            {
                Name = name,
                Location = location,
                TotalLaps = totalLaps,
            };

            _f1GrandPrixes.Add(f1GrandPrix);
            Console.WriteLine("Added successfully" + '\n');
        }

        public void GetGrandPrixList()
        {
            foreach (var f1GrandPrix in _f1GrandPrixes)
            {
                Console.WriteLine($"Grand prix name - {f1GrandPrix.Name}" + '\n' +
                        $"Grand prix location - {f1GrandPrix.Location}" + '\n' +
                        $"Grand prix total laps - {f1GrandPrix.TotalLaps} Lap" + '\n');
            }
        }
    }
}
