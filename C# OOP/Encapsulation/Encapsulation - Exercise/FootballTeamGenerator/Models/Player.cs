using FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator.Models
{
    public class Player
    {
        private string name;
        private Statistics stats;

        public Player(string name, Statistics stats)
        {
            Name = name;
            Stats = stats;
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

        public Statistics Stats { get; }

        public double OverallSkill => Stats.AverageStat;
    }
}
