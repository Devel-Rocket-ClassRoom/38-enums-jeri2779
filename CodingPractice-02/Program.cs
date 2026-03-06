using System;
using System.Drawing;

// README.md를 읽고 아래에 코드를 작성하세요.


Console.WriteLine(" ## 1. 열거형의 기본 값");

//`Animal.Dragon`을 정수와 문자열로 각각 변환하여 출력하세요.
Animal an = Animal.Dragon;
 
Console.WriteLine($"Animal.Dragon: {(int)an},{an} ");

Console.WriteLine();
Console.WriteLine("## 2. Enum.GetValues - 열거형 값 목록");
{
    Array values = Enum.GetValues(typeof(Priority));
    Console.WriteLine("Priority 열거형의 값들:");
    foreach(var value in values)
    {
        Console.WriteLine($"{value} = {(int)value }");
    }
}








enum Animal
{
    Rabbit,
    Dragon,
    Low
}

enum Priority
{
    High = 1,
    Normal = 5,
    Low = 10
}