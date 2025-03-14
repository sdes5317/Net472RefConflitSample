using NUnit.Framework;

namespace Net472NunitTestConflit
{
    public class RunTest_With_Ref454_Ref455
    {
        [Test]
        public void Run()
        {
            var test1 = new RefSystemMemory_454.SystemMemory_454();
            test1.RunTestWithRef();
            var test2 = new RefSystemMemory_455.SystemMemory_455();
            test2.RunTestWithRef();
        }
    }
}
