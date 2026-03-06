# 코딩 연습 - 열거형 (3)

`Program.cs`에 아래 과제들의 코드를 순서대로 작성하세요.
모든 과제를 작성한 후 실행하면 각 과제의 실행 결과가 순서대로 출력됩니다.

> 💡 변수 이름이 겹치는 경우 중괄호 `{ }`로 코드를 감싸면 각 블록에서 같은 이름을 사용할 수 있습니다.

이 프로젝트에서 사용할 열거형 정의 (파일 하단에 작성):

- `Animal` - Horse, Sheep = 5, Monkey
- `[Flags] CharacterStatus` - None = 0, Poison = 1, Paralyzed = 1 << 1, Confused = 1 << 2, Invisible = 1 << 3
- `[Flags] BuffStatus` - 

---

## 1. 값 지정 예제

`Animal` 열거형의 Horse, Sheep, Monkey 값을 정수로 변환하여 출력하세요.
값을 지정하지 않은 항목은 이전 항목의 값 + 1이 자동 할당됩니다.

**실행 결과**

```
0
5
6
```

---

## 2. 플래그 결합하기

`CharacterStatus.Poison`과 
`CharacterStatus.Paralyzed`를 OR 연산자(`|`)로 결합하여 
출력하세요.

**실행 결과**

```
Poison, Paralyzed
```

---

## 3. 플래그 검사하기

`CharacterStatus.Poison | CharacterStatus.Confused` 상태를 만들고, AND 연산자(`&`)로 독 상태인지, 마비 상태인지 각각 확인하세요.

**실행 결과**

```
캐릭터가 독에 걸렸습니다!
마비 상태가 아닙니다.
```

---

## 4. 플래그 추가 및 제거

`CharacterStatus.Poison`으로 시작하여 
혼란을 추가(`|=`), 
독을 제거(`&= ~`), 
투명을 토글(`^=`)하고 각 단계의 상태를 출력하세요.

**실행 결과**

```
초기 상태: Poison
혼란 추가: Poison, Confused
독 제거: Confused
투명 토글: Confused, Invisible
```

---

## 5. 플래그 열거형 활용 예제

`BuffStatus` 플래그 열거형을 사용하여 
버프 시스템을 구현하세요.
`ApplyBuff`, `RemoveBuff`, `HasBuff` 
로컬 함수를 만들고, AttackUp과 SpeedUp을 적용한 후 확인하고, AttackUp을 해제한 후 다시 확인하세요.

**실행 결과**

```
버프 적용: AttackUp
현재 버프: AttackUp
버프 적용: SpeedUp
현재 버프: AttackUp, SpeedUp
공격력 버프 있음? True
버프 해제: AttackUp
현재 버프: SpeedUp
공격력 버프 있음? False
```
