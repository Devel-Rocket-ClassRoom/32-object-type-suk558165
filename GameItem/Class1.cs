using System;
using System.Collections.Generic;
using System.Text;

// 1. 기본 Item 클래스
class Item
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Item(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Name = {Name}, Price = {Price}";
    }
}

// 2. Weapon 클래스 (Item 상속)
class Weapon : Item
{
    public int Damage { get; set; }

    public Weapon(string name, int price, int damage) : base(name, price)
    {
        Damage = damage;
    }

    public override string ToString()
    {
        return $"Weapon {{ {base.ToString()}, Damage = {Damage} }}";
    }
}

// 3. Potion 클래스 (Item 상속)
class Potion : Item
{
    public int HealAmount { get; set; }

    public Potion(string name, int price, int healAmount) : base(name, price)
    {
        HealAmount = healAmount;
    }

    public override string ToString()
    {
        return $"Potion {{ {base.ToString()}, HealAmount = {HealAmount} }}";
    }
}

// 4. Inventory 클래스
class Inventory
{
    private object[] items = new object[10];
    private int count = 0;

    public void AddItem(object item)
    {
        if (count < items.Length)
        {
            items[count++] = item;
        }
        else
        {
            Console.WriteLine("인벤토리가 가득 찼습니다.");
        }
    }

    public void ShowInventory()
    {
        for (int i = 0; i < count; i++)
        {
            // object를 사용하더라도 재정의(override)된 ToString()이 호출됩니다.
            Console.WriteLine($"슬롯 {i + 1}: {items[i]} [{items[i].GetType().Name}]");
        }
    }
}
