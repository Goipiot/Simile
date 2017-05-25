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
        //List<float> _variants = new List<float>();
        private int _variant;
        public int Variants
        {
            get { return _variant; }
            set { _variant = value; }
        }
        private string _inform;
        public string Inform
        {
            get { return _inform; }
            set { _inform = value; }
        }
        //private User _auth;
        //public User Auth
        //{
        //    get { return _auth; }
        //    set { _auth = value; }
        //}   
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _filename;
        
        //private string _username;

        //public string UserName
        //{
        //    get { return _filename; }
        //    set { _filename = value; }
        //}
        //private string _userpass;
        //public string UserPass
        //{
        //    get { return _userpass; }
        //    set { _userpass = value; }
        //}

        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }
        public string Info2
        {
            get
            {
                return $"ВАРИАНТ: {_variant},     ИНФОРМАЦИЯ:{_inform}";
            }
        }


        public string Info
        {
            get
            {
                return $"{_name} , {_inform}";
            }
        }
        public Topic(string name, string filename,string inform, int variant/*,string username, string userpass*/)
        {
            _name = name;
            _filename = filename;
            _inform = inform;
            _variant = variant;
            //_username = username;
            //_userpass = userpass;
        }
    }
}
