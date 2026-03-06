using System;

// README.md를 읽고 아래에 코드를 작성하세요.


Console.WriteLine("## 1. 값 지정 예제");
//값을 정수로 변환하여 출력
Array an = Enum.GetValues(typeof(Animal));
foreach(var item in an)
{
    Console.WriteLine((int)item);
}

Console.WriteLine();
Console.WriteLine("## 2. 플래그 결합하기");

CharacterStatus status = CharacterStatus.Poison | CharacterStatus.Paralyzed;
Console.WriteLine(status);

Console.WriteLine();
Console.WriteLine("## 3. 플래그 검사하기");
{
    CharacterStatus currStatus = CharacterStatus.Poison | CharacterStatus.Confused;
    if ((currStatus & CharacterStatus.Poison) != 0)
    {
        Console.WriteLine("독 상태입니다.");
    }
    if ((currStatus & CharacterStatus.Paralyzed) != 0)
    {
        Console.WriteLine("캐릭터가 마비되었습니다.");
    }
    else
    {
        Console.WriteLine("마비 상태가 아닙니다");
    }
}
Console.WriteLine();
Console.WriteLine("## 4. 플래그 추가 및 제거");
{
    CharacterStatus status4  = CharacterStatus.Poison;

    //플래그 추가
    Console.WriteLine($"초기 상태: {status4}");
    status4 |= CharacterStatus.Confused;
    Console.WriteLine($"혼란 추가: {status4}");
    status4 &= ~CharacterStatus.Poison;
    Console.WriteLine($"독 제거: {status4}");
    status4 ^= CharacterStatus.Invisible;
    Console.WriteLine($"투명 토글: {status4}");
}
Console.WriteLine();
Console.WriteLine("## 5. 플래그 열거형 활용 예제");
BuffStatus buff = BuffStatus.None;

ApplyBuff(BuffStatus.AttackUp);
ApplyBuff(BuffStatus.SpeedUp);
Console.WriteLine($"공격력 버프 있음? {HasBuff(BuffStatus.AttackUp)}");
RemoveBuff(BuffStatus.AttackUp);
Console.WriteLine($"공격력 버프 있음? {HasBuff(BuffStatus.AttackUp)}");

void ApplyBuff(BuffStatus nbuff)
{
    buff |= nbuff;
    Console.WriteLine($"버프 적용: {nbuff}");
    Console.WriteLine($"현재 버프: {buff}");
}

void RemoveBuff(BuffStatus nbuff)
{
    buff &= ~nbuff;
    Console.WriteLine($"버프 해제: {nbuff}");
    Console.WriteLine($"현재 버프: {buff}");
}

bool HasBuff(BuffStatus nbuff)
{
    return (buff & nbuff) != 0;
}

[Flags]
public enum CharacterStatus
{
    None = 0, 
    Poison = 1, 
    Paralyzed = 1 << 1, 
    Confused = 1 << 2, 
    Invisible = 1 << 3
}

[Flags]
enum BuffStatus
{
    None = 0, 
    AttackUp = 1,
    DefenseUp = 1 << 1,
    SpeedUp = 1 << 2, 
    All = AttackUp | DefenseUp | SpeedUp
}

enum Animal
{
    Horse,
    Sheep = 5,
    Monkey
}

 