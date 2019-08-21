using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book {
        private List<double> _grades;
        public List<double> Grades 
        { 
            get
            {
                if(_grades == null)
                {
                    this._grades = new List<double>();
                }

                return this._grades;
            }
        }
        public void AddGrade(double grade)
        {
            this.Grades.Add(grade);
        }

        public double Average()
        {
            int numGrades = this.Grades.Count;
            if(numGrades == 0) {
                return 0;
            }
            double sumGrades = 0;
            foreach (var grade in this.Grades)
            {
                sumGrades += grade;
            }
            return sumGrades/numGrades;
        }

        public double MaxGrade()
        {
            double maxGrade = double.MinValue;
            foreach (var grade in this.Grades)
            {
                maxGrade = Math.Max(grade, maxGrade);
            }

            return maxGrade;
        }

        public double MinGrade()
        {
            double minGrade = double.MaxValue;
            foreach (var grade in this.Grades)
            {
                minGrade = Math.Min(grade, minGrade);
            }

            return minGrade;
        }

        public string ToString()
        {
            string result = "";
            foreach (var grade in Grades)
            {
                result += grade + " ";
            }

            return result;
        }
    }
}