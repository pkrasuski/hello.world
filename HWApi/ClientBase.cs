using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWApi
{
    public class ClientBase
    {
        public string ClientName { get; set; }
        public virtual void Write(string sText)
        {        
        }
    }
    public class Cons : ClientBase
    {
        public override void Write(string sText)
        { 
            Console.WriteLine(sText);      
            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    };

    // add new client classes implementations here
    // eg. web applications, windows services
    // Write method could write to a DB etc.
   

}
