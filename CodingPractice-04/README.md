# 코딩 연습 - 열거형 (4)

`Program.cs`에 아래 과제들의 코드를 순서대로 작성하세요.
모든 과제를 작성한 후 실행하면 각 과제의 실행 결과가 순서대로 출력됩니다.

> 💡 변수 이름이 겹치는 경우 중괄호 `{ }`로 코드를 감싸면 각 블록에서 같은 이름을 사용할 수 있습니다.

이 프로젝트에서 사용할 열거형 정의 (파일 하단에 작성):

- `Animal` - Chicken, Dog, Pig
- `CharacterState` - Idle, Walking, Running, Jumping, Attacking, Dead
- `ItemRarity` - Common, Uncommon, Rare, Epic, Legendary
- `Direction` - Up, Down, Left, Right

---

## 1. 열거형과 switch 문

`Animal.Dog`를 switch 문으로 분기하여 해당하는 한국어 이름을 출력하세요.
Chicken은 "닭", Dog은 "개", Pig는 "돼지"로 출력합니다.

**실행 결과**

```
개
```

---

## 2. 캐릭터 상태 관리

`CharacterState` 열거형을 사용하여 캐릭터 상태에 따른 애니메이션을 재생하는 `Update` 로컬 함수를 만드세요.
상태를 `Attacking`으로 변경한 후 `Update`를 호출하세요.

**실행 결과**

```
공격 애니메이션 재생
```

---

## 3. 아이템 등급

아이템 이름과 `ItemRarity` 등급을 받아 출력하는 
`PrintItemInfo` 로컬 함수를 만드세요.
"전설의 검"을 `Legendary` 등급으로 출력하세요.

**실행 결과**

```
아이템: 전설의 검
등급: Legendary
```

---

## 4. 방향 처리

`Direction` 열거형을 받아 이동 방향을 출력하는 `Move` 로컬 함수를 만드세요.
`Direction.Up`과 `Direction.Right`로 각각 호출하세요.

**실행 결과**

```
위로 이동 (y + 1)
오른쪽으로 이동 (x + 1)
```
