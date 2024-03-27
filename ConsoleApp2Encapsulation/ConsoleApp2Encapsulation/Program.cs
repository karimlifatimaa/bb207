namespace ConsoleApp2Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Library library = new Library();

            Book book = new Book("1",5,"nese1","tarixi");
            Book book1 = new Book("2", 12.50, "nese2", "macera");
            Book book2 = new Book("3", 15.70, "nese3", "tarixi");
            Book book3 = new Book("4", 123, "nese4", "macera");
            library.AddBook(book);
            library.AddBook(book1);
            library.AddBook(book2);     
            library.AddBook(book3);
            string answer;
            do
            {
                Console.WriteLine("Janr deyerine uygun kitablarin siyahisi : ");
                Console.WriteLine("Janr seciminizi edin (macera,tarixi) : ");
                answer = Console.ReadLine();

                if (answer == "macera" || answer == "tarixi")
                {
                    Book[] filteredBooks = library.GetFilteredBooks(answer);
                    for (int i = 0; i < filteredBooks.Length; i++)
                    {
                        filteredBooks[i].ShowInfo();
                    }
                }
                else
                {
                    Console.WriteLine("duzgun secim et");
                }
            } while (answer != "macera" && answer != "tarixi");
           

            Console.WriteLine("Qiymet araligindaki kitablarin siyahisi : ");
            string minStr = "";
            int min;
            do
            {
                Console.WriteLine("minPriceni daxil et : ");
                minStr = Console.ReadLine();

            } while (!int.TryParse(minStr, out min));

            string maxStr = "";
            int max;
            do
            {
                Console.WriteLine("maxPriceni daxil et : ");
                maxStr = Console.ReadLine();

            } while (!int.TryParse(maxStr, out max));

            Book[] filteredByPrice = library.GetFilteredBooks(min, max);
            for (int i = 0; i < filteredByPrice.Length; i++)
            {
                filteredByPrice[i].ShowInfo();
            }

            Console.WriteLine("Butun kitablarin siyahisini cixarmaq isteyirsinizmi? (he , yox): ");
            string answer1=Console.ReadLine();
            if (answer1 == "he") {
                library.ShowAllBooks();
            }
            else
            {
                Console.WriteLine("Proqram bitti");
            }
        }
    }
}
