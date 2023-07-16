namespace Bridge_DesignPattern.Bridge.Implementor
{
    public class ConcreteImplementor :Implementor
    {
        public override void Implementation()
        {
            Console.WriteLine("Run ConcreteImplementor.Implementation() ...");
        }
    }
}
