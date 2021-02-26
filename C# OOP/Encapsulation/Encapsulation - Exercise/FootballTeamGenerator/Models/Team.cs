
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FootballTeamGenerator.Common;

namespace FootballTeamGenerator.Models
{
    public class Team
    {

        private string name;
        private List<Player> players;

        private Team()
        {
            players = new List<Player>();
        }

        public Team(string name): this()
        {
            Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.EmptyNameExceptionMessage);
                }

                name = value;
            }
        }

        public int Rating 
        { 
            get
            {
                if (players.Count == 0)
                {
                    return 0;
                }
                return (int)Math.Round(players.Sum(p => p.OverallSkill / players.Count));
            }
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string name)
        {

            Player playerToRemove = players.FirstOrDefault(p => p.Name == name);

            if (playerToRemove == null)
            {
                
                string excMessage = String.Format(GlobalConstants.RemovingMissingPlayerExceptionMessage, name, Name);
                throw new InvalidOperationException(excMessage);
            }
            players.Remove(playerToRemove);
        }

        public override string ToString()
        {
            
            return $"{Name} - {Rating}";
        }
    }
}
