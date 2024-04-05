namespace StaticExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            string answer = "";
            do {
                Console.WriteLine("1.Mehsul elave et");
                Console.WriteLine("2.Mehsul sil\r\n    -> Silmek istediyiniz mehsulun no'su?");
                Console.WriteLine("3.Mehsula bax\r\n    -> Baxmaq istediyiniz mehsulun no'su?");
                Console.WriteLine("4.Type'a gore mehsullara bax\r\n    -> Baxmaq istediyiniz mehsullarin type'i?");
                Console.WriteLine("5.Ada gore mehsullara bax\r\n    -> Baxmaq istediyiniz mehsullarin adi?");
                Console.WriteLine("0.Proqramdan cix");
                Console.WriteLine("Secim et :");
                answer = Console.ReadLine();
                switch(answer)
                {
                    case "1":
                        Console.WriteLine("productun adini daxil et");
                        string name=Console.ReadLine();
                        string priceStr = "";
                        int price;
                        do
                        {
                            Console.WriteLine( "productun price sini daxil et");
                            priceStr = Console.ReadLine();

                        } while (!int.TryParse(priceStr, out price) || price<=0);

                        Console.WriteLine("productun typini daxil et");
                        string type = Console.ReadLine();
                        Product product=new Product(name, price,type);
                        
                        store.AddProduct(product);
                        Console.WriteLine(product.ToString());
                        break;
                    case "2":
                        string noStr = "";
                        int no1;
                        do
                        {
                            Console.WriteLine("No daxil et");
                            noStr = Console.ReadLine();

                        } while (!int.TryParse(noStr, out no1));
                        Product[] remainingProducts = store.RemoveProductByNo(no1);
                        Console.WriteLine("qalan mehsullar:");
                        foreach (var q in remainingProducts)
                        {
                            Console.WriteLine(q);
                        }
                        break;
                    case "3":
                        string nostr = "";
                        int no;
                        do
                        {
                           Console.WriteLine("No daxil et");
                            nostr = Console.ReadLine();

                        } while (!int.TryParse(nostr,out no));
                        Console.WriteLine(store.GetProduct(no));
                        break;
                    case "4":
                        Console.WriteLine("Type daxil et");
                        string typeStr=Console.ReadLine();
                        Product[] newArr= store.FilterProductsByType(typeStr);
                        foreach (var p in newArr)
                        {
                            Console.WriteLine(p);
                        }
                        break;
                    case "5":
                        Console.WriteLine("Ad daxil et");
                        string ad = Console.ReadLine();
                        Product[] arr = store.FilterProductsByName(ad);
                        foreach (var p in arr)
                        {
                            Console.WriteLine(p);
                        }
                        break;
                    default:
                        Console.WriteLine("Duzgun daxil et");
                        break;
                }



            } while (answer!="0");
        }
    }
}