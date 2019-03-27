using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学籍管理系统
{
    class Student
    {
        public Student(string id,string name,string course=null,string grade=null,string sex=null,string year=null, string month=null, string day=null, string college=null, string professional= null,string class0=null )
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.year = year;
            this.month = month;
            this.day = day;
            this.grade = grade;
            this.college = college;
            this.class0 = class0;
            this.professional = professional;
            this.course = course;
        }

        public string name;
        public string id;
        public string sex;
        public string year;
        public string month;
        public string day;
        public string grade;
        public string course;
        public string college;
        public string class0;
        public string professional;
    }
}
