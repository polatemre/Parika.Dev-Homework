
var directory = new ConsoleTelefonRehberiUygulamasi.Directory(new()
{
    new() { FirstName= "Emre", LastName = "Polat", Phone= "+905311234567"},
    new() { FirstName= "Melih", LastName = "Yılmaztürk", Phone= "+905329876543"},
    new() { FirstName= "Yiğit", LastName = "Öztürk", Phone= "+905339513278"},
    new() { FirstName= "Yasin", LastName = "Yorulmaz", Phone= "+905347538745"},
    new() { FirstName= "Gençay", LastName = "Yıldız", Phone= "+905354564567"},
});

while (true)
{
    Console.WriteLine();

    Console.WriteLine("Lütfen seçim yapınız:");
    Console.WriteLine("(1) Yeni numara kaydetmek");
    Console.WriteLine("(2) Varolan numarayı silmek");
    Console.WriteLine("(3) Varolan numarayı güncelleme");
    Console.WriteLine("(4) Rehberi listelemek");
    Console.WriteLine("(5) Rehberde arama yapmak");
    Console.Write("Seçiminiz: ");
    var choose = Console.ReadLine();

    switch (choose)
    {
        case "1":
            directory.Create(); // tamam
            break;
        case "2":
            directory.Delete();
            break;
        case "3":
            directory.Update();
            break;
        case "4":
            directory.GetAll(); // tamam
            break;
        case "5":
            directory.Search();
            break;
        default:
            Console.WriteLine("Lütfen 1-5 arasında bir rakam giriniz");
            break;
    }
}