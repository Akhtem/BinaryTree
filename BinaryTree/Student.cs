using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Student
    {
        string _name;
        int _assessmant;
        string _testName;
        DateTime _dateOfBirth;


        public Student(string name ,DateTime dateOfBirth, int assessmant, string testName)
        {
            _name = name;
            _dateOfBirth = dateOfBirth;
            _assessmant = assessmant;
            _testName = testName;

        }

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Assessmant
        {
            get { return _assessmant; }
            set { _assessmant = value; }
        }
        public string TestName
        {
            get { return _testName; }
            set { _testName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        #endregion

     

        public override string ToString()
        {
            return String.Format("Student: Name - {0} , TestName - {1} , DateOfBirth - {2} , Assessmant - {3} .",Name,TestName,DateOfBirth,Assessmant);
        }
    }
}
