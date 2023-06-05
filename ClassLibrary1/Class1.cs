using System;

namespace ClassLibrary1
{
    public interface ISportType
    {
        string SportName { get; set; }
        String Start();
        String Stop();
    }

    abstract class TeamSport : ISportType
    {
        public string SportName { get; set; }
        public int NumberOfPlayers { get; protected set; }
        public int NumberOfGoals { get; protected set; }

        public abstract String Start();
        public abstract String Stop();

        public String PrintScore()
        {
            return $"Название спорта: {SportName}" +  $"Количество игроков: {NumberOfPlayers} " + $"Количество голов/очков: {NumberOfGoals} ";
        }
    }

    class Football : TeamSport
    {
        public int NumberOfFouls { get; set; }

        public override String Start()
        {
           return "Игра началась";
        }

        public override String Stop()
        {
            return "Игра завершилась";
        }

        public int UpdateScore(int goals)
        {
            NumberOfGoals += goals;
            return NumberOfGoals;
        }

        public int UpdateFouls(int fouls)
        {
            NumberOfFouls += fouls;
            NumberOfPlayers -= NumberOfPlayers;
            return NumberOfFouls;
        }
        public int UpdateNumberOfPlayers(int numberOfPlayers)
        {
            NumberOfPlayers = numberOfPlayers;
            return NumberOfPlayers;
        }
        public string UpdateSportName(string name)
        {
            SportName = name;
            return name;
        }
    }

    class Hockey : TeamSport
    {
        public int NumberOfPenalties { get; set; }

        public override String Start()
        {
            return "Игра началась";
        }

        public override String Stop()
        {
            return "Игра завершилась";
        }

        public int UpdateScore(int goals)
        {
            NumberOfGoals += goals;
            return NumberOfGoals;
        }

        public int UpdatePenalties(int penalties)
        {
            NumberOfPenalties += penalties;
            NumberOfPlayers -= NumberOfPlayers;
            return NumberOfPenalties;
        }
        public int UpdateNumberOfPlayers(int numberOfPlayers)
        {
            NumberOfPlayers = numberOfPlayers;
            return NumberOfPlayers;
        }
        public string UpdateSportName(string name)
        {
            SportName = name;
            return name;
        }
    }

    class Basketball : TeamSport
    {
        public int NumberOfFouls { get; set; }

        public override String Start()
        {
            return "Игра началась";
        }

        public override String Stop()
        {
            return "Игра завершилась";
        }

        public int UpdateScore(int points)
        {
            NumberOfGoals += points;
            return NumberOfGoals;
        }

        public int UpdateFouls(int fouls)
        {
            NumberOfFouls += fouls;
            NumberOfPlayers -= NumberOfPlayers;
            return NumberOfFouls;
        }
        public int UpdateNumberOfPlayers(int numberOfPlayers)
        {
            NumberOfPlayers = numberOfPlayers;
            return NumberOfPlayers;
        }
        public string UpdateSportName(string name)
        {
            SportName = name;
            return name;
        }
    }
}