using System;

using System;

class DataPrinter
{
    // static 메서드는 클래스 내부 어디서든 호출 가능하도록 위치 조정
    static void PrintData(object data)
    {
        // 
        switch (data)
        {
            case int i:
                Console.WriteLine($"정수: {i}");
                break;
            case string s:
                Console.WriteLine($"문자열: \"{s}\" (길이: {s.Length})");
                break;
            case double d:
                Console.WriteLine($"실수: {d:F2}");
                break;
            case bool b:
                Console.WriteLine($"논리값: {b} → {(b ? "참" : "거짓")}");
                break;
            default:
                Console.WriteLine($"알 수 없는 타입: {data?.GetType().Name ?? "null"}");
                break;
        }
    }

    public void PrintAll(object[] data)
    {
        foreach (var item in data)
        {
            PrintData(item);
        }
    }

    public void PrintStats(object[] data)
    {
        int intCount = 0, doubleCount = 0, stringCount = 0, boolCount = 0;

        foreach (var item in data)
        {
            if (item is int) intCount++;
            else if (item is double) doubleCount++;
            else if (item is string) stringCount++;
            else if (item is bool) boolCount++;
        }

        Console.WriteLine($"정수: {intCount}개");
        Console.WriteLine($"실수: {doubleCount}개");
        Console.WriteLine($"문자열: {stringCount}개");
        Console.WriteLine($"논리값: {boolCount}개");
    }

    static void Main(string[] args)
    {
        object[] data = { 42, 3.14, "Hello", true, 100, "World", false, 2.718 };
        DataPrinter printer = new DataPrinter();

        Console.WriteLine("=== 데이터 출력기 ===\n");

        Console.WriteLine("[전체 데이터 출력]");
        printer.PrintAll(data);

        Console.WriteLine("\n[타입별 통계]");
        printer.PrintStats(data);
    }
}






