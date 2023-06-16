public class Person
{
    private string _name;
    private int _age;
    private string _personalId;
    private Home _home;

    public Person(string name, int age, string personalId, Home home)
    {
        _name = name;
        _age = age;
        _personalId = personalId;
        _home = home;
    }
}