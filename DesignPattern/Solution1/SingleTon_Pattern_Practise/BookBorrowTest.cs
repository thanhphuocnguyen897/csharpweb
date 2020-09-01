using System;

namespace SingleTon_Pattern_Practise
{
    class BookBorrowTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin Testing SingleTon Pattern...");
            Console.WriteLine("-----------------------------------");
            BookBorrower borrower1 = new BookBorrower();
            BookBorrower borrower2 = new BookBorrower();
            borrower1.BorrowBook();
            Console.WriteLine("Book Borrower 1 asked to borrow the book");
            Console.WriteLine("Book borrower 1 Borrowed the book: " + borrower1.GetAuthorAndTitle());

            borrower2.BorrowBook();
            Console.WriteLine("Book Borrower 2 asked to borrow the book");
            Console.WriteLine("Book borrower 2 Borrowed the book: " + borrower2.GetAuthorAndTitle());

            borrower1.ReturnBook();
            Console.WriteLine("Borrower 1 returned the book.");
            borrower2.BorrowBook();
            Console.WriteLine("Book Borrower 2 asked to borrow the book");
            Console.WriteLine("Book borrower 2 Borrowed the book: " + borrower2.GetAuthorAndTitle());
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("End Testing Singleton Pattern");
        }
    }
    /*Bước 1: Tạo lớp BookSingleton với các thuộc tính: Auth, Title, Book, IsLoanedOut cùng các phương thức getAuthor và getTitle*/
    public class BookSingleTon
    {
        private string Author { get; }
        private string Title { get; }
        private static BookSingleTon Book;
        private static bool IsLoandedOut;
        //Bước 2: Xây dựng phương thức khởi tạo cho lớp BookSingleton
        private BookSingleTon()
        {
            Author = "Gamma, Helm, Johnson, and Vlissides";
            Title = "Design Patterns";
            Book = null;
            IsLoandedOut = false;
        }
        //Bước 3: Xây dựng phương thức thực hiện mượn sách
        public static BookSingleTon BorrowBook()
        {
            if (!IsLoandedOut)
            {
                if(Book == null)
                {
                    Book = new BookSingleTon();
                }
                IsLoandedOut = true;
                return Book;
            }
            return null;
        }
        //Bước 4: Xây dựng phương thức thực hiện trả sách
        public void ReturnBook(BookSingleTon book)
        {
            IsLoandedOut = false;
        }
        //Bước 5: Tạo phương thức lấy thông tin về sách
        public String GetAuthorAndTitle()
        {
            return Title + "by" + Author;
        }
    }
    /*Tạo lớp BookBorrower là người mượn sách.
    Lớp này có 2 thuộc tính là đối tượng sách cần mượn và trạng thái mượn sách, mặc đinh lúc đầu là false.*/
    public class BookBorrower
    {
        private BookSingleTon BorrowedBook;
        private bool HaveBook = false;
        //Bước 7: Tạo phương thức mượn sách BorrowBook()
        public void BorrowBook()
        {
            BorrowedBook = BookSingleTon.BorrowBook();
            HaveBook = BorrowedBook == null ? false : true;
        }
        //Bước 8: Xây dựng phương thức lấy về thông tin sách mượn
        public String GetAuthorAndTitle()
        {
            if (HaveBook)
            {
                return BorrowedBook.GetAuthorAndTitle();
            }
            return "I dont have the book.";
        }
        //Bước 9: Xây dựng phương thức trả sách
        public void ReturnBook()
        {
            BorrowedBook.ReturnBook(BorrowedBook);
        }
    }
}
