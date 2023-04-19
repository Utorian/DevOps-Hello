using HelloWorld;
using Moq;


namespace DiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Roll_AlwaysReturnNumberThree()
        {
            iDice dice = new StubDice();
            int result = dice.Roll();

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Roll_AlwayReturnNumberFour()
        {
            // Create a mocked iDice object
            var mockDice = new Mock<iDice>();

            // Specify that the Roll method should return 4
            mockDice.Setup(d => d.Roll()).Returns(4);

            // Create a Dice object and call the Roll method
            var dice = new Dice(mockDice.Object);
            int rollResult = dice.Roll();

            // Check that the Roll method returned the expected value
            Assert.AreEqual(4, rollResult);
        }

        [TestMethod]
        public void Roll_Between_1_and_6()
        {
            iDice dice = new Dice(new RandomDice());

            for (int i = 0; i < 100; i++)
            {
                int rollResult = dice.Roll();

                Assert.IsTrue(rollResult > 0 && rollResult <= 6);
            }
        }


        [TestMethod]
        public void Roll_Between1and6()
        {
            RandomDice dice = new RandomDice();

            for (int i = 0; i < 100; i++)
            {
                int rollResult = dice.Roll();

                Assert.IsTrue(rollResult > 0 && rollResult <= 6);
            }
        }
    }
}