namespace Lesson1枚举练习题
{
    /// <summary>
    /// QQ状态枚举
    /// </summary>
    enum E_QQStatus 
    {
        /// <summary>
        /// 在线状态
        /// </summary>
        Online,
        Offline,
    }

    enum E_Size
    {
        Middle,
        Large,
        SuperLarge,
    }

    enum E_Sex
    {
        Man,
        Woman,
    }
    enum E_Career
    {
        Warrior,
        Hunter,
        Mage,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 练习题一
            //try
            //{
            //    Console.WriteLine("请输入QQ状态（0.在线 1.离线）");
            //    int status = int.Parse(Console.ReadLine());
            //    E_QQStatus qqStatus = (E_QQStatus)status;
            //    Console.WriteLine(qqStatus);
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}
            #endregion

            #region 练习题二
            //try
            //{
            //    Console.WriteLine("请选择要购买的类型（0.中杯（35元）1.大杯（40元）2.超大杯（43元））");
            //    int size = int.Parse(Console.ReadLine());
            //    E_Size size1 = (E_Size)size;
            //    switch (size1)
            //    {
            //        case E_Size.Middle:
            //            Console.WriteLine("你购买了中杯咖啡，花费了35元");
            //            break;
            //        case E_Size.Large:
            //            Console.WriteLine("你购买了大杯咖啡，花费了40元");
            //            break;
            //        case E_Size.SuperLarge:
            //            Console.WriteLine("你购买了超大杯咖啡，花费了43元");
            //            break;
            //        default:
            //            Console.WriteLine("请输入正确类型");
            //            break;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}
            #endregion

            #region 练习题三
            int atk = 0, def = 0;
            E_Sex sex = 0;
            E_Career career = 0;
            bool isQuitWhile = false;
            string skill = "", sexChinese = "", careerChinese = "";
            while (true)
            {
                try
                {
                    isQuitWhile = false;
                    Console.WriteLine("请选择英雄性别（0.男性 1.女性）");
                    sex = (E_Sex)int.Parse(Console.ReadLine());
                    switch (sex)
                    {
                        case E_Sex.Man:
                            atk += 50;
                            def += 100;
                            sexChinese = "男";
                            isQuitWhile = true;
                            break;
                        case E_Sex.Woman:
                            atk += 150;
                            def += 20;
                            sexChinese = "女";
                            isQuitWhile = true;
                            break;
                        default:
                            Console.WriteLine("请输入正确类型");
                            break;
                    }
                    if (isQuitWhile)
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("请输入数字");
                }
                
            }
            while (true)
            {
                try
                {
                    isQuitWhile = false;
                    Console.WriteLine("请输入职业（0.战士 1.猎人 2.法师）");
                    career = (E_Career)int.Parse(Console.ReadLine());
                    switch (career)
                    {
                        case E_Career.Warrior:
                            atk += 20;
                            def += 100;
                            skill = "冲锋";
                            careerChinese = "战士";
                            isQuitWhile = true;
                            break;
                        case E_Career.Hunter:
                            atk += 120;
                            def += 30;
                            skill = "假死";
                            careerChinese = "猎人";
                            isQuitWhile = true;
                            break;
                        case E_Career.Mage:
                            atk += 200;
                            def += 10;
                            skill = "奥术冲击";
                            careerChinese = "法师";
                            isQuitWhile = true;
                            break;
                        default:
                            Console.WriteLine("请输入正确类型");
                            break;
                    }
                    if (isQuitWhile)
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("请输入数字");
                }
            }
            Console.WriteLine("你选择了“{0}性{1}”，攻击力：{2}，防御力：{3}，职业技能：{4}", sexChinese, careerChinese, atk, def, skill);
            #endregion
        }
    }
}
