using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabXm2
{
    internal class Committee
    {
        private Member[] members;
        private int n;
        public Committee()
        {
            members = new Member[100]; 
            n = 0;
        }
        public void AddMember(Member member)
        {
            if (n < members.Length)
            {
                members[n++] = member;
            }
            else
            {
                Console.WriteLine("Member is full.");
            }
        }
    }
}
