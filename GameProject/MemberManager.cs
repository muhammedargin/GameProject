using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class MemberManager 
    {
        List<Member> members;

        public MemberManager()
        {
            members = new List<Member> { };
        }

        public void Add(Member member)
        {
            members.Add(member);
            Console.WriteLine("{0} Adlı ve {1} kullanıcı adına sahip üye eklendi.",member.Name,member.Id);


        }

        public void Delete(Member member)
        {
            members.Remove(member);
            Console.WriteLine("{0} Adlı ve {1} kullanıcı adına sahip üye silindi.", member.Name, member.Id);


        }
        public void List()
        {
            int i = 1;
            foreach (var member in members)
            {
               
                Console.WriteLine("Üye Listesi");
                Console.WriteLine("{0}. Üye : {1}", i, member.Name);
                i++;
            }



        }
    }
}
