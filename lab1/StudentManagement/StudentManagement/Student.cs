using System;
using System.Collections.Generic;

namespace StudentManagement
{
    public class Student
    {
        public static List<int> StudentIDs = new List<int>();

        public int _StudentID { get; set; }
        public string _FirstName { get; set; }
        public string _LastName { get; set; }
        public int _Age { get; set; }
        public string _Major { get; set; }
        public int _YearOfStudy { get; set; }
        public List<ExamScore> _ExamScores;

        public Student(string FirstName, string LastName, int Age, string Major, int YearOfStudy)
        {
            if (StudentIDs.Count == 0)
            {
                StudentIDs.Add(1);
                _StudentID = 1;
            }
            else
            {
                int lastIndex = StudentIDs[StudentIDs.Count - 1];
                StudentIDs.Add(lastIndex + 1);
                _StudentID = lastIndex + 1;
            }

            _FirstName = FirstName;
            _LastName = LastName;
            _Age = Age;
            _Major = Major;
            _YearOfStudy = YearOfStudy;
        }

        public Student(string FirstName, string LastName, int Age, string Major, int YearOfStudy, List<ExamScore> ExamScores)
        {
            if (StudentIDs.Count == 0)
            {
                StudentIDs.Add(1);
                _StudentID = 1;
            }
            else
            {
                int lastIndex = StudentIDs[StudentIDs.Count - 1];
                StudentIDs.Add(lastIndex + 1);
                _StudentID = lastIndex + 1;
            }

            _FirstName = FirstName;
            _LastName = LastName;
            _Age = Age;
            _Major = Major;
            _YearOfStudy = YearOfStudy;
            _ExamScores = ExamScores;
        }

        public override string ToString()
        {
            return _StudentID.ToString();
        }
    }
}
