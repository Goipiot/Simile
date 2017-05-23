using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simile
{
    class User
    {
        public const int DefaultRating = 5;

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // 0 - 10
        private int _rating;

        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public string Info
        {
            get
            {
                return $"{_name} - {_rating}";
            }
        }


    //    public Lecturer(string name, int rating)
    //    {
    //        _name = name;
    //        _rating = rating;
    //    }

    //    public Lecturer(string name) 
    //        : this(name, DefaultRating) {
    //    }
    //}


}
