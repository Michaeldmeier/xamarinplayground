using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace xamarinplayground.MVVM
{
    [TestClass]
    public class MyPageViewModelTest
    {
        [TestMethod]
        public void IncrementCommand_SetsExpectedResults()
        {
            // Arange
            var vm = new MyPageViewModel();

            // Act
            vm.IncrementCommand.Execute(null);

            // Assert
            Assert.AreEqual("1", vm.Result);
        }
    }
}
