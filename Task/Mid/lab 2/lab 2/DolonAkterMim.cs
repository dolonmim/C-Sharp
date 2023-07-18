using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2
{
    class DolonAkterMim
    {
        public string name;
        public int id;
        private float cgpa;
        protected string semester;
        public string program;
        public string university;

        
        public DolonAkterMim()
        {
            Console.WriteLine("Empty");
        }
        public DolonAkterMim(string name, int id, float cgpa, string semester, string program, string university)
        {
            Console.WriteLine("Param");
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            this.semester = semester;
            this.program = program;
            this.university = university;

        }
            

        public DolonAkterMim(DolonAkterMim t)
        {
            name = t.name;
            id = t.id;
            cgpa = t.cgpa;
            semester = t.semester;
            program = t.program;
            university = t.university;





        }
        
        public void setName(string name)
        {
            this.name = name;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public void setCgpa(float cgpa)
        {
            this.cgpa = cgpa;
        }
        public void setSemester(string semester)
        {
            this.semester = semester;
        }
        public void setProgram(string program)
        {
            this.program= program;
        }
        public void setUniversity(string university)
        {
            this.university = university;
        }
        public float getCgpa()
        {
            return cgpa;  
        }

        public void show()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Id: "+id);
            Console.WriteLine("Cgpa: "+cgpa);
            Console.WriteLine("Semester: "+semester);
            Console.WriteLine("Program: "+program);
            Console.WriteLine("University: "+university);

        }
    }
} 
