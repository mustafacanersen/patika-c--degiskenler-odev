﻿// See https://aka.ms/new-console-template for more information
string str1 = string.Empty;
str1 = "Mustafa Can Ersen";
string ad = "Mustafa Can";
string soyad = "Ersen";
string tamIsim = ad + " " + soyad;
//Console.WriteLine(tamIsim);
int integer1 = 3;
int integer2 = 5;
int integer3 = integer1 * integer2;
//Console.WriteLine(integer3);
bool bool1 = 10 > 3;
//Console.WriteLine(bool1);
string str20 = "20";
int int20 = 20;
string yeniDeger = str20 + int20.ToString();
//Console.WriteLine(yeniDeger);
int int21 = int20+Convert.ToInt32(str20);
//Console.WriteLine(int21);
int int22 = int20 + int.Parse(str20);
//Console.WriteLine(int22);
string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);
string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);
string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);