//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
////https://www.google.com/url?sa=t&source=web&rct=j&opi=89978449&url=https://academy.hsoub.com/programming/c-sharp/%25D8%25A7%25D9%2584%25D9%2585%25D8%25AA%25D8%25BA%25D9%258A%25D8%25B1%25D8%25A7%25D8%25AA-variables-%25D9%2588%25D8%25A7%25D9%2584%25D8%25B9%25D9%2588%25D8%25A7%25D9%2585%25D9%2584-operators-%25D9%2581%25D9%258A-%25D9%2584%25D8%25BA%25D8%25A9-%25D8%25B3%25D9%258A-%25D8%25B4%25D8%25A7%25D8%25B1%25D8%25A8-c-r314/
//int i = 10;
//long l = i;  // in this ex i (big val can equal small val)
//// in the 2nd ex small val cannot equal big val it give an error until add to it (int) its mean convertaton will be done in our resposibility

//// this named implicit casting
//long lgvar = 100;
////int tvar = lgvar;
//int intvar = (int)lgvar;

//// this named explicit casting

//if(lgvar <= Int32.MaxValue)
//{
//    Console.WriteLine(lgvar);
//}

//double d = 121.1232;
//int x = (int)d;
//Console.WriteLine(x);

//long l2 = 10000;
//int i2 = (int)l2;

//if(l2 <= Int32.MaxValue)
//{
//    Console.WriteLine(l2);
//}
//else
//{
//    Console.WriteLine("more than true val or wrong format");
//}

//// boning and unboxing
//// it equal value to refrence
//int i3 = 13; // value
//object obj;//refrence 
//obj = i3; // boxing
//int y = (int)obj;  // unboxing
//Console.WriteLine(y);

//string s = "10000";
////string s = "10000w";  // give u an error
////string s = "10000000000000";// give u an error
//int i4 = int.Parse(s);
//Console.WriteLine(i4);

//// percs()

//string s2 = "99999999999999999";
//if(int.TryParse(s2 , out int i5))
//    {
//        Console.WriteLine(i5);
//}
//else
//{
//    Console.WriteLine("invalid number provided or dosent fit integer");
//}

////string s3 = "mahmoud";   // error
//string s3 = "23434";
//int i6 = Convert.ToInt32(s3); 
//Console.WriteLine(i6);

//var num = 22;
//var bytes = BitConverter.GetBytes(num);

//foreach(var b in bytes)
//{
//    // tostring (var , 2 mean binary)
//    // padleft (8 mean in eat boxes and '0' mean the other empty boxes will equal zeroes
//    var bin = Convert.ToString(b, 2).PadLeft(8, '0');
//    Console.WriteLine($" {bin}");  
//}

//var name = "mahmoud";
//char[] ch = name.ToCharArray();

//foreach (char c in ch)
//{

//    int ascii = Convert.ToInt32(c);
//    Console.WriteLine();
//    var output = $"{c} : Ascii : {ascii} Binary :{Convert.ToString(ascii, 2).PadLeft(8, '0')} hexadecimal : {ascii:x}";
//    Console.WriteLine(output);
//}

//string[] hex = { "6d", "55", "23", "24", "45", "67" };
//foreach(var chr in hex)
//{
//    int val = Convert.ToInt32(chr, 16);
//    var strval = char.ConvertFromUtf32(val); // 1st method u can transfer to chars
//    var ch1 = (char)val;    // 2nd method u can transfer to chars                            
//    Console.WriteLine(strval);
//    Console.WriteLine(ch1);
//}

//var hex2 = "33d";
//int val2 = Int32.Parse(hex2, System.Globalization.NumberStyles.HexNumber);
//Console.WriteLine(val2);


//=======================================================
//========================================================





using ConsoleApp3;
using System.ComponentModel.DataAnnotations;

double netsalary;
Console.Write("\nfirst employee : ");
Console.Write("\nfirst name : ");

Emplyee[] emp = new Emplyee[2];
Emplyee e1 = new Emplyee();

e1.Fname = Console.ReadLine();
Console.Write("\nlast name : ");
e1.Lname = Console.ReadLine();
Console.Write("\nTax : ");
e1.Tax = Convert.ToDouble(Console.ReadLine());
Console.Write("\nwage : ");
e1.Wage =Convert.ToDouble( Console.ReadLine());
Console.Write("\nlogged hours : ");
e1.Loggedhours = Convert.ToDouble(Console.ReadLine());
emp[0] = e1;

Console.Write("\nsecond employee : ");
Console.Write("\nfirst name : ");


Emplyee e2 = new Emplyee();

e2.Fname = Console.ReadLine();
Console.Write("\nlast name : ");
e2.Lname = Console.ReadLine();
Console.Write("\nTax : ");
e2.Tax = Convert.ToDouble(Console.ReadLine());
Console.Write("\nwage : ");
e2.Wage = Convert.ToDouble(Console.ReadLine());
Console.Write("\nlogged hours : ");
e2.Loggedhours = Convert.ToDouble(Console.ReadLine());
emp[1] = e2;

foreach(Emplyee e in emp)
{

    Console.WriteLine(e.print_emplouee());
    

}
























