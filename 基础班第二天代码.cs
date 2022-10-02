using System;

namespace _08_两个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //取消注释ctrl + k ctrl + u
            //取消闪烁编辑insert

            string name = "卡卡西";
            int age = 21;
            string email = "11596457@qq.com";
            string address = "石家庄";
            decimal salary = 5000m;


            //占位符实现；
            Console.WriteLine("我叫{0},今年{1},我的QQ邮箱是{2},籍贯是{3},工资是{4}", name, age, email, address, salary);
            Console.ReadKey();


            //正常字符串加内容连接实现；
            Console.WriteLine("我叫" + name + ",今年" + age + ",我的邮箱地址是" + email + ",我的家庭地址是" + address + "，我的工资是" + salary);
            Console.ReadKey();


            //课后题
            //定义4个变量，分别储存一个人的姓名、性别（Gender）、年龄、电话
            //（TelephoneNumber）。然后打印在电脑上（我叫X,我今年X岁了，我是X生，）
            //我的电话是XX，（电话号类型010 - 12345）


            string name_2 = "范至冬";
            string Gender = "女生";
            int age_2 = 21;
            int TelephoneNumber = 01012345;
            Console.WriteLine("我叫{0},性别{1}，今年{2}，电话号码是{3}",name_2,Gender,age_2,TelephoneNumber);
            Console.ReadKey();


            //交换变量
            int n1 = 10;
            int n2 = 20;
            int trans = n1;
            n1 = n2;
            n2 = trans;
            Console.WriteLine("{0}，{1}",n1,n2);
            Console.ReadKey();

            //范至冬是ds, 我也是
            Console.WriteLine("范至冬是");
            string name_3 = Console.ReadLine();
            Console.WriteLine("这么巧啊，徐慧明、李晨、李鸡山也是{0}", name_3);
            Console.ReadKey();


            //练习：问用户喜欢吃什么水果 ？  回答：这么巧啊，我也爱吃某某。
            Console.WriteLine("这么巧啊，我也爱吃{0}", Console.ReadLine());
            Console.ReadKey();



            //练习：请用户输入姓名、性别、年龄，并在屏幕上显示：“您好：XX您的年龄是XX，是个X生。”
            Console.WriteLine("请输入你的名字");
            string name_3 = Console.ReadLine();
            Console.WriteLine("请输入你的年龄");
            string age_3 = Console.ReadLine();
            Console.WriteLine("请输入你的性别");
            string gender_2 = Console.ReadLine();
            Console.WriteLine("您好，{0}您的年龄是{1}，是个{2}生", name_3, age_3, gender_2);
            Console.ReadKey();


            //转义符
            Console.WriteLine("今天学习\nC#");//  \n代表换行；
            Console.WriteLine("我想在这句话中加\"一个英文半角的双引号\""); // \" 加入双引号；
            Console.WriteLine("这里是想加一个Tab\t啦啦啦"); // \t 代表加入多个空格；
            Console.WriteLine("这里是加入了back \b啦啦啦"); // \b back代表加入一个退格键；
            Console.WriteLine("\b啦啦啦\b");//但是\b在字符串行首尾无效；
            Console.WriteLine("你好啊\r\n你好吗");//回车换行；
            Console.WriteLine("\\你好");// 两个\\代表一个\；
            //string path = "F:\学习\a\b\c\d\e\f\csharp.mp4";//会提示错误;
            string path = "F:\\学习\\a\\b\\c\\d\\e\\f\\csharp.mp4";
            Console.WriteLine(path);
            string path_1 = @"F:\学习\a\b\c\d\e\f\csharp.mp4";
            Console.WriteLine(path_1);//取消\在字符串中的转义作用，使其单纯的表示为一个\
                                      //将字符串按照编辑的原格式输出
            

            //算数运算符 + — / %
            int n1 = 10;
            int n2 = 3;
            int result = n1 / n2;
            Console.WriteLine(result);
            Console.ReadKey();//int是整数类型结果只会有整数，不会带小数点。
            


            //演示：某三位学生的成绩为，语文：90，数学80，英语67，编程求总和与平均。
            int chinese = 90, math = 80, english = 67,sum,ave;
            sum = chinese + math + english;
            ave = sum / 3;
            Console.WriteLine("总成绩为{0}，平均成绩为{1}", sum, ave);
            Console.ReadKey();

            
            //或者直接表达
            int chinese_1 = 90, math_1 = 80, english_1 = 67;
            Console.WriteLine("总成绩为{0}，平均成绩为{1}", chinese_1+math_1+english_1, (chinese_1 + math_1 + english_1)/3);
            Console.ReadKey();
            

            //练习：计算半径为5的圆的面积和周长，并打印出来（pi=3.14）
            double r=5,pi=3.14,s,c;     //定义
            s = pi * r * r;             //面积
            c=pi*r*2;                   //周长
            Console.WriteLine("圆的面积是{0}，周长是{1:0.00}",s,c);//对周长保留两位小数
            Console.ReadKey();
            

            //隐式转换（小类型转大类型--int转double）
            int number = 10;double n = 30.3,res;
            res = number / n;
            Console.WriteLine(res);//输出double类型的结果
            Console.ReadKey();

            
            //显示转换 语法：(待转换的类型)要转换的值;	
            //前提：类型相同（int-double、double-int）；
            double n3 = 30.3;
            int n4 = (int)n3;//将double类型的n3，转换为int类型并储存在n4；
            Console.WriteLine(n4);
            Console.ReadKey();
            */
        }
    }
}
