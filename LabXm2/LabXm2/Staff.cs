using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabXm2
{
    internal class Staff:Member
    {
        public string PlayerStatus { get; set; }
        public Staff(string id, string name, Address address, string status) : base(id, name, address)
        {
            PlayerStatus = status;
        }
        public bool Player_Status(Player player)
        {
            return player.Playing_Status;
        }
        public override string ToString()
        {
            return $"He is a {PlayerStatus}" ;
        }
    }
}
