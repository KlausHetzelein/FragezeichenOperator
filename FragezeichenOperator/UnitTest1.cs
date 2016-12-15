using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Principal;

namespace FragezeichenOperator
{
    [TestClass]
    public class QuestionmarkOperatorTests
    {
        [TestMethod]
        public void UseQuestionmarkOperatorNotAtAll()
        {
            string name = GetNameTheClassicalWay(WindowsIdentity.GetCurrent());

            Assert.IsNotNull(name);
        }

        [TestMethod]
        public void UseQuestionmarkOperatorSingleOne()
        {
            string name = GetNameUsingQmOperator(WindowsIdentity.GetCurrent());

            Assert.IsNotNull(name);
        }

        [TestMethod]
        public void UseQuestionmarkOperatorSingleOneWithNullReference()
        {
            string name = GetNameUsingQmOperator(null);

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

        private string GetNameTheClassicalWay(WindowsIdentity windowsIdentity)
        {
            // the classic way
            if (null != windowsIdentity)
            {
                if (null != windowsIdentity.User)
                {
                    return windowsIdentity.User.ToString();
                }
            }

            return null;
        }
        private string GetNameUsingQmOperator(WindowsIdentity windowsIdentity)
        {
            return windowsIdentity?.Name?.ToString() ?? string.Empty;
        }
    }
}
