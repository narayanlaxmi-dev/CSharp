using System.Collections.Generic;
using System.Linq;

namespace WebAPIDemo.Model
{
    public static class StudentDB
    {
        private static List<Student> Students = new List<Student>();
        private static int nextId = 1;
        private static readonly object _lock = new object();

        public static IEnumerable<Student> GetAll()
        {
            return Students;
        }

        public static Student? Get(int id)
        {
            return Students.FirstOrDefault(e => e.Id == id);
        }

        public static void Add(Student std)
        {
            lock (_lock)
            {
                std.Id = nextId++;
                Students.Add(std);
            }
        }

        public static bool Update(Student std)
        {
            lock (_lock)
            {
                var existing = Get(std.Id);
                if (existing == null)
                    return false;

                existing.Name = std.Name;
                existing.Grade = std.Grade;
                return true;
            }
        }

        public static bool Delete(int id)
        {
            lock (_lock)
            {
                var std = Get(id);
                if (std == null)
                    return false;

                Students.Remove(std);
                return true;
            }
        }
    }
}
