Console.WriteLine("Welcome to Bertheny's Pie Shop HRM");
Console.WriteLine("Please enter your name:");
string name=Console.ReadLine();
/*
double d = 100.0d;
const double price = 170.0d;
decimal price2 = 150.0m;
*/
double ratePerHour = 12.34d;
int numberOfHoursWorked = 165;
double currentMonthWage = ratePerHour * numberOfHoursWorked;
Console.WriteLine(currentMonthWage);

ratePerHour += 3;
Console.WriteLine(ratePerHour);

if (currentMonthWage > 2000)
    Console.WriteLine("Top Paid Employee");

int numberOfEmployees = 15;
numberOfEmployees--;
Console.WriteLine(numberOfEmployees);

bool a;

a = true;


int intMaxValue=int.MaxValue;
int intMinValue=int.MinValue;

char userSelection ='a';
char upperVersion=char.ToUpper(userSelection);

bool isDigit=char.IsDigit(upperVersion);
bool isLetter=char.IsLetter(upperVersion);

DateTime hiredate = new DateTime(2023, 10, 12, 10, 00, 00);
DateTime lastdate = new DateTime(2024, 01, 01);

DateTime startDate = hiredate.AddDays(15);
Console.WriteLine(startDate);

DateTime currentDate=DateTime.Now;
bool areWeInDst=currentDate.IsDaylightSavingTime();

DateTime startHour=DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 30, 00);
DateTime endHour = startHour.Add(workTime);

Console.WriteLine(startHour.ToLongDateString());
Console.WriteLine(endHour.ToShortTimeString());

Console.ReadLine();

//if else statements

Console.WriteLine("Enter the age of the candidate:");
int age=int.Parse(Console.ReadLine());

if (age < 18)
    Console.WriteLine("Too young to apply");
else if (age > 65)
    Console.WriteLine("Too old to apply and not eligible");
else
    Console.WriteLine("Great!You can apply");

//switch
switch(age)
{

    case < 18:
        Console.WriteLine("Too young to apply");
        break;
    case > 65:
        Console.WriteLine("Too old and not eligible");
        break;
    default:
        Console.WriteLine("Great!You can apply");
        break;
}


