using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSchoolTask.Models
{
    public class Student
    {
        private string _name;
        private string _surname;
        private string _group;
        private int _point;
        private bool _isGraduated;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                _group = value;
            }
        }
        public int Point
        {
            get
            {
                return _point;
            }
            set
            {
                _point = value;
            }
        }
        public bool IsGraduated
        {
            get
            {
                return _isGraduated;
            }
        }

        public Student(string name, string surname, string group, int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            _isGraduated = point > 65;
        }

        public void GetInfo() =>
            Console.WriteLine($"{Name} {Surname} adında, {Group} qrupunda oxuyan şagird {Point} bal toplayaraq imtahandan keçmə statusu : {IsGraduated}");

        public void CheckGraduation() =>
            Console.WriteLine(IsGraduated ? "Məzun olub" : "Məzun olmayıb");

        public void GetDiplomDegree() =>
            Console.WriteLine(Point < 65 ? "Diplom yoxdur" : Point < 80 ? "Adi diplom" : Point < 90 ? "Şərəf diplomu" : "Yüksək şərəf diplomu");


    }
}
