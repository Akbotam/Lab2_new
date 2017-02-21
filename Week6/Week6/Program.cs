using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Collections;
namespace Week6

 
{             public class Subject
    
          {
            public string name;

            public Subject() { }
            public Subject (string name) {
                this.name=name;
                                         } 
          }
              
       public class Student
        {
            public string name;
            public string Surname;
            public int age;
            public List <Subject> subjects;

            public Student() { }
            public Student(string name, string Surname, int age)
            {
                this.name=name;
                this.Surname= Surname;
                this.age = age;
                subjects= new List <Subject> ();
                subjects.Add(new Subject("Programming technologies"));
                subjects.Add(new Subject("Programming languages"));
            }
        
        }
    class Program{

        static void F2()
        {  

        }
         
         static void F3() {
        
            Student a = new Student("Almas", "Abeuov", 23);
            FileStream fs = new FileStream("../student.xml", FileMode.OpenOrCreate, FileAccess.Read);
            XmlSerializer xs= new XmlSerializer(typeof(Student));
            xs.Serialize(fs, a);
            fs.Close();
        }
        static void F4()
        {
            
            FileStream fs = new FileStream("../student.xml", FileMode.OpenOrCreate, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            Student a = (Student)xs.Deserialize(fs);
            Console.WriteLine(a.name + " " + a.Surname + " " + a.age);
            Console.ReadKey();
            fs.Close();
        }
        static void Main(string[] args)
        {
        }
    } 
    
    }

