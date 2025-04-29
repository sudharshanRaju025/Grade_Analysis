using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_project
{
    public class Student
    {
        private int id;
        private readonly string Name="";
        private double score;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string NAME
        {
            get { return Name; }
            set { NAME = value; }
        }

        public double Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
