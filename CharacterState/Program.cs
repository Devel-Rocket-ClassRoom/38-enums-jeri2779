using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 캐릭터 상태 관리 ===");

CharacterState state = CharacterState.Idle;

while(true)
{
    Console.WriteLine($"현재 상태: {state}");
    Console.WriteLine();
    Console.WriteLine("1. 상태 변경");
    Console.WriteLine("2. 상태 목록 보기");
    Console.WriteLine("3. 현재 행동 보기");
    Console.WriteLine("4. 종료");
    Console.Write("선택: ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine("변경할 상태 번호 입력 (0-5):");
            if (Enum.TryParse(Console.ReadLine(), out CharacterState newState))
            {
                state = newState;
                Console.WriteLine($"상태가 {state}로 변경되었습니다.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("잘못된 상태입니다.");
            }
            break;
        case "2":
            Console.WriteLine("=== 상태 목록 ===");
            foreach (var s in Enum.GetValues(typeof(CharacterState)))
            {
                Console.WriteLine($"{s} = {(int)s}");
            }
            break;
        case "3":
            //switch문으로 변경 고려
            if (state == CharacterState.Dead)
            {
                Console.WriteLine("[행동] 사망 상태입니다. 행동할 수 없습니다.");
                Console.WriteLine();
            }
            if(state == CharacterState.Attacking)
            {
                Console.WriteLine("[행동] 적을 공격합니다");
                Console.WriteLine();
            }
            if (state == CharacterState.Idle)
            {
                Console.WriteLine("[행동] 대기 상태입니다.");
                Console.WriteLine();
            }
            if (state == CharacterState.Walking)
            {
                Console.WriteLine("[행동] 걷고 있습니다.");
                Console.WriteLine();
            }
            if (state == CharacterState.Running)
            {
                Console.WriteLine("[행동] 달리고 있습니다.");
                Console.WriteLine();
            }
            if (state == CharacterState.Jumping)
            {
                Console.WriteLine("[행동] 점프하고 있습니다.");
                Console.WriteLine();
            }
            break;
        case "4":
            Console.WriteLine("프로그램을 종료합니다.");
            return;
        default:
            Console.WriteLine("잘못된 선택입니다.");
            break;
    }
    
}
//현재 개선해야 할 점.
//변경할 상태 번호중 5번이 dead인데 행동이 공격으로 나오는 점 개선 필요. dead 상태에서는 행동이 죽음으로 나와야 함.
//case 4에서 종료를 선택하면 while문이 종료되도록 개선 필요. 현재는 종료를 선택해도 계속 반복됨.
//상태 변경 시 유효한 번호인지 체크하는 부분 개선 필요. 현재는 0-5 이외의 번호를 입력해도 상태가 변경됨.
//현재 [행동] 사망 상태입니다. 행동할 수 없습니다. 출력이 나오게 개선 필요.
 
 



enum CharacterState
{
    Idle = 0,
    Walking = 1,
    Running = 2,
    Jumping = 3,
    Attacking = 4,
    Dead = 5
}