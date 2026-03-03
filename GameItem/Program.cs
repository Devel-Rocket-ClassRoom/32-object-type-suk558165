using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 인벤토리 시스템 테스트 ===\n");

        Inventory inven = new Inventory();

        // 아이템 생성 및 추가
        Weapon sword = new Weapon("불꽃 검", 500, 25);
        inven.AddItem(sword);
        inven.AddItem(new Weapon("얼음 활", 450, 20));
        inven.AddItem(new Potion("체력 물약", 50, 100));
        inven.AddItem(new Potion("마나 물약", 80, 50));

        Console.WriteLine("[인벤토리 내용]");
        inven.ShowInventory();

        Console.WriteLine("\n=== 타입 확인 테스트 ===");
        Console.WriteLine($"sword의 타입: {sword.GetType().Name}");

        // GetType() vs typeof() 비교
        // GetType()은 런타임의 실제 인스턴스 타입을, typeof()는 클래스 자체의 타입을 반환합니다.
        Console.WriteLine($"sword.GetType() == typeof(Weapon): {sword.GetType() == typeof(Weapon)}");
        Console.WriteLine($"sword.GetType() == typeof(Item): {sword.GetType() == typeof(Item)}");

        // is 연산자는 상속 관계(다형성)를 포함하여 확인합니다.
        Console.WriteLine($"sword is Item: {sword is Item}");
    }
}
