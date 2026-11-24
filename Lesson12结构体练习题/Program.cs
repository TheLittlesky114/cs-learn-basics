using System.Numerics;

namespace Lesson12结构体练习题
{
    struct Student
    {
        public string name;
        public string sex;
        public int age;
        public int studentClass;
        public string major;
        public Student(string name, int age, string sex, int studentClass, string major)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.studentClass = studentClass;
            this.major = major;
        }
        public void Speak()
        {
            Console.WriteLine("我是{0}，我只有{1}岁，我是{2}生，我在{3}班，我的专业是{4}", name, age, sex, studentClass, major);
        }
    }

    struct Rectangle
    {
        public int length;
        public int width;
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public void Speak()
        {
            Console.WriteLine("矩形的长是：{0}，宽是：{1}，面积是{2}，周长是{3}", length, width, length * width, (length + width) * 2);
        }
    }

    struct PlayerInfo
    {
        public string name;
        public E_Occupation occupation;
        public PlayerInfo(string name, E_Occupation occupation)
        {
            this.name = name;
            this.occupation = occupation;
        }
        public void Speak()
        {
            string o = "", s = "";
            switch (occupation)
            {
                case E_Occupation.Warrior:
                    o = "战士";
                    s = "冲锋";
                    break;
                case E_Occupation.Hunter:
                    o = "猎人";
                    s = "假死";
                    break;
                case E_Occupation.Master:
                    o = "法师";
                    s = "奥术冲击";
                    break;
                default:
                    Console.WriteLine("请输入正确的职业");
                    break;
            }
            Console.WriteLine("{0}{1}释放了{2}", o, name, s);
        }
    }
    enum E_Occupation
    {
        Warrior,
        Hunter,
        Master,
    }

    struct Monster
    {
        public int atk;
        public string name;
        public Monster(string name)
        {
            this.name = name;
            Random r = new Random();
            atk = r.Next(10, 30);
        }
        public void Atk()
        {
            Console.WriteLine("{0}的攻击力是{1}", name, atk);
        }
    }

    struct UltraMan
    {
        public string name;
        public int atk;
        public int def;
        public int hp;
        public UltraMan(string name,int atk,int def,int hp)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
        }
        //结构体是值类型 想要在函数内部改变值类型信息 外部受影响 一定 记住 用 ref或out
        public void Atk(ref Boss monster)
        {
            monster.hp -= atk - monster.def;
            Console.WriteLine("{0}攻击了{1}，造成了{2}伤害，{3}剩余血量{4}", name, monster.name, atk - monster.def, monster.name, monster.hp);
        }
    }
    struct Boss
    {
        public string name;
        public int atk;
        public int def;
        public int hp;
        public Boss(string name, int atk, int def, int hp)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
        }
        public void Atk(ref UltraMan ultraMan)
        {
            ultraMan.hp -= atk - ultraMan.def;
            Console.WriteLine("{0}攻击了{1}，造成了{2}伤害，{3}剩余血量{4}", name, ultraMan.name, atk - ultraMan.def, ultraMan.name, ultraMan.hp);

        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("若叶睦", 2, "女", 2, "导弹维修");
            s1.Speak();
            Student s2 = new Student("小空", 18, "男", 2, "数字媒体技术");
            s2.Speak();

            //private私有的，只能在内部访问；public公开的，外部可以访问

            Rectangle rectangle = new Rectangle(20, 10);
            rectangle.Speak();

            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的职业(0.战士 1.猎人 2.法师)");
            try
            {
                E_Occupation o = (E_Occupation)int.Parse(Console.ReadLine());
                PlayerInfo info = new PlayerInfo(name, o);
                info.Speak();
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }

            Monster[] monsters = new Monster[10];
            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i] = new Monster("小怪兽" + i);
                monsters[i].Atk();
            }

            UltraMan ultraMan = new UltraMan("雷欧奥特曼", 10, 5, 100);
            Boss boss = new Boss("哥斯拉", 8, 4, 100);
            while (true)
            {
                ultraMan.Atk(ref boss);
                if (boss.hp <= 0)
                {
                    Console.WriteLine("{0}胜利", ultraMan.name);
                    break;
                }
                boss.Atk(ref ultraMan);
                if (ultraMan.hp <= 0)
                {
                    Console.WriteLine("{0}胜利", boss.name);
                    break;
                }
                Console.WriteLine("按任意键继续");
                Console.ReadKey(true);
            }
        }
    }
}
