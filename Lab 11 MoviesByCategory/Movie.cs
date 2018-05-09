using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_MoviesByCategory
{
    class Movie
    {
        #region data members
        private string title;
        private string category;
        #endregion

        #region properties
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        #endregion

        #region constructors
        public Movie(string c, string t)
        {
            this.category = c;
            this.title = t;
        }
        public Movie()
        {
        }
        
        #endregion

        public void PrintInfo()
        {
            Console.WriteLine($" the movie category: {Category}");
            Console.WriteLine($"the movie title:{Title}");
            
        }
        

    }
}
