using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class BookNotFoundException : ApplicationException
    {
        public DateTime ExceptionDate { get; set; }
        public BookNotFoundException(string message, DateTime exceptionDate) : base(message)
        {
            ExceptionDate = exceptionDate;
        }
    }
}
