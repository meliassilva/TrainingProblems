/*
 *  C# Program to Display the Student Details using Select Clause LINQ
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Programs
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Marks;
        public ContactInfo GetContactInfo(Programs pg, int id)
        {
            ContactInfo allinfo =
                (from ci in pg.contactList
                 where ci.ID == id
                 select ci)
                .FirstOrDefault();

            return allinfo;
        }

        public override string ToString()
        {
            return First + "" + Last + " :  " + ID;
        }
    }

    public class ContactInfo
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public override string ToString() { return Email + "," + Phone; }
    }

    public class ScoreInfo
    {
        public double Average { get; set; }
        public int ID { get; set; }
    }
    List<Student> students = new List<Student>()
        {
             new Student {First="Tom", Last=".S", ID=1,
                          Marks= new List<int>() {97, 92, 81, 60}},
             new Student {First="Jerry", Last=".M", ID=2,
                          Marks= new List<int>() {75, 84, 91, 39}},
             new Student {First="Bob", Last=".P", ID=3,
                          Marks= new List<int>() {88, 94, 65, 91}},
             new Student {First="Mark", Last=".G", ID=4,
                          Marks= new List<int>() {97, 89, 85, 82}},
        };
    List<ContactInfo> contactList = new List<ContactInfo>()
        {
            new ContactInfo {ID=111, Email="Tom@abc.com", Phone="9328298765"},
            new ContactInfo {ID=112, Email="Jerry123@aaa.com", Phone="9876543201"},
            new ContactInfo {ID=113, Email="Bobstar@aaa.com", Phone="9087467653"},
            new ContactInfo {ID=114, Email="Markantony@qqq.com", Phone="9870098761"}
        };


    static void Main(string[] args)
    {
        Programs pg = new Programs();

        IEnumerable<Student> studentQuery1 =
            from student in pg.students
            where student.ID > 1
            select student;

        Console.WriteLine("Query : Select range_variable");
        Console.WriteLine("Name    : ID");
        foreach (Student s in studentQuery1)
        {
            Console.WriteLine(s.ToString());
        }
        Console.ReadLine();
    }
}