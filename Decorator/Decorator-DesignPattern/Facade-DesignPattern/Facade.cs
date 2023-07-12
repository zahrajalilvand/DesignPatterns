using Facade_DesignPattern.ClassSample1;
using Facade_DesignPattern.ClassSample2;
using Facade_DesignPattern.ClassSample3;

namespace Facade_DesignPattern
{
    public class Facade
    {
        public void DoSomething()
        {
            Class1 firstClass = new Class1();
            Class2 secondClass = new Class2();
            Class3 thirdClass = new Class3();

            firstClass.Method01();
            secondClass.Method02();
            thirdClass.Method03();
        }
    }
}
