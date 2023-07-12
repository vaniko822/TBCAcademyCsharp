
using Task1;
using Task2;

ContactList contactList = new ContactList();

contactList.AddContact("Vano", "Kukutchanashvili", 21);
contactList.AddContact("Lika", "Kukutchanashvili", 24);
contactList.AddContact("Nino", "Mgaloblishvili", 49);
contactList.AddContact("Davit", "Kharaishvili", 21);
contactList.AddContact("Nikusha", "Chargazia", 23);
contactList.AddContact("Davit", "Jishkariani", 21);

while (true)
{
    Console.WriteLine("1. FirstName Filter" + '\n' +
    "2. LastName Filter" + '\n' +
    "3. FullName Filter" + '\n' +
    "4. Age Filter" + '\n' +
    "5. Close"
    );

    Console.WriteLine("Enter filter index: ");
    int choose = int.Parse(Console.ReadLine());

    if(choose == 5)
    {
        break;
    }

    var del = new ContactFiltersDelegate(Filters.FilterFirstName);

    switch (choose)
    {
        case 1:
            string firstName = Console.ReadLine();
            del(firstName, contactList._contacts);
            break;
        case 2:
            del = Filters.FilterLastName;
            string lastName = Console.ReadLine();
            del(lastName, contactList._contacts);
            break;
        case 3:
            var del2 = new ContactFiltersDelegateWithThreeParam(Filters.FilterFullName);
            string firstNameDel = Console.ReadLine();
            string lastNameDel = Console.ReadLine();
            del2(firstNameDel, lastNameDel, contactList._contacts);
            break;
        case 4:
            var del3 = new ContactFilterAgeDelegate(Filters.FilterAge);
            int age = int.Parse(Console.ReadLine());
            del3(age, contactList._contacts);
            break;
    }
}

public delegate void ContactFiltersDelegate(string a, List<Contact> contacts);
public delegate void ContactFiltersDelegateWithThreeParam(string a, string b, List<Contact> contacts);
public delegate void ContactFilterAgeDelegate(int age, List<Contact> contacts);