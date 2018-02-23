using System;
namespace AbcDevForce
{
    public class TestClass : IInterfaceTwo
    {

        public bool Draw1(int value = 1)
        {
            return value == 1;
        }

        public void Draw2()
        {
            throw new NotImplementedException();
        }
    }
}
