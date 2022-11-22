using ConsoleApp1;
using System;

Sample01 sample01 = new Sample01();
//await sample01.Print("Hello");
//await sample01.Print("world");

var result = sample01.Print("Hello");
var result01 = sample01.Print("world");
await result;
await result01;