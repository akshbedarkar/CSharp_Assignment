using CustomAttrubuteAndTests;
using System;

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

        [TestMethod]
        public void Accountcheck_ifstring_ReturnTrue()
        {
            var account = new hdfcaccount();
            account.projectname = "project name";

            Assert.AreEqual("project name", account.projectname);



        }







    }
}