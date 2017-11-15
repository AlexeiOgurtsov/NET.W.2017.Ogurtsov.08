using System;
using System.Text.RegularExpressions;

namespace LogicBook

{
    [Serializable]
    public class Book : IEquatable<Book>, IComparable, IComparable<Book>
    {
        #region fields
        private static int minYear = 0;
        private static int maxYear = DateTime.Today.Year;
        private static int minPages = 1;
        private static int maxPages = Int32.MaxValue;

        /// <summary>
        /// International Standard Book Number.
        /// </summary>
        private string isbn;

        /// <summary>
        /// The name of Book.
        /// </summary>
        private string name;

        /// <summary>
        /// The author of Book.
        /// </summary>
        private string author;

        /// <summary>
        /// The Publishing House of Book.
        /// </summary>
        private string publishingHouse;

        /// <summary>
        /// The year of Book.
        /// </summary>
        private int year;

        /// <summary>
        /// The number of pages.
        /// </summary>
        private int pages;

        /// <summary>
        /// Book price.
        /// </summary>
        private int price;

        #endregion

        #region ctors

        /// <summary>
        /// Initializes an instance of the book without parameters.
        /// </summary>
        public Book() { }

        /// <summary>
        /// Initializes an instance of the book with the passed parameters.
        /// </summary>
        /// <param name="isbn">Book International Standard Book Number</param>
        /// <param name="author">Author of Book</param>
        /// <param name="name">The name of Book</param>
        /// <param name="publishingHouse">The Publishing House of Book</param>
        /// <param name="publicationYear">The year of Book</param>
        /// <param name="pageNumber">The number of pages</param>
        /// <param name="price">Book price</param>
        public Book(string isbn, string author, string name, string publishingHouse, int year, int pages, int price)
        {
            Isbn = isbn;
            Author = author;
            Name = name;
            PublishingHouse = publishingHouse;
            Year = year;
            Pages = pages;
            Price = price;
        }
        #endregion

        #region properties

        /// <summary>
        /// International Standard Book Number.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="value"/> invalid.
        /// </exception>
        public string Isbn
        {
            get { return isbn; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(Isbn));
                }
                var regEx = new Regex("(ISBN[-]*(1[03])*[ ]*(: ){0,1})*(([0-9Xx][- ]*){13}|([0-9Xx][- ]*){10})");
                if (!regEx.IsMatch(value))
                {
                    throw new ArgumentException("Invalid isbn format", nameof(value));
                }
                isbn = value;
            }

        }

        /// <summary>
        /// The name of book.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="value"/> IsNullOrWhiteSpace.
        /// </exception>
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException($"{nameof(value)} is invalid!");
                name = value;
            }
        }

        /// <summary>
        /// The author of book.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="value"/> IsNullOrWhiteSpace.
        /// </exception>
        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException($"{nameof(value)} is invalid!");
                author = value;
            }
        }

        /// <summary>
        /// The year of book.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="value"/> is invalid.
        /// </exception>
        public int Year
        {
            get { return year; }
            set
            {
                if (value < minYear || value > maxYear) throw new ArgumentException($"{nameof(value)} is invalid!");
                year = value;
            }

        }

        /// <summary>
        /// The number of pages.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="value"/> is less than or equal to 0.
        /// </exception>
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < minPages || value > maxPages) throw new ArgumentException($"{nameof(value)} is invalid!");
                pages = value;
            }
        }

        /// <summary>
        /// The Publishing House.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="value"/> IsNullOrWhiteSpace.
        /// </exception>
        public string PublishingHouse
        {
            get { return publishingHouse; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(PublishingHouse));
                }

                publishingHouse = value;
            }
        }

        /// <summary>
        /// Price of Book.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="value"/> is less than or equal to 0.
        /// </exception>
        public int Price
        {
            get { return price; }

            private set
            {
                if (value <= 0) { throw new ArgumentException(nameof(Price)); }
                price = value;
            }
        }

        #endregion

        #region methods
        /// <summary>
        /// Compares to.
        /// </summary>
        /// <returns>The to.</returns>
        /// <param name="other">Other.</param>
        public int CompareTo(Book other) => other.Pages - Pages;
        /// <summary>
        /// Compares to.
        /// </summary>
        /// <returns>The to.</returns>
        /// <param name="obj">Object.</param>
        public int CompareTo(object obj)
        {
            if ((ReferenceEquals(obj, null)) || typeof(Book) == obj.GetType()) throw new ArgumentNullException($"{nameof(obj)} is invalid!");
            return this.CompareTo(obj as Book);
        }
        /// <summary>
        /// Determines whether the specified <see cref="LogicBook.Book"/> is equal to the current <see cref="T:LogicBook.Book"/>.
        /// </summary>
        /// <param name="other">The <see cref="LogicBook.Book"/> to compare with the current <see cref="T:LogicBook.Book"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="LogicBook.Book"/> is equal to the current <see cref="T:LogicBook.Book"/>;
        /// otherwise, <c>false</c>.</returns>
        public bool Equals(Book other)
        {
            if (ReferenceEquals(other, null)) return false;
            return ((Name == other.Name) && (Author == other.Author) && (Year == other.Year) && (Pages == other.Pages) && (Isbn == other.Isbn));
        }
        /// <summary>
        /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="T:LogicBook.Book"/>.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to compare with the current <see cref="T:LogicBook.Book"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="object"/> is equal to the current <see cref="T:LogicBook.Book"/>;
        /// otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if ((ReferenceEquals(obj, null)) || typeof(Book) == obj.GetType()) return false;
            return Equals(obj as Book);
        }
        /// <summary>
        /// Serves as a hash function for a <see cref="T:LogicBook.Book"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a hash table.</returns>
        public override int GetHashCode() => Isbn.GetHashCode() + Pages.GetHashCode() + Year.GetHashCode() + Author.GetHashCode() + Name.GetHashCode();
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:LogicBook.Book"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:LogicBook.Book"/>.</returns>
        public override string ToString() => $" ISBN: {Isbn}, \"{Name}\", author: {Author}, year of publishing: {Year}, {Pages} pages";
        #endregion
    }
}
