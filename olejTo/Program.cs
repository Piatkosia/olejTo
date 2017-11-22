using System;
using System.Reflection;

namespace olejTo
{
    class Program
    {
        static void Main(string[] args)
        {
            var Asm = Assembly.Load("FindMeIfYouCan");
            var types = Asm.GetTypes();
            var SingleType = types[0];
            var FunnyObject = Convert.ChangeType(Activator.CreateInstance(SingleType), SingleType);
            Console.WriteLine(FunnyObject);
            var MethodInfoF = SingleType.GetMethod("GetHiddenString", BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(MethodInfoF.Invoke(FunnyObject, null));
            //to teraz zejdziemy sobie odpowiednio głębiej
            Type nested = SingleType.GetNestedType("HyperSecureClass", BindingFlags.NonPublic | BindingFlags.Instance);
            var StrangeObject = Convert.ChangeType(Activator.CreateInstance(nested), nested);
            var MethodInfoS = nested.GetMethod("GetMoreHiddenString", BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(StrangeObject);
            Console.WriteLine(MethodInfoS.Invoke(StrangeObject, null));
            Console.ReadKey();
        }
    }
}
