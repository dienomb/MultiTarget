// .NET Standard 2.0 implementation
using System.Reflection;
using System.Runtime.Versioning;
namespace Library
{
    public class Hello : IHello
    {
        private readonly int num;
        public Hello(int cons)
        {
            this.num = cons;
        }
        //string ver = Assembly.GetEntryAssembly()?.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkName;
        public string SayHello()
        {
            return $"Hello from netstandard2_0 ()";
        }

        public string SayHello(string mess)
        {
            return mess;
        }
    }
}
