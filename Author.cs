using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace BookPublisherStage1
{
    public class Author
    {
        #region Fields
        private string _firstName;
        private string _phone;
        #endregion
        #region Properties
        public string PFirstName { get => _firstName; set => _firstName = value; }
        public string PPhone { get => _phone; set => _phone = value; }
        #endregion
        #region Constructor/Destructor
        public Author(string FirstName, string Phone)
        {
            PFirstName = FirstName;
            PPhone = Phone;
        }
        ~Author() { }
        #endregion
        #region Methods
        #endregion
    }
}
