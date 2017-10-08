using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_System.DB_linker
{
    class StudentTableAdapter
    {
        public void insert_data(String f_name, String l_name,DateTime DOB,String blood_group)
        {
            StudentDataContext contex = new StudentDataContext();
            Student sp = new Student();
            sp.FirstName = f_name;
            sp.LastName = l_name;
            sp.DateOfBirth = DOB;
            sp.BloodGroup = blood_group;
            contex.Students.InsertOnSubmit(sp);
            contex.SubmitChanges();
        }
    }
}
