// See https://aka.ms/new-console-template for more information
byte b = 5; // 1 byte
sbyte c = 5; // 1 byte

short s = 5; // 2 byte
ushort us = 5; // 2 byte

Int16 i16 = 2; // 2 byte
int i = 2; // 4 byte
Int32 i32 = 2; // 4 byte
Int64 i64 = 2; //8 byte
uint ui = 2; // 4 byte

long l = 4; // 8 byte
ulong ul = 4; // 8 byte

float f = 5; // 4 byte - reel sayılar
double d = 5; // 8 byte - reel sayılar
decimal de = 5; //16 byte - reel sayılar

char ch = '2'; // 2 byte - tek karakter tanımlama
string str = "dilan"; // sınırsız

bool b1 = true;
bool b2 = false;

DateTime datetime = DateTime.Now;
object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 4.3;

string str1 = string.Empty;
str1 = "dilan ozer";
string ad = "dilan";
string soyad = "ozer";
string tamIsim = ad + " " + soyad;

int int1 = 5;
int int2 = 2;
int int3 = int1*int2;

bool bool1 = 10 < 2;

// Degisken Donusumleri
string str20 = "20";
int int20 = 20;
string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger);

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21);

string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime1);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);