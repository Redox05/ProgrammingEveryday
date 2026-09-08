//*********************************************************************************************************
//Problem 1 — Character frequency

string text = "Programming!$%&";

CountCharacters(text);

foreach (var kvp in CountCharacters(text))
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}


Dictionary<char, int> CountCharacters(string text)
{
    Dictionary<char, int> charCounter = new Dictionary<char, int>();
    foreach (char c in text)
    {
        if (charCounter.ContainsKey(c))
        {
            charCounter[c]++;
        }
        else
        {
            charCounter[c] = 1;
        }
    }
    return charCounter;
}


//*********************************************************************************************************
//Problem 2 — Second largest distinct number

//int[] numbers = { 1, 2 };

//int largest = int.MinValue;
//int secondLargest = int.MinValue;

//for(int i=0;i<numbers.Length;i++){
//    if(numbers[i]>largest){
//        secondLargest = largest;
//        largest = numbers[i];
//    }
//    else if(numbers[i]>secondLargest && numbers[i] != largest)
//    {
//        secondLargest = numbers[i];
//    }

//}

//if(secondLargest==int.MinValue){
//    Console.WriteLine($"There is no second largest distinct number.");
//}
//else{
//    Console.WriteLine($"Second Largest: {secondLargest}");
//}


//*********************************************************************************************************
//Problem 3 — OOP

//List<Employee> employees = new List<Employee>();

//Employee se1 = new SalariedEmployee("Ruben", "001", 80000);
//Employee se2 = new SalariedEmployee("Luisa", "002", 90000);
//Employee he1 = new HourlyEmployee("Beto", "003", 8,100);
//Employee he2 = new HourlyEmployee("Lula", "004", 8, 80);

//employees.Add(se1);
//employees.Add(se2);
//employees.Add(he1);
//employees.Add(he2);

//foreach(Employee e in employees){
//    Console.WriteLine($"Name: {e.Name}   Salary: {e.CalculatePayment()}");
//}

//public abstract class Employee{
//    public string? Name { get; protected set; }
//    public string? Id { get; protected set; }
//    public Employee(string name=null, string id=null){
//        Name = name;
//        Id = id;
//    }
//    public abstract decimal CalculatePayment();

//}
//public class SalariedEmployee : Employee{
//    public decimal MonthlySalary { get; private set; }

//    public void SetMonthlySalary(decimal monthlySalary){
//        if (monthlySalary > 0){
//            MonthlySalary= monthlySalary;
//        }
//    }
//    public SalariedEmployee(string name, string id, decimal monthlySalary):base(name,id)
//    {
//        SetMonthlySalary(monthlySalary);
//    }
//    public override decimal CalculatePayment()
//    {
//        return MonthlySalary;
//    }
//}

//public class HourlyEmployee : Employee
//{
//    public decimal HoursWorked { get; private set; }
//    public decimal HourlyRate { get; private set; }

//    public void SetHoursWorked(decimal hoursWorked)
//    {
//        if (hoursWorked > 0)
//        {
//            HoursWorked = hoursWorked;
//        }
//    }
//    public void SetHourlyRate(decimal hourlyRate){
//        if(hourlyRate>0){
//            HourlyRate = hourlyRate;
//        }
//    }

//    public HourlyEmployee (string name, string id, decimal hoursWorked, decimal hourlyRate ):base(name,id){
//        SetHoursWorked(hoursWorked);
//        SetHourlyRate(hourlyRate);
//    }
//    public override decimal CalculatePayment()
//    {
//        return HoursWorked * HourlyRate;
//    }
//}


