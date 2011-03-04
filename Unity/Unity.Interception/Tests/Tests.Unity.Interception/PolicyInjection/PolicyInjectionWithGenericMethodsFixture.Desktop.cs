﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.Unity.InterceptionExtension.Tests.PolicyInjection
{
    public partial class PolicyInjectionWithGenericMethodsFixture
    {
        [TestMethod]
        public void TransparentProxyCanInterceptNonGenericMethod()
        {
            CanInterceptNonGenericMethod<TransparentProxyInterceptor>();
        }

        [TestMethod]
        public void TransparentProxyCanInterceptGenericMethod()
        {
            CanInterceptGenericMethod<TransparentProxyInterceptor>();
        }
    }
}
