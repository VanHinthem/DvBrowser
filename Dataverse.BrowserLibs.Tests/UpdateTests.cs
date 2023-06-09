﻿using Dataverse.WebApi2IOrganizationService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dataverse.BrowserLibs.Tests
{
    [TestClass]
    public class UpdateTests
    {
        public TestContext TestContext { get; set; }




        [TestMethod]
        public void Update()
        {
            WebApiRequest webApiRequest = WebApiRequest.CreateFromLocalPathWithQuery(
                "PATCH",
                $"/api/data/v9.2/contacts({Helper.GetId(this.TestContext, "contact")})",
                new System.Collections.Specialized.NameValueCollection()
                {
                    {"Content-Type", "application/json" }
                },
                "{\"firstname\":\"test\"}"
                );
            Helper.TestAgainstExpected(this.TestContext, webApiRequest);

        }

    }
}