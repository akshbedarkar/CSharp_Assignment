using CustomAttrubuteAndTests;

namespace CustomTests
{
    [TestClass]
    public class accounttest
    {
        [TestMethod]
        public void AccountDetailsNotNull_whenNoInputGivenByUser()
        {
            var account = new ClientApps();
            var result = false;
            if (account == null)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Assert.IsTrue(result);



        }


        


    }
}