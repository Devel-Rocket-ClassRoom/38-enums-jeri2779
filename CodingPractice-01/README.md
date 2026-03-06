# 코딩 연습 - 열거형 (1)

`Program.cs`에 아래 과제들의 코드를 순서대로 작성하세요.
모든 과제를 작성한 후 실행하면 각 과제의 실행 결과가 순서대로 출력됩니다.

> 💡 변수 이름이 겹치는 경우 중괄호 `{ }`로 코드를 감싸면 각 블록에서 같은 이름을 사용할 수 있습니다.

이 프로젝트에서 사용할 열거형 정의 (파일 하단에 작성):

- `Priority` - High, Normal, Low
- `Animal` - Mouse, Cow, Tiger
- `Color` - Red = 10, Green, Blue = 20
- `SmallEnum : byte` - Left, Right, Top, Bottom
- `Direction` - Up, Down, Left, Right

---

## 1. 열거형을 사용한 조건 분기

`Priority` 열거형 변수를 선언하고 `Priority.High`를 할당하세요.
`if` 문으로 값이 `Priority.High`인지 확인하고 "높은 우선순위"를 출력하세요.

**실행 결과**

```
높은 우선순위
```

---

## 2. 열거형 변수 선언과 비교

`Animal` 변수에 `Animal.Tiger`를 할당하고 값을 출력하세요.
`if` 문으로 `Animal.Tiger`인지 확인하여 "호랑이"를 출력하세요.

**실행 결과**

```
Tiger
호랑이
```

---

## 3. 열거형 항목에 특정 값 지정

`Color` 열거형의 Red, Green, Blue를 정수로 변환하여 출력하세요.
Red는 10, Green은 자동으로 11, Blue는 20으로 지정되어 있습니다.

**실행 결과**

```
Red: 10, Green: 11, Blue: 20
```

---

## 4. 기반 타입 지정

`SmallEnum`을 `byte` 기반으로 정의하고, 
`sizeof(SmallEnum)`으로 크기를 출력하세요.

**실행 결과**

```
1
```

---

## 5. Enum.GetNames - 열거형 이름 목록

`typeof(ConsoleColor)`를 사용하여 `Enum.GetNames`로 모든 색상 이름을 가져오고 출력하세요.

**실행 결과**

```
ConsoleColor 열거형의 색상들:
Black
DarkBlue
DarkGreen
DarkCyan
DarkRed
DarkMagenta
DarkYellow
Gray
DarkGray
Blue
Green
Cyan
Red
Magenta
Yellow
White
```

---

## 6. Enum.Parse - 문자열을 열거형으로 변환

문자열 `"Red"`를 `Enum.Parse`로 `ConsoleColor`로 변환하세요.
`Console.ForegroundColor`에 설정하여 "빨간색 텍스트"를 출력한 후, 
`Console.ResetColor()`로 복원하고 "기본 색상 텍스트"를 출력하세요.

**실행 결과**

```
빨간색 텍스트
기본 색상 텍스트
```

---

## 7. Enum.TryParse - 안전한 문자열 변환

문자열 `"Up"`을 `Enum.TryParse`로 `Direction`으로 변환하고 결과를 출력하세요.
존재하지 않는 값 `"Forward"`도 변환을 시도하여 실패 메시지를 출력하세요.

**실행 결과**

```
변환 성공: Up
'Forward'은(는) 유효하지 않은 값
```

---

## 8. Enum.IsDefined - 값 유효성 검사

`Enum.IsDefined`로 정수 1이 유효한 
`Animal` 값인지, 100이 유효한 값인지, 
문자열 "Tiger"가 유효한 값인지 각각 확인하여 출력하세요.

**실행 결과**

```
1은 유효한 Animal 값인가? True
100은 유효한 Animal 값인가? False
'Tiger'는 유효한 Animal 값인가? True
```

---

## 9. 열거형과 정수 간 변환

`Direction.Right`를 정수로 변환하여 출력하세요.
정수 2를 `Direction`으로 변환하여 출력하세요.

**실행 결과**

```
Right = 3
2 = Left
```

---

## 10. 정의되지 않은 정수를 열거형으로 변환

정의되지 않은 정수 100을 `Animal`로 캐스팅하고 출력하세요.
컴파일 오류 없이 숫자 그대로 출력되는 것을 확인하세요.

**실행 결과**

```
100
```
