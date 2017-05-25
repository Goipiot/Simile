using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Simile
{
    public class Topic
    {     
        private string _name;
        List<float> _variants = new List<float>();
        private User _auth;
        public User Auth
        {
            get { return _auth; }
            set { _auth = value; }
        }   
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _filename;
        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }
        public string Info()
        {
           return _name;
        }
        public List<float> Vars()
        {
            return _variants;
        }
        public Topic(string name, string filename,User auth)
        {
            _name = name;
            _filename = filename;
            _auth=auth
        }
            

    }
}
