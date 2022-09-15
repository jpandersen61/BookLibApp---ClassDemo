using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;
using BookLibApp;

namespace TestBookLibApp
{
    [TestClass]
    public class TestBookLib
    {
        [TestMethod]
        public void TestYearProperty()
        {
            Book book = new Book();

            book.Year = Book.MinYear;
            Assert.AreEqual(book.Year, Book.MinYear);

            book.Year = Book.MinYear + 1;
            Assert.AreEqual(book.Year, Book.MinYear + 1);

            book.Year = Book.MaxYear;
            Assert.AreEqual(book.Year, Book.MaxYear);

            book.Year = Book.MaxYear - 1;
            Assert.AreEqual(book.Year, Book.MaxYear - 1);
        }

        [TestMethod]
        public void TestTitleProperty()
        {
            Book book = new Book();

            book.Title = "Title";
            Assert.AreEqual(book.Title, "Title");
        }

        [TestMethod]
        public void TestYearExceptions()
        {
            Book book = new Book();

            book.Year = Book.MinYear;

            book.Year = Book.MaxYear;

            try
            {
                book.Year = Book.MinYear - 1;
                Assert.Fail("Exception on minimum year exceeded expected");
            }
            catch (ArgumentOutOfRangeException)
            {

            }

            try
            {
                book.Year = Book.MaxYear + 1;
                Assert.Fail("Exception on maximum year exceeded expected");
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        [TestMethod]
        public void TestTitleExceptions()
        {
            Book book = new Book();

            book.Title = new string('x', Book.MinTitleLength);

            try
            {
                book.Title = new string('x', Book.MinTitleLength - 1);
                Assert.Fail("Exception on minimum title length expected");
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }
    }
}
