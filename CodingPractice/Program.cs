using System;

//## 1. object 타입의 기본 개념
//object obj1 = 42;
//object obj2 = 3.14;
//object obj3 = "Hello";
//object obj4 = true;
//object obj5 = new int[] { 1, 2, 3 };

//Console.WriteLine(obj1);
//Console.WriteLine(obj2);
//Console.WriteLine(obj3);
//Console.WriteLine(obj4);
//Console.WriteLine();

////## 2. object 타입의 활용
//Stack stack = new Stack();
//stack.Push("sausage");
//string s = (string)stack.Pop();
//Console.WriteLine(s);

//stack.Push(3);
//int three = (int)stack.Pop();
//Console.WriteLine(three);
//Console.WriteLine();

//### 3-1. 박싱
//int i = 1234;
//object o = i;
//Console.WriteLine(o);
//Console.WriteLine(o);
//정수형 변수 `i`에 1234를 저장하고, `object` 변수 `o`에 할당하여 박싱을 수행하세요. 박싱된 값을 출력합니다.


//### 3-2. 언박싱
//object o = 1234;
//int i = (int)o;
//Console.WriteLine(i);
//Console.WriteLine();



//### 4-1. 값 타입을 object에 할당
//int i = 42;
//object boxed = i; // 박싱
//Console.WriteLine(boxed);
//Console.WriteLine();

//### 4-2. 값 타입을 인터페이스 타입에 할당
//Point p = new Point { X = 10, Y = 20 };
//IDisplayable d = p; // 박싱
//Console.WriteLine(d.GetType().Name);
//Console.WriteLine();
////## 5. 박싱의 특징
//int i = 3;
//object boxed = i; // 박싱
//i = 5;
//Console.WriteLine($"원본: {i}");
//Console.WriteLine($"박싱된 값: {boxed}");
//Console.WriteLine();

//## 6. 언박싱 시 주의사항
//object boxed = 42;  // int 값이 박싱됨

//// 올바른 언박싱
//int i = (int)boxed;
//Console.WriteLine($"언박싱 성공: {i}");

//try
//{
//    long l = (long)boxed;  // 예외발생
//}
//catch (InvalidCastException)
//{
//    Console.WriteLine("잘못된 타입으로 언박싱 시도");
//}

//int temp = (int)boxed;   // 먼저 int로 언박싱
//long correct = temp;     // 그 다음 long으로 암시적 변환
//Console.WriteLine($"올바른 변환: {correct}");


//### 7-1. 박싱/언박싱 오버헤드 비교
//int sum1 = 0;
//for (int i = 0; i < 1000; i++)
//{
//    object boxed = i; // 박싱
//    sum1 += (int)boxed; // 언박싱
//}
//Console.WriteLine($"박싱 사용: {sum1}");
//int sum2 = 0;
//for (int i = 0; i < 1000; i++)
//{
//    sum2 += i; // 직접 처리
//}
//Console.WriteLine($"직접 처리: {sum2}");

//### 7-2. 제네릭으로 박싱 피하기
//GenericStack<int> intStack = new GenericStack<int>();
//intStack.Push(42);
//int value = intStack.Pop();
//Console.WriteLine(value);
////### 8-1. GetType() 메서드
//int i = 1234;
//string s = "안녕하세요";
//char c = 'A';
//double d = 3.14;
//object o = new object();

//Console.WriteLine(i.GetType());  // System.Int32
//Console.WriteLine(s.GetType());  // System.String
//Console.WriteLine(c.GetType());  // System.Char
//Console.WriteLine(d.GetType());  // System.Double
//Console.WriteLine(o.GetType());  // System.Object

//### 8-2. typeof 연산자
//Console.WriteLine(typeof(int));        // System.Int32
//Console.WriteLine(typeof(string));     // System.String
//Console.WriteLine(typeof(double));     // System.Double
////### 8-3. GetType()과 typeof() 비교
//Point p = new Point { X = 10, Y = 20 };

//Console.WriteLine(p.GetType().Name);             
//Console.WriteLine(typeof(Point).Name);          
//Console.WriteLine(p.GetType() == typeof(Point));
//Console.WriteLine(p.X.GetType().Name);            
//Console.WriteLine(p.Y.GetType().FullName);

//class point
//{
//    public int X;
//    public int Y;

//}
//### 9-1. 기본 동작
//int number = 42;
//double pi = 3.14;
//bool flag = true;

//Console.WriteLine(number.ToString());  
//Console.WriteLine(pi.ToString());      
//Console.WriteLine(flag.ToString());    


////### 9-2. ToString() 재정의하기
//Panda p = new Panda { Name = "Petey" };
//Console.WriteLine(p);        
//Console.WriteLine(p.ToString());  

////### 9-3. 더 상세한 ToString() 구현
//Player player = new Player { Name = "Hero", Level = 10, Health = 100 };
//Console.WriteLine(player);

////## 10. object 클래스의 멤버들
//string s1 = "Hello";
//string s2 = "Hello";
//string s3 = s1;

//Console.WriteLine($"s1.Equals(s2): {s1.Equals(s2)}");
//Console.WriteLine($"ReferenceEquals(s1, s2): {object.ReferenceEquals(s1, s2)}");
//Console.WriteLine($"ReferenceEquals(s1, s3): {object.ReferenceEquals(s1, s3)}");

//object obj1 = new object();
//object obj2 = new object();
//object obj3 = obj1;

//Console.WriteLine($"obj1.Equals(obj2): {obj1.Equals(obj2)}");
//Console.WriteLine($"ReferenceEquals(obj1, obj2): {object.ReferenceEquals(obj1, obj2)}");
//Console.WriteLine($"ReferenceEquals(obj1, obj3): {object.ReferenceEquals(obj1, obj3)}");



