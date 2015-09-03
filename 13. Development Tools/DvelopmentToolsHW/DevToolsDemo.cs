using System;
using System.Collections.Generic;
using System.Linq;

namespace DvelopmentToolsHW
{
    public class DevToolsDemo : IDevToolsDemo
    {
        /// <summary>
        /// Fooes this instance.
        /// </summary>
        public void Foo()
        {
            var foo = new List<int>();
            foo.Add(1);
            Console.WriteLine(foo[0]);
        }
    }
}
