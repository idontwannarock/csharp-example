using csharp_example.DataType;
using NUnit.Framework;

namespace csharp_example_test.DataType
{
    public class BitWiseOperationTest
    {
        [Test]
        public void Int_And_HexTwo_Should_Not_Equal_To_One()
        {
            var bitWiseOperation = new BitWiseOperation();
            Assert.IsFalse(bitWiseOperation.AndHexTwo(1) == 1);
        }
    }
}