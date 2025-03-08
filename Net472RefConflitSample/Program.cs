using RefSystemMemory_454;
using RefSystemMemory_455;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net472RefConflitSample
{
    internal class Program
    {
        //https://stackoverflow.com/questions/62764744/could-not-load-file-or-assembly-system-runtime-compilerservices-unsafe
        //<FindDependenciesOfExternallyResolvedReferences>true</FindDependenciesOfExternallyResolvedReferences>
        static void Main(string[] args)
        {
            new Span<int>(new int[10]);
            var test1 = new SystemMemory_454();
            test1.RunTestWithRef();
            var test2 = new SystemMemory_455();
            test2.RunTestWithRef();
        }
    }
}
