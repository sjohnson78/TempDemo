using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region additional namespaces
using Backend.Demo.Entities;
using System.ComponentModel;
using Backend.Demo.DAL;

#endregion

namespace Backend.Demo.BLL
{
    // remember to make this public
    [DataObject]
    public class StudentController
    {
        [DataObjectMethod(DataObjectMethodType.Select]
        public List<Student> ListAllStudents()
        {
            using (var context = new MyDatabaseContext())
            {
                return context.Students.ToList();
            }
        }
    }
}