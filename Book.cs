using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPublisherStage1
{
    public class Book
    {
        #region Fields
        private string _name;
        private int _edition;
        private Author _author;
        #endregion
        #region Properties
        public string PName { get => _name; set => _name = value; }
        public int PEdition { get => _edition; set => _edition = value; }
        public Author PAuthor { get => _author; set => _author = value; }
        public Book Next { get; set; }
        #endregion
        #region Constructor/Destructor
        public Book(string Name, Author Author, int Edition) 
        {
            PName = Name;
            PEdition = Edition;
            PAuthor = Author;
        }
        ~Book() { }
        #endregion
        #region Methods
        #endregion
    }
}
