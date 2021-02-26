using FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator.Models
{
    public class Statistics
    {

        private const int STAT_MIN_VALUE = 0;
        private const int STAT_MAX_VALUE = 100;

        private const double STATS_COUNT = 5.0;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

     

        public Statistics(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public int Endurance 
        { 
            get
            {
                return endurance;
            }
            private set
            {
                ValidateStat(value, nameof(Endurance));

                endurance = value;
            }
        }

        public int Sprint
        {
            get
            {
                return sprint;
            }
            private set
            {
                ValidateStat(value, nameof(Sprint));

                sprint = value;
            }
        }

        public int Dribble
        {
            get
            {
                return dribble;
            }
            private set
            {
                ValidateStat(value, nameof(Dribble));

                dribble = value;
            }
        }

        public int Passing
        {
            get
            {
                return passing;
            }
            private set
            {
                ValidateStat(value, nameof(Passing));

                passing = value;
            }
        }

        public int Shooting
        {
            get
            {
                return shooting;
            }
            private set
            {
                ValidateStat(value, nameof(Shooting));

                shooting = value;
            }
        }

        public double AverageStat => (Endurance + Sprint + Shooting + Dribble + Passing) / STATS_COUNT;
        private void ValidateStat(int value, string statName)
        {
            if (value < STAT_MIN_VALUE || value > STAT_MAX_VALUE)
            {
                string excMsg = String.Format(GlobalConstants.InvalidStatExceptionMessage, statName, STAT_MIN_VALUE, STAT_MAX_VALUE);
                throw new ArgumentException(excMsg);
            }
        }
    }
}
