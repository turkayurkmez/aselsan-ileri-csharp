using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInInterfaces
{
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public int CompareTo(Student? other)
        {
            if (Score > other.Score)
            {
                return 1;
            }
            else if (Score < other.Score)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class  Students : IEnumerable<Student>
    {
        private List<Student> students = new();

        public void Add(Student student)
        {
            students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var st in students)
            {
                yield return st;
            }
        }

        public void SortStudents()
        {
            students.Sort();
            //return students;

            //mademki IEnumerable<Student> implemente ediyor, o zaman return etmeye gerek yok.
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
