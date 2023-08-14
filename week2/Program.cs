namespace week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int itemCount = 5;
            int hp = 9;
            String itemName = "HP 포션";
            /* if/ else if/ else
            if (hp > 9)
            {
                Console.WriteLine($"HP가 최대입니다\n현재 HP : {hp}");
            }
            else if (itemCount > 0)
            {
                Console.WriteLine("{0}가 {1}개 남았습니다", itemName, --itemCount);
            }
            else
            {
                Console.WriteLine($"{itemName}이 없습니다");
            }

            string itemType = "Weapon";
            int itemLevel = 3;
            
            if (itemType == "Weapon")
            {
                if(itemLevel == 1)
                {
                    Console.WriteLine("공격력이 10 증가했습니다.");
                }
                else if (itemLevel == 2)
                {
                    Console.WriteLine("공격력이 20 증가했습니다.");
                }
                else
                {
                    Console.WriteLine("잘못된 아이템 레벨입니다.");
                }
            }else if (itemType == "Armor")
            {
                if (itemLevel == 1)
                {
                    Console.WriteLine("방어력이 10 증가했습니다.");
                }
                else if (itemLevel == 2)
                {
                    Console.WriteLine("방어력이 20 증가했습니다.");
                }
                else
                {
                    Console.WriteLine("잘못된 아이템 레벨입니다.");
                }
            }else
            {
                Console.WriteLine("잘못된 아이템 종류입니다.");
            }
            */

            /* switch사용
            switch (itemType)
            {
                case "Weapon":
                    Console.WriteLine("무기입니다");
                    break;
                case "Armor":
                    Console.WriteLine("방어구입니다");
                    break;
                default:
                    break;
            }
            */


        }
    }
}