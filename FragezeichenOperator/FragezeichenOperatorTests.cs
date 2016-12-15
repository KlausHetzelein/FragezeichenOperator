using System.Security.Principal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FragezeichenOperator
{
    [TestClass]
    public class QuestionmarkOperatorTests
    {
        [TestMethod]
        public void UseQuestionmarkOperatorNotAtAll()
        {
            string name = WindowsIdentityHelper.GetNameTheClassicalWay(WindowsIdentity.GetCurrent());

            Assert.IsNotNull(name);
        }

        [TestMethod]
        public void UseQuestionmarkOperatorSingleOne()
        {
            string name = WindowsIdentityHelper.GetNameUsingQmOperator(WindowsIdentity.GetCurrent());

            Assert.IsNotNull(name);
        }

        [TestMethod]
        public void UseQuestionmarkOperatorSingleOneWithNullReference()
        {
            string name = WindowsIdentityHelper.GetNameUsingQmOperator(null);

            Assert.IsNotNull(name);
        }

        [TestMethod]
        public void UseExtensionMethodWithCorrectReference()
        {
            string name = WindowsIdentity.GetCurrent().SafelyGetName();

            Assert.IsNotNull(name);
        }

        [TestMethod]
        public void UseExtensionMethodWithNullReference()
        {
            string name = ((WindowsIdentity)null).SafelyGetName();

            Assert.IsNotNull(name);
        }

    }
}
