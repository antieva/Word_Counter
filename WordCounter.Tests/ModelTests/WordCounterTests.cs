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
        RepeatCounter newCounter = new RepeatCounter("dog", "dog dog dog");
        Console.WriteLine(newCounter.WordCounter());
        Assert.AreEqual(3, newCounter.WordCounter());
    }

    [TestMethod]
    public void WordCounter_LOngSentanceDog_2()
    {
        RepeatCounter anotherCounter = new RepeatCounter("dog", "The handsome, energetic, young dog was playing with a smaller more lethargic puppy and his mother, old and lazy dog.");
        Assert.AreEqual(2, anotherCounter.WordCounter());
    }

    [TestMethod]
    public void IsValid_g9003000_true()
    {
        RepeatCounter anotherCounter = new RepeatCounter("hi", "g900, 3000$?");
        Assert.AreEqual(true, anotherCounter.IsValid());
    }

    [TestMethod]
    public void IsValid_emptyString_false()
    {
      RepeatCounter anotherCounter = new RepeatCounter("hi", "");
      Assert.AreEqual(false, anotherCounter.IsValid());
    }

    [TestMethod]
    public void IsWordValid_TwoWords_false()
    {
      RepeatCounter anotherCounter = new RepeatCounter("two words", "Hey you");
      Assert.AreEqual(false, anotherCounter.IsWordValid());
    }
  }
}
