using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Reflections
{
     class MyClass
    {
        public int MyProperty {  get; set; }
        public void MyMethod() { }
    }
    class Programs
    {
        public void getType()
        {
            Type MyType = typeof(MyClass);
            Console.WriteLine("TypeName : {0}",MyType.Name);
            foreach (var m in MyType.GetMethods())
            {
                Console.WriteLine(m.Name); 
            }
            foreach (var m in MyType.GetProperties())
            {
                Console.WriteLine(m.Name);
            }
        }
    }

}
