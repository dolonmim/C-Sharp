using System;

namespace _22

class program
static void method1(ref int x)
x = x* x;
static void method2(out int x)
x = 5; x = x* 2;
static void Main(string[] args)
int i = 6; int j;

x = x* 2;
static void Main(string[] args)
int i = 6; int j; method1(ref i); method2(out j); Console.WriteLine(i + " " + j);

