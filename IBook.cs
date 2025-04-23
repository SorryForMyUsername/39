using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }

        int PublicationYear { get; set; }

        void Output();
    }
}
