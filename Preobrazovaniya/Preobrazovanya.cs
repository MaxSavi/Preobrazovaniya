class Program
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee("Tom", "Microsoft");
        Person person = employee;
        Person bob = new Client("Bob", "ContosoBank"); // преобразование из производного класса в базовый
        Console.WriteLine(((Client)bob).Bank); // дополнительное преобразование от Person к Client для вызова переменной Bank
        object obj = new Employee("Bill", "Microsoft");
        string company = ((Employee)obj).Company;
        int smallNum = 123;
        long bigNum = smallNum;//преобразование из меньшего числа в большее
        string input = "00";
        int result = Int32.Parse(input);// преобразование из строки в число
        byte[] arr = { 0, 0, 0, 25 };
        if (BitConverter.IsLittleEndian)
            Array.Reverse(arr);
        int i = BitConverter.ToInt32(arr, 0);
        Console.WriteLine($"целое число: {i}"); //преобразование из массива байтов в целое число
    }
}
class Person
{
    public string Name { get; set; }
    public int age { get; set; }
    public Person(string name) // Конструктор Person
    {
        Name = name;
    }
    public Person(string name, int age) // Перегрузка конструктора Person
    {
        Name = name;
        this.age = age;
    }
    public void Print()
    {
        Console.WriteLine($"Person {Name}");
    }
}

class Employee : Person // Наследование от класса Person
{
    public string Company { get; set; }
    public Employee(string name, string company) : base(name) // Наследование конструктора
    {
        Company = company;
    }
    public Employee(string name, string company, int age) : base(name, age) // Наследование перегруженного конструктора
    {
        Company = company;
    }

}

class Client : Person // Наследование от класса Person
{
    public string Bank { get; set; }
    public Client(string name, string bank) : base(name) // Наследование конструктора
    {
        Bank = bank;
    }
}
