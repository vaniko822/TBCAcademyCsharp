
using Task2;

Customer customer1 = new Customer()
{
    Firstname = "Demetre",
    Lastname = "Tavdadebuli",
    Age = 23,
    PersonalId = "01002133124"
};

Customer customer2 = new Customer()
{
    Firstname = "Vaniko",
    Lastname = "Kukutchanashvili",
    Age = 21,
    PersonalId = "01002443124"
};

Customer customer3 = new Customer()
{
    Firstname = "Lika",
    Lastname = "Bagrationi",
    Age = 31,
    PersonalId = "01002577524"
};

Customer customer4 = new Customer()
{
    Firstname = "Nana",
    Lastname = "Kiknavelidze",
    Age = 22,
    PersonalId = "01222247526"
};

Customer customer5 = new Customer()
{
    Firstname = "Levan",
    Lastname = "Targariani",
    Age = 45,
    PersonalId = "01333247556"
};

Customer customer6 = new Customer()
{
    Firstname = "Mishka",
    Lastname = "Beridze",
    Age = 31,
    PersonalId = "12342345426"
};

Customer[] customers = new Customer[] { customer2, customer3 };
CustomList customlist = new CustomList();
Customer[] customerinsertlist = new Customer[] { customer5, customer6 };

/* Arrays zomis gansazgvra */
customlist.CustomerCapacity = 20;

/* Customlist-shi Elementebis damateba */
customlist.AddElement(customer1);
customlist.AddElement(customer2);

/* Ramdenime Customer-is damateba AddList-it */
customlist.AddList(customers);

/* Elementebis raodenoba */
var count = customlist.Count;
Console.WriteLine(count);

/* Elementis chawera konkretul indexze */
var insert = customlist.InsertElement(customer4, 2);
if(insert == true)
{
    Console.WriteLine($"Elementi Chaiwera Tqven Mititebul Konkretul Indexze - {insert}");
}
else
{
    Console.WriteLine($"Elementis Chawera Konkretul Indexze Ver Moxerxda! - {insert}");
}

/* Elementebis chawera konkretul indexebze */
var insertlist = customlist.InsertList(customerinsertlist, new int[] { 1, 2 });
Console.WriteLine(insertlist);

/* Elementis wamogeba(Saxelis da gvaris) */
var getElement = customlist.GetElement(0);
Console.WriteLine($"Wamogebuli Elementis Sruli Saxeli - {getElement.Firstname} {getElement.Lastname}");

/* Gadavcemt indexebs ris mixedvitac gvibrunebs raodenobas tu sheyvanili indexebidan ramdeni dabrunda */
int[] indexes = new int[] { 0, 1, 4 };
var getlist = customlist.GetList(indexes);
Console.WriteLine($"Gadacemuli {indexes.Length} indexidan dabrunda {getlist} indexi");

/* PersonalId-it Customer-is modzebna(Saxeli da gvaris) */
var find = customlist.Find("01002133124");
if(find != null)
{
    Console.WriteLine($"Momxmareblis sruli saxelia - {find.Firstname} {find.Lastname}");
}
else
{
    Console.WriteLine("Ver Moidzebna Customeri");
}

/* Yvela elementis washla, vidzaxebt counts rata davrwmundet rom momxmareblebi agar arian siashi */
customlist.Clear();

var countCustomers =  customlist.Count;
Console.WriteLine($"Moxmareblebis Raodenoba - {countCustomers}");