using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounterApp;
using System;

namespace WordCounterApp.Tests
{
  [TestClass]
  public class WordCounterAppTest
  {

    [TestMethod]
    public void WordCounter_HowAreYouHey_0()
    {
        Assert.AreEqual(0, RepeatCounter.WordCounter("how are you?", "hey"));
    }
  }
}
