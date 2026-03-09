using System;
using System.Net.NetworkInformation;

// README.md를 읽고 코드를 작성하세요.
// 1. 파일 권한 열거형 정의
//    - `None`, `Read`, `Write`, `Execute` 권한을 포함할 것
//    - `Flags` 특성을 사용하여 비트 플래그로 정의할 것

Console.WriteLine("=== 파일 권한 관리 ===");
FilePermission user = FilePermission.None;
Console.WriteLine($"현재 권한: {user}");
//3. `|=` 연산자로 권한을 추가할 것
user |= FilePermission.Read;
Console.WriteLine($"Read 추가 : {user}");
user |= FilePermission.Write;
Console.WriteLine($"Write 추가 : {user}");
user |= FilePermission.Execute;
Console.WriteLine($"Execute 추가 : {user}");


bool HasFlag(FilePermission permission)
{ 
    return (user & permission) != 0;
}
Console.WriteLine();
Console.WriteLine("[권한 확인]");
Console.WriteLine($"Read 권한: {HasFlag(FilePermission.Read)}");
Console.WriteLine($"Write 권한: {HasFlag(FilePermission.Write)}");
Console.WriteLine($"Execute 권한: {HasFlag(FilePermission.Execute)}");
//`&= ~` 연산자로 권한을 제거할 것
Console.WriteLine();
Console.WriteLine("[권한 제거]");
user &= ~FilePermission.Write;
Console.WriteLine($"Write 제거 : {user}");

Console.WriteLine();
Console.WriteLine("[제거 후 확인]");
Console.WriteLine($"Read 권한: {HasFlag(FilePermission.Read)}");
Console.WriteLine($"Write 권한: {HasFlag(FilePermission.Write)}");
Console.WriteLine($"Execute 권한: {HasFlag(FilePermission.Execute)}");

[Flags]
enum FilePermission
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4
}




//2. 초기 권한은 `None`으로 설정할 것

