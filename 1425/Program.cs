var contacts = new List<Contact>()
{
   new Contact() { Name = "Андрей", Phone = 7999945005 },
   new Contact() { Name = "Сергей", Phone = 799990455 },
   new Contact() { Name = "Иван", Phone = 79999675 },
   new Contact() { Name = "Игорь", Phone = 8884994 },
   new Contact() { Name = "Анна", Phone = 665565656 },
   new Contact() { Name = "Василий", Phone = 3434 },
   new Contact() { Name = "Jack", Phone = 665565656 },
   new Contact() { Name = "John", Phone = 3434 }
};
while (true)
{
    Console.WriteLine("Enter page:");
    string Page = Console.ReadLine();
    if (Page != null)
    {
        int SkipQty = (int.Parse(Page) - 1) * 2;
        var result = contacts.Skip(SkipQty).Take(2);
        foreach (var contact in result)
        {
            Console.WriteLine(contact.Name);
        }
    }
}
class Contact
{
    internal string Name { get; set; }
    internal long Phone { get; set; }
}