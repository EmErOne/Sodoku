using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sodoku.Core.Models;
using Sodoku.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sodoku.Core.Test
{
    [TestClass]
    public class MatchfieldReflectionServcieTest
    {
        Matchfield _matchfield = new Matchfield();

        [TestMethod]
        public void ReflactVerticalTest()
        {
            MatchfieldReflectionServcie servcie = new MatchfieldReflectionServcie(_matchfield);
            var matchfield = servcie.ReflactVertical();
        }
    }
}
