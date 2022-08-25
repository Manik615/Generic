

namespace UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            //Arrange
            fibonacci f = new fibonacci();

            //Act
            var result = f.Add(1,2);

            //Assert
            Assert.Equal(3, result);   

        }
    }
}