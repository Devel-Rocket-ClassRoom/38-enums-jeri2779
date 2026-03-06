using System;
using System.Net.NetworkInformation;

// README.md를 읽고 코드를 작성하세요.
// 1. 파일 권한 열거형 정의

Console.WriteLine("=== 파일 권한 관리 ===");


//2. 초기 권한은 `None`으로 설정할 것
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
Console.WriteLine(HasFlag(FilePermission.Read));
Console.WriteLine(HasFlag(FilePermission.Write));
Console.WriteLine(HasFlag(FilePermission.Execute));
 






















[Flags]
enum FilePermission
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4

}
