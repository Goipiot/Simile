using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simile
{
    public class User
    {
        private string _name;
        private List<Topic> _topics;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Info
        {
            get
            {
                return $"{_name} - {_password}";
            }
        }
        public User(string name, string password)
        {
            _name = name;
            _password = password;
        }
        public List<Topic> GetTopic
        {
            get { return _topics; }
            set { _topics = value; }
        }
    }
}
 



