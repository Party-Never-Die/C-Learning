using System;

namespace 基础班第三天代码
{
    class 基础班第三天代码
    {
        static void Main(string[] args)
        {
            /*
            

            //类型转换（两种类型不兼容）convert
            string s = "12345";
            double d = Convert.ToDouble(s);
            //将字符串类型s，转换为double类型；
            int i = Convert.ToInt32(s);
            //将字符串类型s，转换为int类型；
            Console.WriteLine(d);
            Console.WriteLine(i);
            Console.ReadKey();

           

            //让用户输入姓名 语文 数学 英语三门的成绩
            //然后给用户显示：xx你的总成绩为x分，平均成绩为x分。
            Console.WriteLine("请输入你的名字");    
            //提示用户输入姓名     
            string name = Console.ReadLine();
            //读取用户的名字存在name变量内
            Console.WriteLine("语文成绩是");       
            //提示用户输入语文成绩
            double chinese = Convert.ToDouble(Console.ReadLine());
            //将用户输入的字符串形式的语文成绩转换为double类型
            Console.WriteLine("数学成绩是");
            //提示用户输入数学成绩
            double math = Convert.ToDouble(Console.ReadLine());
            //将用户输入的字符串形式的数学成绩转换为double类型
            Console.WriteLine("英语成绩是");
            //提示用户输入英语成绩
            double english = Convert.ToDouble(Console.ReadLine());
            //将用户输入的字符串形式的英语成绩转换为double类型
            Console.WriteLine("{0}，你的总成绩是{1}分，平均成绩是{2}",name,chinese+math+english, (chinese + math+english)/3);
            //给用户显示：xx你的总成绩为x分，平均成绩为x分。
             

            //int32类型的输出形式
            Console.WriteLine("请输入你的名字");
            string name_1 = Console.ReadLine();
            Console.WriteLine("语文成绩是");
            double chinese_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("数学成绩是");
            double math_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("英语成绩是");
            double english_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}，你的总成绩是{1}分，平均成绩是{2}", name_1, chinese_1 + math_1 + english_1, (chinese_1 + math_1 + english_1) / 3);
          

          

            //提示用户输入一个数字 接收 并向控制台打印用户输入这个数字的二倍
            Console.WriteLine("请输入一个数字");
            //提示用户输入一个数字
            double b = Convert.ToDouble(Console.ReadLine());
            //将用户输入的数字转换为double类型，并储存在变量b中。
            b = 2 * b;
            //将数字变为原来的两倍
            Console.WriteLine("这个数字的二倍是：{0}",b);
            //向用户输出数字的两倍
            Console.ReadKey();
            //等待

          


            //算术运算符--，++
            int i = 10, n = 10;
            int result = i++ * 2;
            int result_1 = ++n * 2;
            Console.WriteLine("输出i++*2的结果:{0}\n输出++n*2的结果:{1}", result, result_1);
            //++:分为前++和后++,不管是前++还是后++,最终的结果都是给这个变量加一。 
            //区别表现表达式当中,如果是前++,则先给这个变量自身加一,然后带着这个加一后的值去参与运算。 
            //如果是后++,则先拿原值参与运算,运算完成后,再讲这个变量自身加一。
            //--:同上。
            Console.ReadKey();

              
            //举例说明
            int a = 5;
            int c = a++ + ++a * 2 + --a + a++;
            //      5   +  7  * 2 + 6   +  6 =31   a=7;
            Console.WriteLine("输出a最后的结果：{0}\n输出b最后的结果：{1}",a,c);
            Console.ReadKey();
            

            //关系运算符 < > <= >= == != 与布尔类型 bool(输出true或false)
            //举例39<18 20==20
            bool b = 39 < 18;
            //将39<18的返回值放入布尔类型b中
            bool b_1 = 20 == 20;
            //将20==20的返回值放入布尔类型b_1中
            Console.WriteLine("{0}\n{1}",b,b_1);
            //输出b，b_1
            Console.ReadKey();

            

            //逻辑运算符&&  ||  ！（布尔类型）
            //举例范至冬的语文与数学成绩都大于90


            Console.WriteLine("请输入你的语文成绩");
            double chinese = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入你的数学成绩");
            double math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(math > 90 && chinese > 90);
            Console.ReadKey();


          


            //复合运算类型+= -= *= /=

            //顺序结构、分支结构、循环结构

            //编程实现如果学习的时间超过60分钟，那么就下课(if--else)
            Console.WriteLine("你现在学习的时间是");
            int time = Convert.ToInt32(Console.ReadLine());
            if (time > 60)
            {
                Console.WriteLine("可以下课了");


            }
            else 
            {
                Console.WriteLine("请继续卷");

            }
               
            Console.ReadKey();
             


            //对范至冬的成绩进行评价
            //>=90:A  >=80:B >=70:C >=60:D <60:E
            Console.WriteLine("请输入你的成绩");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("你的成绩是A");
            }
            else
            {
                if (score >= 80)
                {
                    Console.WriteLine("你的成绩是B");
                }
                else
                {
                    if (score >= 70)
                    {
                        Console.WriteLine("你的成绩是C");
                    }
                    else
                    {

                        if (score >= 60)
                        {
                            Console.WriteLine("你的成绩是D");
                        }
                        else
                        {
                            Console.WriteLine("你的成绩是F");

                        }


                    }


                }

            }            
            Console.ReadKey();

             


            //提示用户比较三个数的大小，并输出三者
            Console.WriteLine("情输入第一个数");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("情输入第二个数");
            int mid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("情输入第三个数");
            int min = Convert.ToInt32(Console.ReadLine()),other;
            //比大小，排列组合为A33或A32 结果一样为6也就是说有6种情况
            //如果按max来分析 max最大有两种情况 mid>min 或 mid<min;
            //max在中间有两种情况 mid最大 或 min最大 
            //max最小也有两种情况 mid最大 或 min最大 
            if (max > mid && mid > min)                      //max最大则不需要改变
            {
            }
            else
            {
                if (max > mid && max < min)                  //min>max>mid
                {
                    other = mid;
                    mid = max;
                    max = min;
                    min = other;
                }
                else
                {
                    if (max < mid && max > min)              //mid>max>min
                    {
                        other = mid;
                        mid = max;
                        max = other;
                    }

                    else
                    {
                        if (max > min && mid < min)          //min>mid>max
                        {
                            other = mid;
                            mid = min;
                            min = other;
                        }
                        else
                        {
                            if (max < mid && mid < min)      //min>mid>max
                            {
                                other = max;
                                max = min;
                                min = other;
                            }
                            else
                            {
                                if (min < mid && max < min)  //mid>min>max
                                {
                                    other = max;
                                    max = mid;
                                    mid = min;
                                    min = other;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("{0}>{1}>{2}",max,mid,min);
            Console.ReadKey();

              


            //提示用户输入密码，如果密码是8888，则输出密码正确，登陆成功
            //否则输出：密码错误，程序结束
            Console.WriteLine("请输入密码");
            string secret = Console.ReadLine();
            if (secret == "8888")
            {
                Console.WriteLine("密码正确，登陆成功");
            }
            else
            {
                Console.WriteLine("密码错误，程序结束");
            }
            Console.ReadKey();

            
            //提示用户输入用户名与密码，如果输入的用户名不正确则输出：用户名不存在
            //如果用户名正确，密码不正确则输出：密码错误
            //如果用户名密码都正确则输出：成功登录
            //(用户名：admin  密码： 8888)
            //解题思路：分四类讨论，2的平方=4，都正确 都不正确 两者任一正确

            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string key = Console.ReadLine();
            if (name == "admin" && key == "8888")                     //都正确
            {
                Console.WriteLine("成功登录");
            }
            else if (key == "8888")                                   //密码正确
            {
                Console.WriteLine("用户名错误");
            }
            else if (name == "admin")                                 //用户名正确
            {
                Console.WriteLine("密码错误");
            }
            else 
            {
                Console.WriteLine("用户名与密码都错误，程序退出");      //都不正确
            }
            Console.ReadKey();
           

            //提示用户输入年龄如果大于18，则告知用户可以查看；如果小于10岁，则告知不允许查看；
            //如果大于10且小于18岁，则询问用户是否继续查看
            //用户输入yes则提示： 用户请查看 
            //用户输入no 则提示： 退出
            //题目按照时间轴分为3个阶段，其中中间阶段又有一次判断，共有四种分类

            Console.WriteLine("请输入你的年龄");
            int age = Convert.ToInt32(Console.ReadLine());                   //将字符串转换为int类型
            if (age >= 18)
            {
                Console.WriteLine("用户可以查看");                            //大于18岁的情况
            }
            else if (age >= 10)
            {
                Console.WriteLine("用户是否继续查看");                        //10-18岁的判断
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("用户请查看");
                }
                else
                {
                    Console.WriteLine("退出");
                }
            }
            else                                                             //小于18岁的情况
            { 
                Console.WriteLine("用户不可以查看");
            }
            Console.ReadKey();


             */












        }
    }
}
