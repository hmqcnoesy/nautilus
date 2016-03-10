using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nautilus.Extensions.Tests
{
    [TestClass]
    public class ExtensionContextTests
    {
        [TestMethod]
        public void WorkflowId_ShouldBeNull_WhenNoWorkflowParametersArePassedInConstructor()
        {
            var parameters = new LSEXT.LSExtensionParameters();
            var ctx = new ExtensionContext(parameters);
            Assert.IsNull(ctx.WorkflowId);
        }
    }
}
