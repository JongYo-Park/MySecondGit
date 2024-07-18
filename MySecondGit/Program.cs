namespace MySecondGit
{
    internal class Program
    {
        struct Player
        {   
            public string name;
            public int level;
        }
        struct Monster
        {
            public string name;
            public int hp;
        }
        enum ItemType { Weapon, Armor, Usable }
        struct Item
        {
            public string name;
            public ItemType type;
        }
        static void Main(string[] args)
        {
            Player player = new Player() { name = "용사", level = 1 };
            Monster monster = new Monster() { name = "고블린", hp = 500 };
            Item item = new Item() { name = "포션", type = ItemType.Usable };
        }
    }
}
