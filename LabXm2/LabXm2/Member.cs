using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabXm2
{
    internal class Member
    {
        public string ID {  get; set; }
        public string Name { get; set; }
       public Address Address {  get; set; }

        protected Member(string id, string name, Address address)
        {
            ID = id;
            Name = name;
            Address = address;
        }
        public static void GetDetails(Member member)
        {
            Console.WriteLine(member.ToString());
        }
        public override string ToString()
        {
            return $"Player ID: {ID} \nPlayer name: {Name} \nPlayer address : {Address}"; 
        }

    }
}
