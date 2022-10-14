using System;

namespace FlyingChess_FOR_FZD
{
    class Program
    {
        //静态字段模拟全局变量
        public static int[] Map = new int[100];
        //声明一个静态数组用来存储玩家A与玩家B的坐标
        public static int[] PlayerPose = new int[2];

        public static string[] PlayerName = new string[2];
        public   static bool[] Flags = new bool[2];//默认都为False
        static void Main(string[] args)
        {
            GameShow();
            #region 输入玩家姓名
            Console.WriteLine("请输入玩家A的姓名");
            PlayerName[0] = Console.ReadLine();
            while (PlayerName[0] == "")
            {
                Console.WriteLine("玩家A的姓名为空，请重新输入");
                PlayerName[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerName[1] = Console.ReadLine();
            while (PlayerName[1] == "" || PlayerName[0] == PlayerName[1])
            {

                if (PlayerName[1] == "")
                {

                    Console.WriteLine("玩家B的姓名为空，请重新输入");
                    PlayerName[1] = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("玩家B的姓名不能与A相同，请重新输入");
                    PlayerName[1] = Console.ReadLine();
                }
            }
            #endregion
            //玩家姓名输入完成后清屏
            Console.Clear();
            GameShow();
            Console.WriteLine("{0}的士兵用A来表示", PlayerName[0]);
            Console.WriteLine("{0}的士兵用B来表示", PlayerName[1]);
            InitailMap();
            DrawMap();
            //当玩家A与B没有一个人在终点时，两个玩家不停地去玩
            while (PlayerPose[0] < 99 && PlayerPose[1] < 99)
            {
                if (Flags[0] == false)
                {
                    PlayGames(0);
                }
                else 
                {
                    Flags[0] = false;

                }
                if (PlayerPose[0] == 99)
                {
                    Console.WriteLine("{0}是ds",PlayerName[0]);
                    break;
                }
                if (Flags[1] == false)
                {
                    PlayGames(1);
                }
                else
                {
                    Flags[1] = false;

                }
                if (PlayerPose[1] == 99)
                {
                    Console.WriteLine("{0}是ds", PlayerName[1]);
                    
                }
            }//while
            DS();
            Console.ReadKey(true);
        }
        /// <summary>
        /// 画游戏头
        /// </summary>

        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********FZDSDS********");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**********************");
            return;
        }

        /// <summary>
        /// 初始化地图
        /// </summary>
        /// 我用0表示普通,显示给用户就是 □  
        ///  ....1...幸运轮盘,显示组用户就◎
        ///  ....2...地雷,显示给用户就是 ☆ 
        ///  ....3...暂停,显示给用户就是 ▲     
        ///  ....4...时空隧道,显示组用户就 卐   
        public static void InitailMap()
        {
            int[] Lucyturn = { 6, 23, 40, 55, 69, 83 };

            for (int i = 0; i < Lucyturn.Length; i++)
            {
                Map[Lucyturn[i]] = 1;
            }
            int[] LandMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            for (int i = 0; i < LandMine.Length; i++)
            {
                Map[LandMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };
            for (int i = 0; i < pause.Length; i++)
            {
                Map[pause[i]] = 3;
            }
            int[] timetunnel = { 20, 25, 45, 63, 72, 88, 90 };
            for (int i = 0; i < timetunnel.Length; i++)
            {
                Map[timetunnel[i]] = 4;
            }
        }


        public static void DrawMap()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("图例：幸运轮盘◎   地雷：☆    暂停：▲   时空隧道：卐     ");
            //第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();//换行画
            //第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");

                }
                Console.Write(DrawStringMap(i));
                Console.WriteLine();
            }
            //第二横行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();//换行
            //第二竖行
            for (int i = 65; i < 70; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            //第三横行
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();//换行

        }//DrawMap方法括号



        /// <summary>
        /// 从画地图中抽象的一个方法
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>

        public static string DrawStringMap(int i)
        {
            string str = "";
            //如果玩家A与玩家B的坐标相同的,并且都在地图上，显示  <>
            if (PlayerPose[0] == PlayerPose[1] && PlayerPose[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                str = "<>";

            }
            else if (PlayerPose[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                str = "Ｂ";

            }
            else if (PlayerPose[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                str = "Ａ";


            }
            else
            {
                switch (Map[i])
                {

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "□";

                        break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("◎");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("☆");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("▲");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("卐");
                        break;
                }//switch括号

            }//if else if 括号
            return str;
        }//DrawStringMap方法括号

        
        /// <summary>
        /// 当玩家玩游戏时
        /// </summary>
        /// <param name="playerNumber"></param>
        public static void PlayGames(int playerNumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1,7);
            Console.WriteLine("{0}开始投掷骰子", PlayerName[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}投掷出{1}", PlayerName[playerNumber], rNumber);
            PlayerPose[playerNumber] += rNumber;
            ChangePose();
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", PlayerName[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", PlayerName[playerNumber]);
            Console.ReadKey(true);
            //玩家A有可能踩到了玩家B  时空隧道 地雷 暂停 幸运轮盘
            if (PlayerPose[playerNumber] == PlayerPose[1 - playerNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，退六格", PlayerPose[playerNumber], PlayerPose[1 - playerNumber]);
                PlayerPose[1 - playerNumber] -= 6;

                Console.ReadKey(true);
            }
            else
            {
                switch (Map[PlayerPose[playerNumber]])
                {
                    case 0:
                        Console.WriteLine("{0}踩到了方框很安全", PlayerName[playerNumber]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("{0}踩到了幸运轮盘，请选择你的要求1--交换位置  2--轰炸对方退六格", PlayerName[playerNumber]);
                        string str = Console.ReadLine();
                        while (true)
                        {

                            if (str == "1")
                            {
                                Console.WriteLine("{0}与{1}交换位置", PlayerName[playerNumber], PlayerName[1 - playerNumber]);
                                Console.ReadKey(true);
                                int temp = PlayerPose[1 - playerNumber];
                                PlayerPose[1 - playerNumber] = PlayerPose[playerNumber];
                                PlayerPose[playerNumber] = temp;
                                Console.WriteLine("{0}与{1}交换位置成功", PlayerName[playerNumber], PlayerName[1 - playerNumber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else if (str == "2")
                            {
                                Console.WriteLine("{0}轰炸{1}退六格", PlayerName[playerNumber], PlayerName[1 - playerNumber]);
                                Console.ReadKey(true);
                                PlayerPose[1] -= 6;
                                Console.WriteLine("{0}轰炸{1}成功", PlayerName[playerNumber], PlayerName[1 - playerNumber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("输入的格式有误，请重新输入1--交换位置  2--轰炸对方退六格");
                                str = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("{0}踩到了地雷，退六格", PlayerName[playerNumber]);
                        PlayerPose[playerNumber] -= 6;
                        break;
                    case 3:
                        Console.WriteLine("{0}踩到了暂停，暂停一回合", PlayerName[playerNumber]);
                        Flags[playerNumber]= true;

                        break;
                    case 4:
                        Console.WriteLine("{0}踩到了时空隧道，前进十格", PlayerName[playerNumber]);
                        PlayerPose[playerNumber] += 10;
                        break;
                    default:
                        break;
                }
            }
            ChangePose();
            Console.Clear();
            DrawMap();
        }

        /// <summary>
        /// 当玩家坐标发生改变时候
        /// </summary>
        public static void ChangePose()
        {
            if (PlayerPose[0] < 0)
            {
                PlayerPose[0] = 0;

            }
            if (PlayerPose[0] >99)
            {
                PlayerPose[0] = 99;
            }
            if (PlayerPose[1] < 0)
            {
                PlayerPose[1] = 0;

            }
            if (PlayerPose[1] > 99)
            {
                PlayerPose[1] = 99;
            }



        }
        /// <summary>
        /// 胜利图标范至冬是屌丝
        /// </summary>
        public static void DS()
        {
            Console.WriteLine("范至冬是屌丝");
            for (int i = 0, m = 1; i < 30; i++)
           

                    for (int l = 0; l < new[] { 5, 6, 7, 6, 8, 10, 3, 10, 4, 13, 1, 13, 1, 87, 1, 27, 4, 23, 7, 20, 11, 16, 16, 11, 20, 7, 24, 3, 27, 1 }[i]; l++, m++)

                        System.Console.Write((i % 2 > 0 ? "FZDsds"[m % 4] : ' ') + (m % 29 > 0 ? "" : "\n"));

                Console.ReadLine();
        }
    }
    



}


















