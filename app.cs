using System;
public class App5{
public static void Main(){
int? a = null;
int b = 5;
int? c = null;
int result = a ?? c ?? b;
Console.WriteLine("Result: " + result);
}
}
