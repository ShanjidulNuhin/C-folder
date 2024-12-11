using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LabXm2
{
    internal class Player:Member
    {
        public double Salary { get; set; }
        public string Playing_Position { get; set; }
        public double Current_Rank {  get; set; }
        public bool Playing_Status {  get; set; }

        public Player(string id, string name, Address address, double salary, string playingPosition, int currentRank)
        : base(id, name, address)
        {
            Salary = salary;
            Playing_Position = playingPosition;
            Current_Rank = currentRank;
            Playing_Status = currentRank >=75;
        }
        public override string ToString()
        {
            return base.ToString()+$"\nPlayer Salary : { Salary} "+
                $"\nPlayer positon : {Playing_Position}\nCurrent Rank : {Current_Rank}\nPlaying Status : {Playing_Status}";
        }
    }
}
