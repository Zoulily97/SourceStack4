using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Repository1<T> where T : Entity<int>
    {
        public void Save(T entity)
        {

        }
        public void Delete(int id)
        {

        }
    }
    public class StudentRepository1
    {
        //public Student GetByName(string name)
        //{

        //}
    }
        

}
