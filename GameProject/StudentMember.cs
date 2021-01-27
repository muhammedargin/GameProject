using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class StudentMember :Member
    {
        public StudentMember()
        {
            Console.WriteLine("Öğrencilere özel indirimlerden faydalanabileceksiniz.Hoşgeldiniz!");
        }
        public string SchoolName { get; set; }
        public string FacultyOrBranch { get; set; }

    }
}
