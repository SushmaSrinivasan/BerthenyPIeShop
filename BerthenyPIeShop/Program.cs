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


