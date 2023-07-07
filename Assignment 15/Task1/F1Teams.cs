using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task1
{
    public class F1Teams
    {
        private List<F1Team> _teams;

        public F1Teams()
        {
            _teams = new List<F1Team>();
        }

        public void AddTeam(string name)
        {
            var f1Team = new F1Team
            {
                Name = name
            };

            _teams.Add(f1Team);
            Console.WriteLine("Added successfully" + '\n');
        }

        public void ChooseTeam(string teamName)
        {
            foreach (var team in _teams)
            {
                if (team.Name == teamName)
                {
                    Console.WriteLine("You have successfully selected a team");
                }
                else
                {
                    Console.WriteLine("Not found team");
                }
            }
        }

        public void GetTeams()
        {
            foreach(var team in _teams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
