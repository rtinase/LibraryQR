using LibraryQR.Logic;

namespace LibraryQR.Components.Pages;

partial class Library
{
    public List<Book> Books = new List<Book>()
    {
         new Book("1984","George Orwell"),
         new Book("To kill a mockingbird","Harper Lee"),
         new Book("The lord of the rings","J.R.R. Tolkien"),
         new Book("The catcher in the rye","J.D. Salinger"),
         new Book("The Great Gatsby","F. Scott Fitzgerald")
    };
}

