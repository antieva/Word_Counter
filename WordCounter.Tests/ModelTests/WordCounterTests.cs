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

    [TestMethod]
    public void WordCounter_LOngSentanceDog_2()
    {
        Assert.AreEqual(2, RepeatCounter.WordCounter("The handsome, energetic, young dog was playing with a smaller more lethargic puppy and his mother, old and lazy dog.", "dog"));
    }

    [TestMethod]
    public void IsValid_g9003000_true()
    {
        Assert.AreEqual(true, RepeatCounter.IsValid("g900, 3000$?"));
    }

    [TestMethod]
    public void IsValid_emptyString_false()
    {
        Assert.AreEqual(false, RepeatCounter.IsValid(""));
    }
  }
}
