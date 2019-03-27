using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学籍管理系统
{
    class ReadDatabase
    {

        /// <summary>
        /// 获取查询结果数据表
        /// </summary>
        /// <param name="ChooseString"></param>
        /// 功能选择字符串
        /// <returns></returns>
        public static DataTable GetData(string ChooseString, string info = "", InformationType DataType = InformationType.none)
        {
            info = "\"" + info + "\"";
            //判断数据库文件是否存在
            if (!File.Exists(DataBaseName))
            {
                MessageBox.Show("数据库文件( DATABASENAME )不存在".Replace("DATABASENAME", DataBaseName));
                return null;
            }

            //数据库连接字符串
            string ConnectionString = "Data Source=" + Environment.CurrentDirectory + "\\DATABASE.db;Version=3;UseUTF16Encoding=True;".Replace("DATABASE.db", DataBaseName);

            //数据库读取
            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            try
            {
                con.Open();
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("调用的方法不受支持，或正在试图读取、查找或写入不支持调用功能的流");
                return null;

            }
            catch
            {
                MessageBox.Show("出现非调用(即不是 调用的方法不受支持，或正在试图读取、查找或写入不支持调用功能的流)错误");
                return null;
            }

            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = GetCommand(ChooseString, info, DataType);
            SQLiteDataReader dr = null;
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("数据库执行过程发生异常");
                con.Close();
                return null;
            }
            finally
            {

            }

            DataTable VirtualTable = new DataTable();
            VirtualTable.Columns.Add("行号");
            for (int i = 0; i < dr.FieldCount; i++)
            {
                string Title = dr.GetName(i);
                if (Title==null)
                {
                    return null;
                }
                else if (Title.ToLower() == "cno")
                {
                    Title = "课程编号";
                }
                else if (Title.ToLower() == "cname")
                {
                    Title = "课程名称";
                }
                else if (Title.ToLower() == "ccredit")
                {
                    Title = "课程学分";
                }
                else if (Title.ToLower() == "cchoose")
                {
                    Title = "课程选择";
                }
                else if (Title.ToLower() == "semester")
                {
                    Title = "学年";
                }
                else if (Title.ToLower() == "grade")
                {
                    Title = "成绩";
                }
                else if (Title.ToLower() == "again")
                {
                    Title = "补考情况";
                }
                else if (Title.ToLower() == "sno")
                {
                    Title = "学号";
                }
                else if (Title.ToLower() == "sname")
                {
                    Title = "姓名";

                }
                else if (Title.ToLower() == "ssex")
                {
                    Title = "性别";
                }
                else if (Title.ToLower() == "sdate")
                {
                    Title = "出生日期";

                }
                else if (Title.ToLower() == "college")
                {
                    Title = "学院";
                }
                else if (Title.ToLower() == "professional")
                {
                    Title = "专业";

                }
                else if (Title.ToLower() == "class")
                {
                    Title = "班级";
                }
                else if (Title.ToLower() == "tno")
                {
                    Title = "老师编号";
                }
                else if (Title.ToLower() == "tname")
                {
                    Title = "老师名字";
                }

                else if (Title.ToLower() == "tsex")
                {
                    Title = "老师性别";
                }
                else
                {
                    MessageBox.Show("数据库表头\""+Title+"\"命名未知");
                    Title = "未知" + i.ToString();
                }
                VirtualTable.Columns.Add(Title);//header名字
            }
            VirtualTable.Rows.Clear();
            int a = 1;
            while (dr.Read())
            {
                DataRow row = VirtualTable.NewRow();
                row[0] = a++;
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    if(dr[i] is DateTime)
                    {
                        DateTime time = (DateTime)dr[i];
                        row[i+1] = time.Date.ToString();
                    }
                    row[i+1] = dr[i];                 
                }
                VirtualTable.Rows.Add(row);//添加行内容
            }

            if (ChooseString == "ClassAndGrade" && DataType == InformationType.id)
            {
                SQLiteConnection con1 = new SQLiteConnection(ConnectionString);
                con1.Open();
                SQLiteCommand cmd1 = new SQLiteCommand();
                cmd1.Connection = con1;
                cmd1.CommandText = ClassAndGradeCommandId2.Replace("IDID".ToLower(), info);
                SQLiteDataReader dr1 = cmd1.ExecuteReader();
                dr1.Read();
                DataRow row = VirtualTable.NewRow();
                row[0] = a++;
                //row[1] = "所有课程平均成绩";
                //row[2] = dr1[0];
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    if(i==1)
                    {
                        if(dr1[i].ToString()=="")
                        {
                            row[i + 1] = "暂无任何成绩";
                            continue;
                        }
                    }
                    row[i+1] = dr1[i];
                }
                VirtualTable.Rows.Add(row);//添加行内容
                con1.Close();

                SQLiteConnection con2 = new SQLiteConnection(ConnectionString);
                con2.Open();
                SQLiteCommand cmd2 = new SQLiteCommand();
                cmd2.Connection = con2;
                cmd2.CommandText = ClassAndGradeCommandId3.Replace("IDID".ToLower(), info);
                SQLiteDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                DataRow row1 = VirtualTable.NewRow();
                row1[0] = a++;
                //row1[1] = "必修课程平均成绩";
                //row1[2] = dr2[0];
                for (int i = 0; i < dr2.FieldCount; i++)
                {
                    if (i == 1)
                    {
                        if (dr2[i].ToString() == "")
                        {
                            row1[i + 1] = "暂无任何成绩";
                            continue;
                        }
                    }
                    row1[i+1] = dr2[i];
                }
                con2.Close();
                VirtualTable.Rows.Add(row1);//添加行内容

            }
            else if (ChooseString == "ClassAndGrade" && DataType == InformationType.name)
            {
                SQLiteConnection con3 = new SQLiteConnection(ConnectionString);
                con3.Open();
                SQLiteCommand cmd3 = new SQLiteCommand();
                cmd3.Connection = con3;
                cmd3.CommandText = ClassAndGradeCommandName2.Replace("NAMENAME".ToLower(), info);
                SQLiteDataReader dr3 = cmd3.ExecuteReader();
                dr3.Read();
                DataRow row = VirtualTable.NewRow();
                row[0] = a++;
                //row[1] = "所有课程平均成绩";
                //row[2] = dr3[0];
                for (int i = 0; i < dr3.FieldCount; i++)
                {
                    if (i == 1)
                    {
                        if (dr3[i].ToString() == "")
                        {
                            row[i + 1] = "暂无任何成绩";
                            continue;
                        }
                    }
                    row[i+1] = dr3[i];
                }
                VirtualTable.Rows.Add(row);//添加行内容
                con3.Close();

                SQLiteConnection con4 = new SQLiteConnection(ConnectionString);
                con4.Open();
                SQLiteCommand cmd4 = new SQLiteCommand();
                cmd4.Connection = con4;
                cmd4.CommandText = ClassAndGradeCommandName3.Replace("NAMENAME".ToLower(), info);
                SQLiteDataReader dr4 = cmd4.ExecuteReader();
                dr4.Read();
                DataRow row1 = VirtualTable.NewRow();
                row1[0] = a++;
                //row1[1] = "必修课程平均成绩";
                //row1[2] = dr4[0];
                for (int i = 0; i < dr4.FieldCount; i++)
                {
                    if (i == 1)
                    {
                        if (dr4[i].ToString() == "")
                        {
                            row1[i + 1] = "暂无任何成绩";
                            continue;
                        }
                    }
                    row1[i+1] = dr4[i];
                }
                con4.Close();
                VirtualTable.Rows.Add(row1);//添加行内容
            }
            return VirtualTable;
        }

        /// <summary>
        /// 合成查询SQL语句
        /// </summary>
        /// <param name="ChooseString"></param>
        /// <param name="info"></param>
        /// <param name="DataType"></param>
        /// <returns></returns>
        private static string GetCommand(string ChooseString, string info = "", InformationType DataType = InformationType.none)
        {
            //if (ChooseString == "Test")
            //{
            //    return TestCommand;
            //}
            
            if (ChooseString == "Default")
            {
                if (DataType == InformationType.none)
                {
                    return DefaultCommandNone;
                }
                if (DataType == InformationType.id)
                {
                    return DefaultCommandId.Replace("IDID".ToLower(), info);
                }
                else if (DataType == InformationType.name)
                {
                    return DefaultCommandName.Replace("NAMENAME".ToLower(), info);
                }

            }
            else if (ChooseString == "Information")
            {
                if (DataType == InformationType.id)
                {
                    return InformationCommandId.Replace("IDID".ToLower(), info);
                }
                else if (DataType == InformationType.name)
                {
                    return InformationCommandName.Replace("NAMENAME".ToLower(), info);
                }
                return "";
                //

            }
            else if (ChooseString == "ClassAndGrade")
            {
                if (DataType == InformationType.id)
                {
                    return ClassAndGradeCommandId1.Replace("IDID".ToLower(), info);
                }
                else if (DataType == InformationType.name)
                {
                    return ClassAndGradeCommandName1.Replace("NAMENAME".ToLower(), info);
                }
                return "";

            }
            else if (ChooseString == "Teacher")
            {
                if (DataType == InformationType.id)
                {
                    return TeacherCommandId.Replace("IDID".ToLower(), info);
                }
                else if (DataType == InformationType.name)
                {
                    return TeacherCommandName.Replace("NAMENAME".ToLower(), info);
                }
                return "";
            }
            else if (ChooseString == "FailStudent")
            {
                return FailStudentCommand;
            }
            return null;
        }

        public static bool ChangeDataBase(string ChooseString, Student student)
        {
            SQLiteCommand cmdUpdate = new SQLiteCommand();

            //数据库连接字符串
            string ConnectionString = "Data Source=" + Environment.CurrentDirectory + "\\DATABASE.db;Version=3;UseUTF16Encoding=True;".Replace("DATABASE.db", DataBaseName);
            string CommandTextUpdate = "";

            if (ChooseString == "Grade")
            {
                CommandTextUpdate = UpdateGradeCommand.Replace("'", "\"").Replace("idid", student.id).Replace("gradegrade", student.grade).Replace("cnocno", student.course);

            }
            else if (ChooseString == "Information")
            {
                CommandTextUpdate = UpateInformationCommand.Replace("'", "\"").Replace("sexsex", student.sex).Replace("idid", student.id).Replace("namename", student.name).Replace("yearyear", student.year).Replace("monthmonth", student.month).Replace("dayday", student.day).Replace("classclass", student.class0).Replace("collegecollege", student.college).Replace("professionalprofessional", student.professional);

            }
            else if (ChooseString == "DeleteInformation")
            {
                CommandTextUpdate = DeleteInformationCommand.Replace("'", "\"").Replace("idid", student.id).Replace("namename", student.name);
            }
            else
            {
                MessageBox.Show("参数传递错误", "错误");
                return false;
            }

            SQLiteConnection con = null;
            try
            {
                con = new SQLiteConnection(ConnectionString);
                con.Open();
            }
            catch
            {
                MessageBox.Show("数据库修改时时，连接失败");
                return false;
            }
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = CommandTextUpdate;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("数据库修改时发生错误,错误提示:\n" + cmd.CommandText);
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        /// <summary>
        /// 查询封装
        /// </summary>
        public static string DataBaseName
        {
            get => dataBaseName;

        }
        public static string DefaultCommandNone
        {
            get => defaultCommandNone;

        }
        public static string DefaultCommandId
        {
            get => defaultCommandId;

        }
        public static string DefaultCommandName
        {
            get => defaultCommandName;

        }

        public static string InformationCommandId
        {
            get => informationCommandId;

        }
        public static string InformationCommandName
        {
            get => informationCommandName;

        }

        public static string TeacherCommandId
        {
            get => teacherCommandId;

        } 
        public static string TeacherCommandName
        {
            get => teacherCommandName;

        }

        public static string FailStudentCommand
        {
            get => failStudentCommand;

        }
        public static string ClassAndGradeCommandId1 { get => classAndGradeCommandId1; }
        public static string ClassAndGradeCommandId2 { get => classAndGradeCommandId2; }
        public static string ClassAndGradeCommandId3 { get => classAndGradeCommandId3; }
        public static string ClassAndGradeCommandName1 { get => classAndGradeCommandName1;  }
        public static string ClassAndGradeCommandName2 { get => classAndGradeCommandName2;  }
        public static string ClassAndGradeCommandName3 { get => classAndGradeCommandName3;  }

        /// <summary>
        /// 修改封装
        /// </summary>
        public static string DeleteInformationCommand { get => deleteInformationCommand; }
        public static string UpateInformationCommand { get => upateInformationCommand;}
        public static string UpdateGradeCommand { get => updateGradeCommand; }


       
        

        //private static string TestCommand = @"select * from class213";

        //数据库名
        private static string dataBaseName = @"Information.sqlite";//例如："11.db"

        /// <summary>
        /// 查询相关语句
        /// 学号：IDID，姓名：NAMENAME
        /// </summary>           
        //默认查询语句
        private static string defaultCommandNone = @"select * from student;";

        //学号关键字查询
        private static string defaultCommandId = @"select * from student where sno=idid;";
        private static string informationCommandId = @"select * from student where sno=idid;";

        /// <summary>
        /// 三行语句实现
        /// select distinct course.cname NAME,sc.grade GRADE from course,sc where course.cno=sc.cno and sc.sno=idid;
        /// select avg(grade) from sc where sno=idid;
        /// select avg(grade) from sc where sno=idid and cno in(select cno from course where cchoose='必修');
        /// </summary>
        private static string classAndGradeCommandId1 = @"select distinct course.cname ,sc.grade from course,sc where course.cno=sc.cno and sc.sno=idid;";
        private static string classAndGradeCommandId2 = @"select '所有课程平均成绩',avg(grade) from sc where sno=idid;";
        private static string classAndGradeCommandId3 = @"select '必修课程平均成绩',avg(grade) from sc where sno=idid and cno in(select cno from course where cchoose='必修');";
        private static string teacherCommandId = @"select tname from teacher where tno in(select tno from tc where cno in(select cno from sc where sno=idid) intersect select distinct tc.tno from tc,sc,student where tc.cno=sc.cno and student.sno=sc.sno and sc.sno=idid and tc.class=student.class);";

        //姓名关键字查询
        private static string defaultCommandName = @"select * from student where sname=namename;";
        private static string informationCommandName = @"select * from student where sname=namename;";

        /// <summary>
        /// 三行语句实现
        /// select distinct course.cname NAME,sc.grade GRADE from course,sc,student where course.cno=sc.cno and sc.sno=student.sno and student.sname=namename;
        /// select avg(grade) from sc where sno in(select sno from student where sname=namename);
        /// select avg(grade) from sc where sno in(select sno from student where sname=namename) and cno in(select cno from course where cchoose='必修');
        /// </summary>
        private static string classAndGradeCommandName1 = @"select distinct course.cname ,sc.grade from course,sc,student where course.cno=sc.cno and sc.sno=student.sno and student.sname=namename;";
        private static string classAndGradeCommandName2 = @"select '所有课程平均成绩', avg(grade) from sc where sno in(select sno from student where sname=namename);";
        private static string classAndGradeCommandName3 = @"select '必修课程平均成绩',avg(grade) from sc where sno in(select sno from student where sname=namename) and cno in(select cno from course where cchoose='必修');";
        private static string teacherCommandName = @"select tname from teacher where tno in(select tno from tc where cno in(select cno from sc where sno in (select sno from student where sname=namename)) intersect select distinct tc.tno from tc,sc,student where tc.cno=sc.cno and student.sno=sc.sno and student.sname=namename  and tc.class=student.class);";

        //姓名查询学生被哪些老师教过
        //开除学生名单查询
        private static string failStudentCommand = @"
                                                select sname,sno from student where sno in(
                                                select sc.sno from course,sc where sc.grade>=60 and sc.cno=course.cno and sc.again<=1 and sc.semester=4 and course.cchoose='必修' group by sc.sno having 22-sum(course.ccredit)>=2 union
                                                select sc.sno from course,sc where sc.grade>=60 and sc.cno=course.cno and sc.again<=1 and sc.semester=4 and course.cchoose='选修' group by sc.sno having 9-sum(course.ccredit)>=2 union
                                                select sc.sno from course,sc where sc.grade>=60 and sc.cno=course.cno and sc.again<=1 and sc.semester=4 and course.cchoose='任选' group by sc.sno having 6-sum(course.ccredit)>=2 union
                                                select sc.sno from course,sc where sc.grade>=60 and sc.cno=course.cno and sc.again<=1 and sc.semester=1 and course.cchoose='必修' group by sc.sno having 22-sum(course.ccredit)>=2 union
                                                select sc.sno from course,sc where sc.grade>=60 and sc.cno=course.cno and sc.again<=1 and sc.semester=1 and course.cchoose='选修' group by sc.sno having 9-sum(course.ccredit)>=2 union
                                                select sc.sno from course,sc where sc.grade>=60 and sc.cno=course.cno and sc.again<=1 and sc.semester=1 and course.cchoose='任选' group by sc.sno having 6-sum(course.ccredit)>=2 union
                                                select sc.sno from course,sc where sc.grade>=60 and sc.cno=course.cno and sc.again<=1 and sc.semester=2 and course.cchoose='必修' group by sc.sno having 22-sum(course.ccredit)>=2 union
                                                select sc.sno from course,sc where sc.grade>=60 and sc.cno=course.cno and sc.again<=1 and sc.semester=2 and course.cchoose='选修' group by sc.sno having 9-sum(course.ccredit)>=2 union
                                                select sc.sno from course,sc where sc.grade>=60 and sc.cno=course.cno and sc.again<=1 and sc.semester=2 and course.cchoose='任选' group by sc.sno having 6-sum(course.ccredit)>=2 union
                                                select sc.sno from course,sc where sc.grade>=60 and sc.cno=course.cno and sc.again<=1 and sc.semester=3 and course.cchoose='必修' group by sc.sno having 22-sum(course.ccredit)>=2 union
                                                select sc.sno from course,sc where sc.grade>=60 and sc.cno=course.cno and sc.again<=1 and sc.semester=3 and course.cchoose='选修' group by sc.sno having 9-sum(course.ccredit)>=2 union
                                                select sc.sno from course,sc where sc.grade>=60 and sc.cno=course.cno and sc.again<=1 and sc.semester=3 and course.cchoose='任选' group by sc.sno having 6-sum(course.ccredit)>=2);";


        /// <summary>
        /// 修改指令
        /// </summary>
        //插入成绩
        private static string updateGradeCommand = @"replace into sc(sno,cno,grade) values ('idid','cnocno','gradegrade');";
        //插入信息
        private static string upateInformationCommand = @"replace into student(sno, sname, ssex, sdate, college, professional,class) values('idid','namename','sexsex','yearyear-monthmonth-dayday','collegecollege','professionalprofessional','classclass');";
        //删除信息
        private static string deleteInformationCommand = @"delete from student where sno='idid' and sname='namename' and sno in (select sno from student);delete from sc where sno in (select sno from sc) and sno='idid';"
;

       
    }

}
