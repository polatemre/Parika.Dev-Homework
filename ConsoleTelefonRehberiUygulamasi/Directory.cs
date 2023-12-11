using System.Buffers;

namespace ConsoleTelefonRehberiUygulamasi;
public class Directory
{

    public List<Person> _persons;

    public Directory(List<Person> persons)
    {
        _persons = persons;
    }

    public Directory()
    {
        _persons = new List<Person>();
    }

    public void Create()
    {
        Console.WriteLine();

        Console.Write("Lütfen isim giriniz             : ");
        string? firstName = Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz          : ");
        string? lastName = Console.ReadLine();
        Console.Write("Lütfen telefon numarası giriniz : ");
        string? phone = Console.ReadLine();

        _persons.Add(new()
        {
            FirstName = firstName,
            LastName = lastName,
            Phone = phone
        });

        Console.WriteLine();
    }

    public void Update()
    {
        Console.WriteLine();

        Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
        var searchValue = Console.ReadLine();
        var person = _persons.FirstOrDefault(x => x.FirstName == searchValue || x.LastName == searchValue);

        if (person == null)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("(1) Güncellemeyi sonlandırın");
            Console.WriteLine("(2) Yeniden deneyin");
            string? choose = Console.ReadLine();
            if (choose == "2")
            {
                Update();
            }

            return;
        }

        Console.Write("Lütfen isim giriniz             : ");
        person.FirstName = Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz          : ");
        person.LastName = Console.ReadLine();
        Console.Write("Lütfen telefon numarası giriniz : ");
        person.Phone = Console.ReadLine();

        Console.WriteLine();
    }

    public void Delete()
    {
        Console.WriteLine();

        Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
        var searchValue = Console.ReadLine();
        var person = _persons.FirstOrDefault(x => x.FirstName == searchValue || x.LastName == searchValue);

        if (person == null)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("(1) Silmeyi sonlandırın");
            Console.WriteLine("(2) Yeniden deneyin");
            string? choose = Console.ReadLine();
            if (choose == "2")
            {
                Delete();
            }

            return;
        }

        Console.WriteLine($"{person.FirstName} {person.LastName} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
        var chooseYN = Console.ReadLine();
        if (chooseYN == "y" || chooseYN == "Y")
        {
            _persons.Remove(person);
        }

        Console.WriteLine();
    }

    public void Search()
    {
        Console.WriteLine();

        List<Person> personSearchList = new List<Person>();

        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz");
        Console.WriteLine("(1) İsim veya soyisime göre arama yap");
        Console.WriteLine("(2) Telefon numarasına göre arama yap");
        var choose = Console.ReadLine();

        if(choose == "1")
        {
            Console.WriteLine("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
            var searchValue = Console.ReadLine();
            personSearchList = _persons.Where(x => x.FirstName == searchValue || x.LastName == searchValue).ToList();
        }
        else if(choose == "2")
        {
            Console.WriteLine("Lütfen aramak istediğiniz kişinin numarasını giriniz:");
            var searchValue = Console.ReadLine();
            personSearchList = _persons.Where(x => x.Phone == searchValue).ToList();
        }

        Console.WriteLine("Arama sonuçlarınız: ");
        foreach (Person item in personSearchList)
        {
            Console.WriteLine($"İsim: {item.FirstName} Soyisim: {item.LastName} Telefon: {item.Phone}");
        }

        Console.WriteLine();
    }

    public void GetAll()
    {
        Console.WriteLine();

        Console.WriteLine("Telefon Rehberi");
        foreach (Person item in _persons)
        {
            Console.WriteLine($"İsim: {item.FirstName} Soyisim: {item.LastName} Telefon: {item.Phone}");
        }

        Console.WriteLine();
    }
}