using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_1
{
    public class InsertBeforeHeaderException:System.ApplicationException
    {
        public InsertBeforeHeaderException(string message) : base(message)
        {

        }
    }
}
