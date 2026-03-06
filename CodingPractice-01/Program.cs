using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("## 1. 열거형을 사용한 조건 ");
Priority ph = Priority.High;
if (ph == Priority.High)
{
    Console.WriteLine("높은 우선순위");
}


Console.WriteLine();
Console.WriteLine("## 2. 열거형 변수 선언과 비교");

Animal an = Animal.Tiger;
if (an == Animal.Tiger)
{
    Console.WriteLine("\"호랑이\"");
}

Console.WriteLine();
Console.WriteLine("## 3. 열거형 항목에 특정 값 지정");

Type type = typeof(Color);

foreach (var item in Enum.GetValues(type))
{
    Console.Write($"{item} = {(int)item}, ");
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("## 4. 기반 타입 지정");

Console.WriteLine(sizeof(Smallenum)); // 1 byte

Console.WriteLine();
Console.WriteLine("## 5. Enum.GetNames - 열거형 이름 목록");

Type cstype = typeof(ConsoleColor);
Console.WriteLine("ConsoleColor 열거형의 색상들:");
foreach (var item in Enum.GetNames(cstype))
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("## 6. Enum.Parse - 문자열을 열거형으로 변환");
{
    string chng = "Up";
    if (Enum.TryParse(chng, out Direction dir))
    {
        Console.WriteLine($"변환 성공:{dir} ");
    }
    else
    {
        Console.WriteLine("변환 실패");
    }

    string chng2 = "Forward";
    if (Enum.TryParse(chng2, out Direction dir2))
    {
        Console.WriteLine($"변환 성공:{dir2} ");
    }
    else
    {
        Console.WriteLine("변환 실패");
    }
}
Console.WriteLine();
Console.WriteLine("## 6. Enum.Parse - 문자열을 열거형으로 변환");
{
    string red = "Red";
    ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), red);
     
    Console.ForegroundColor = color;
    Console.WriteLine("빨간색 텍스트");
    Console.ResetColor();
    Console.WriteLine("기본 색상 텍스트");
}

Console.WriteLine();

Console.WriteLine("## 8. Enum.IsDefined - 값 유효성 검사");
{
    bool isValid = Enum.IsDefined(typeof(Animal), 1);
    Console.WriteLine($"1은 유효한 Animal 값인가? {isValid}");

    isValid = Enum.IsDefined(typeof(Animal), 100);
    Console.WriteLine($"100은 유효한 Animal 값인가? {isValid}");

    isValid = Enum.IsDefined(typeof(Animal), "Tiger");
    Console.WriteLine($"'Tiger'는 유효한 Animal 값인가? {isValid}");
}

Console.WriteLine();
Console.WriteLine("## 9. 열거형과 정수 간 변환");

Direction dir9 = Direction.Right;
int num = (int)dir9;
Console.WriteLine($"{dir9} = {num}");

int value = 2;
Direction dir3 = (Direction)value;
Console.WriteLine($"{value} = {dir3}");

Console.WriteLine();
Console.WriteLine("## 10. 정의되지 않은 정수를 열거형으로 변환");

Animal invalid = (Animal)100;
Console.WriteLine(invalid);












enum Priority
{
    High,
    Normal,
    Low
}

enum Animal
{
    Mouse, 
    Cow, 
    Tiger
}

enum Color
{
    Red = 10, 
    Green, 
    Blue = 20
}

enum Smallenum : byte
{
    Left, 
    Right, 
    Top, 
    Bottom
}

enum Direction
{
    Up, 
    Down, 
    Left, 
    Right
}