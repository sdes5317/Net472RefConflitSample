using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net472RefConflitSample
{
    internal class Program
    {
        //https://learn.microsoft.com/zh-tw/nuget/concepts/dependency-resolution
        //"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\FUSLOGVW.exe"
        static void Main(string[] args)
        {
            var test1 = new RefSystemMemory_454.SystemMemory_454();
            test1.RunTestWithRef();
            var test2 = new RefSystemMemory_455.SystemMemory_455();
            test2.RunTestWithRef();
        }
    }
}
