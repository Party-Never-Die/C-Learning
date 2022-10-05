using System;

namespace 基础班第四天代码
{
    class 基础班第四天代码
    {
        static void Main(string[] args)
        {

            /*
            //异常捕获
            //try { } catch { }
            bool b = true;
            int number = 0;
            Console.WriteLine("请输入一个数字");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            //中间不能有代码
            catch 
            {
                Console.WriteLine("输入的内容不能转化为数字");//如123sds
                b = false;
            }
            if (b)
            {
                Console.WriteLine("输出2倍为：{0}",number*2);
                //能正常转换的数字才会乘二倍，否则输出不能转换为数字。
            
            }
            Console.ReadKey();


            
            //范至冬的年终工作评定，如果为A级，则工资涨500
            //如果为B级，则工资涨200 如果为C级，则工资不变
            //如果为d级，则工资减200 如果为d级，则工资减500
            //if else
            Console.WriteLine("请输入范志冬的年总评定");
            string eva = Console.ReadLine();
            //评价evaluation、assess、appraisal
            int salary = 5000;
            bool b= true;                                 
            //添加输出条件，否则在最后一种情况下仍会输出下一年工资内容
            if (eva == "A")
            {
                salary += 500;
            }
            else if(eva=="B")
            {
                salary += 200;
            }
            else if (eva == "C")
            {
                
            }
            else if (eva == "D")
            {
                salary -= 200;
            }
            else if (eva == "E")
            {
                salary -= 500;
            }
            else
            {
                Console.WriteLine("评价有误，请重新输入");
                b= false;
            }
            if (b)
            {
                Console.WriteLine("范至冬下一年的工资是{0}元", salary);
            }
            
            Console.ReadKey();
          


            //用switch--case实现上述问题
            Console.WriteLine("请输入范志冬的年总评定");
            string app = Console.ReadLine();
            //评价evaluation、assess、appraisal
            int money = 5000;
            bool b = true;
            switch (app)
            {
                case ("A"): money += 500;
                    break;
                case ("B"):
                    money += 200;
                    break;
                case ("C"):
                    break;
                case ("D"):
                    money -= 200;
                    break;
                case ("E"):
                    money -= 500;
                    break;
                default:
                    b = false;
                    break;
            }
            if (b)
            {
                Console.WriteLine("范至冬下一年的工资是{0}元", money);
            }
            Console.ReadKey();

            
            
            //请用户输入年份，再输入月份，通过年月输出该月的天数；
            Console.WriteLine("请输入年份");
            try
            {

                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    if (month >= 1 && month <= 12)
                    {
                        int day = 0;
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                day = 31;
                                break;
                            case 2:
                                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("输入的月份有错误，退出");
                        Console.ReadKey();
                    }
                }//月份无错误的try
                catch
                {
                    Console.WriteLine("输入的月份有错误，退出");
                    Console.ReadKey();
                }
            }//年份无错误的try
            catch
            {
                Console.WriteLine("输入的年份有错误，退出");
                Console.ReadKey();
            }
            


            //循环结构
            //while循环
            int i = 0;
            while (i < 5)
            {
                ++i;
                Console.WriteLine("范至冬是ds");

            }
            Console.ReadKey();

            
            //累加1-100
            int i = 1, sum = 0;
            while (i <= 100)
            {
                
                sum += i;
                i++;             //注意i++的位置，在sum上一行会多加100
            }
            Console.WriteLine("1-100的总和是：{0}",sum);
            Console.ReadKey();

            
            //1-100之间偶数的和
            int i = 2, sum = 0;
            if (i % 2 != 0)//如果是基数则加一，如果是偶数则进入循环
            {
                i++;
            }   
            while (i%2==0&&i<=100)
            {
               sum += i;
               i+=2;
            }
            Console.WriteLine("偶数和为{0}",sum);
            Console.ReadKey();
          

            //输入班级人数，然后依次输入人员成绩，计算班级的平均成绩与总成绩
            double allscore=0,time=1,score=0;
            Console.WriteLine("请输入班级人数");
            int people = Convert.ToInt32(Console.ReadLine());
            //循环体是人数，与成绩所以应该提前给出，平均成绩可以用总成绩除不用再单独给出
            //题目问总成绩所以需要单独声明变量
            while(time<=people)                                   //循环次数
            {
                Console.WriteLine("请输入成绩");            
                score=Convert.ToDouble(Console.ReadLine());       //讲成绩转为double类型
                allscore += score;                                //累加成绩
                time++;
            }
            Console.WriteLine("班级的平均成绩是{0}，总成绩是{1}",allscore/people,allscore);
            Console.ReadKey();

              
            //老师问学生，这道题会做吗，如果会做则放学
            //若不会做，则老师再讲一遍问是否会做，若不会做，再讲再文，问10次，超过十次也要放学
            int time = 1;
            while (true)
            {
                Console.WriteLine("这道题了会吗");                //回答yes/no
                if (Console.ReadLine() == "yes"||time>=10)       //直接进入循环，直到回答yes或超过10次
                {                                                //退出循环
                    Console.WriteLine("可以回家了");
                    break;
                }
                else                                             //否则老师再讲一遍
                {
                    Console.WriteLine("我再讲一遍");
                }
                time++;                                          //循环次数加一
            }
            Console.ReadKey();



            


            //2006年培养学生80000人，每年增长25%，问哪一年培养学生超过20万
            int year = 2006;
            double person = 8;
            while (true)
            {
                person *= 1.25;                                 //直接进入循环直到20W人退出
                year++;
                if (person >= 20)
                {
                    break;
                }

            }
            Console.WriteLine("超过20万人的年数是{0}",year);
            Console.ReadKey();
            


            //提示用户输入yes或者no，否则一直循环，直到输入yes或no
            while (true)
            {
                Console.WriteLine("请输入yes或no");
                string yn = Console.ReadLine();      
                if (yn == "yes" ||yn == "no")        //if (console.readline()== "yes" ||console.readline() == "no")
                {                                    //此时若直接判断，会使console.readline()执行两次
                    break;                           //跳出当前循环
                }
            }

            

            //提示用户输入用户名与密码 用户名：admin 密码：8888
            //只要用户名与密码有一个错误则重新输入
            //只能输入三次，超过三次，提示账户锁定
            int time = 1;
            while (time <= 3)                                        //循环次数不能超过3次
            {
                Console.WriteLine("请输入用户名");       
                string name = Console.ReadLine();
                if (name == "admin")                                 //账号不相同则直接退出，重新输入账户名
                {
                    Console.WriteLine("请输入密码");                  //相同则输入密码
                    string password = Console.ReadLine();
                    if (password == "8888")       
                    {
                        Console.WriteLine("登陆成功");                //密码正确，跳出循环
                        Console.ReadKey();
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("密码错误");                //密码错误则重新输入账户密码
                    }
                }
                else
                {
                    Console.WriteLine("用户名错误");
                }
                time++;                                              //循环次数累加
            }
            if (time > 3)
            {
                Console.WriteLine("输入错误超过三次，账户锁定！");

            }

          



            //写两个循环
            //第一个循环提示用户A输入用户名 要求A的用户名不能为空，若为空则重新输入
            //第二个循环提示用户B输入用户名 要求B的用户名不能为空，若为空则重新输入 且不能与A的用户名相同
            string name_a = "", name_b = "";        
            while (true)
            {
                Console.WriteLine("a请输入用户名");
                name_a = Console.ReadLine();                                         //本题目需要a b用户名做比较所以需要先声明字符串变量
                if (name_a == "")
                {
                    Console.WriteLine("用户名不能为空，请重新输入");                    //用户名为空，重新输入
                }
                else
                {
                    Console.WriteLine("用户a注册成功，您的用户名为{0}:", name_a);       //用户a注册成功
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("b请输入用户名");
                name_b = Console.ReadLine();
                if (name_b == "")
                {
                    Console.WriteLine("用户名不能为空，请重新输入");                    //用户名为空，重新输入
                }
                else if (name_b == name_a)
                {
                    Console.WriteLine("用户名不能重复，请重新输入");                    //用户名不能相同，重新输入
                }
                else
                {
                    Console.WriteLine("用户b注册成功，您的用户名为{0}:", name_b);       //用户b注册成功
                    break;
                }
            }
            Console.ReadKey();


            
           

            //do-while循环
            //不断要求用户输入一个数字，然后打印这个数字的二倍   直到用户输入Q 程序退出
            string abc = "";
            do
            {
                Console.WriteLine("请输入一数字,输入Q退出程序");
                abc=Console.ReadLine();
                if (abc != "Q")                                       //判断是否进入循环
                {
                    try                                               //输入字符串会出现程序异常，因此添加try catch避免
                    {
                        Console.WriteLine("这个数字的二倍是：{0}", Convert.ToDouble(abc) * 2);
                    }
                    catch                                             //输入的不为数字，提示重新输入
                    {
                        Console.WriteLine("输入的数字格式有错，请重新输入");
                    }
                }


            }
            while (abc!="Q");                                         //循环条件是不能与Q相同
             



            //要求用户不断输入一个数字（假定为正整数），则用户输入end时候显示刚才输入的数字的最大值
            //循环条件是输入不为end
            double max = 0, read = 0;
            string input = "";
            do
            {
                Console.WriteLine("请输入一个数字,输入end结束");
                input = Console.ReadLine();
                if (input != "end")
                {
                    try
                    {
                        read = Convert.ToDouble(input);
                        if (max < read)
                        {
                            max = read;
                        }
                    }
                    catch                                             //输入的不为数字，提示重新输入
                    {
                            Console.WriteLine("输入的数字格式有错，请重新输入");
                    }

                }
            }
            while (input != "end");
            Console.WriteLine("这些输入中最大的是：{0}", max);
            Console.ReadKey();




            
            //continue
            //用while与contiune实现计算1-100之间除了能被7整除之外所有整数的和
            int i = 1,sum=0;
            while (i <= 100)                 
            {
                if (i % 7 == 0)
                {
                    i++;                            //若没有i++则程序一直在while循环；
                    continue;
                }

                    sum += i;
                    i++;
            }
            Console.WriteLine("除能被7整除之外的和为：{0}",sum);
            Console.ReadKey();

            */



        }
    }
}
