//.Net基础班第十天(面向对象继承)

//1.命名空间
可以认为类是属于命名空间的。
如果在当前项目里没有这个类的命名空间,需要我们手动的导入这个类所在的命名空间。
使用命名空间的三种方式
1).用鼠标去点
2).alt+shift+F10
3).记住命名空间,手动的去引用


//2.在一个项目中引用另一个项目的类
1)添加引用
2)应用命名空间


//3.值类型和引用类型
区别：
1)值类型和引用类型在内存上存储的位置不同
2)在传递值类型和传递引用引用类型的时候,传递的方式不一样
值类型我们称之为值传递,引用类型我们称之为引用传递
值类型：int.double.decmimal.bool.struct.enum.char
引用类型：string.自定义类.数组
值类型是存储在内存的栈中。
引用类型存储在内存的堆中。


//4.字符串
1).字符串的不可变性
当你给一个字符串重新赋值之后,老值并没有销毁,而是重新开辟一块空间存储新值

当程序结束后,GC扫描整个内存,如果发现有的空间没有被指向,则立即把它销毁
2).我们可以将字符串看做是只读char类型的数组
TOCharArray();将字符串转化为char数组
new string(char[] chs);能够将char数组char数组转化为字符串
 public class Program
    {
        public static void Main()
        {
            string s = "abcdefg";
            char[] ch = s.ToCharArray();
            ch[0] = 'b';
            s = new string(ch);//最后s为"bbcdefg"
            Console.ReadKey();
        }

    }

//5.字符串提供的各种方法

//Length:获取当前字符串中字符的个数
    public class Program
    {
        public static void Main()
        {
            string s = "Hello World";
            Console.WriteLine(s.Length);
            Console.ReadKey();
        }

    }

//ToUpper():将字符串转换成大写形式
    public class Program
    {
        public static void Main()
        {
            string s = "Hello World";      
            Console.WriteLine(s.ToUpper());
            Console.ReadKey();
        }

    }
//ToLower():将字符串转换为小写形式
    public class Program
    {
        public static void Main()
        {
            string s = "Hello World";      
            Console.WriteLine(s.ToLower());
            Console.ReadKey();
        }

    }
//Equals(str,StringComparison.OrdinalIgnoreCase):
//比较两个字符串,在忽略大小写的情况下
    public class Program
    {
        public static void Main()
        {
            string s = "Hello World";
            string s1 = "helloWorld";
            Console.WriteLine(s.Equals(s1,StringComparison.OrdinalIgnoreCase));
            Console.ReadKey();
        }
    }
//Split();分割字符串,返回字符串类型的数组
public class Program
    {
        public static void Main()
        {
            string s = "Hello World , | +  = sajkfh o naf n";
            //将不想要的元素放在字符数组里
            char[] ch = { ',', '|', '+', '=',' ' };
            //StringSplitOptions.RemoveEmptyEntries这个参数是去除其中的空元素
            string[] strs = s.Split(ch,StringSplitOptions.RemoveEmptyEntries);
            Console.ReadKey();
        }
    }
//Substring():截取字符串,在截取的时候包含要截取的位置
    public class Program
    {
        public static void Main()
        {
            string s = "HelloWorld";
            s = s.Substring(1, 2);//第一个参数从指定的位置截取,包含指定的位置,第二个参数截取的长度
            s = s.Substring(0);//从指定的位置截取到末尾,包含指定的位置
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
//IndexOf():判断某个字符串在字符串中第一次出现的位置,如果没有返回-1
    public class Program
    {
        public static void Main()
        {
            string s = "HelloWorld";
            int i = s.IndexOf("l");//l第一次出现的位置
            int j = s.IndexOf("l",2);//从索引2开始(包括索引2),l第一次出现的位置
            Console.WriteLine(s); 
            Console.ReadKey();
        }
    }
//LastIndexOf():判断某个字符串在字符串中最后一次出现的位置,如果没有返回-1
    public class Program
    {
        public static void Main()
        {
            string s = "HelloWorld";
            int i = s.LastIndexOf("l");//l最后一次出现的位置
            Console.WriteLine(s); 
            Console.ReadKey();
        }
    }
//StartWith():判断以...开始--EndWith():判断以...结束
public class Program
    {
        public static void Main()
        {
            string s = "HelloWorld";
            bool b = s.StartsWith("H");
            bool b2 = s.EndsWith("l");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
//Replace():将字符串中某个字符串替换成一个新的字符串
//Contains():判断某个字符串是否包含指定的字符串
 public class Program
    {
        public static void Main()
        {
            string s = "机密任务";
            if (s.Contains("机密"))
            {
                s = s.Replace("机密", "**");
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
//Trim():去掉字符串中前后的空格
 public class Program
    {
        public static void Main()
        {
            string s = "     Hello     World         ";
            s = s.Trim();
            Console.WriteLine(s); 
            Console.ReadKey();
        }
    }
//TrimEnd():去掉字符串中结尾的空格
    public class Program
    {
        public static void Main()
        {
            string s = "     Hello     World         ";
            s = s.TrimEnd();
            Console.WriteLine(s); 
            Console.ReadKey();
        }
    }
//TrimStrart():去掉字符串中前面的空格
    public class Program
    {
        public static void Main()
        {
            string s = "     Hello     World         ";
            s = s.TrimStrart();
            Console.WriteLine(s); 
            Console.ReadKey();
        }
    }
//string.IsNullOrEmpty():判断一个字符串是否为Null或者为空
    public class Program
    {
        public static void Main()
        {
            string s = "     Hello     World         ";
            bool b = string.IsNullOrEmpty(s);
            Console.WriteLine(s); 
            Console.ReadKey();
        }
    }
//string.Join():将数组按照指定的字符串连接,返回一个字符串
    public class Program
    {
        public static void Main()
        {
            string[] strs = { "张三","李四","王五"};
            string s = string.Join("|", strs);//结果   "张三|李四|王五"
            Console.WriteLine(s); 
            Console.ReadKey();
        }
    }
//StringBuilder和计时器
public class Program
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            //创建了一个计时器
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);//输出计时时间
            Console.WriteLine(sb.ToString);
            Console.ReadKey();
        }
    }


//6.继承
我们可能会在一些类中,写一些重复的成员,我们可以将这些重复的成员,
单独的封装到一个类中,作为这些类的父类
Student.Teacher.Driver                    
子类    派生类
Person                                                   
父类   基类
子类继承了父类,那么子类从父类那里继承过来了什么？
首先,子类继承了父类的属性和方法,但是子类并没有继承父类的私有字段。
问题：子类有没有继承父类的构造函数？
答：子类并没有继承父类的构造函数,但是,子类会默认的调用父类无参的构造函数
在子类内部创建父类对象,让子类可以使用父类中的成员。
所以,如果在父类中重新写一个有参数的构造函数之后,那个无参数的构造函数就被干掉了,子类就调用不到了,所以会报错
解决方法(1)给父类添加一个无参构造
       (2)让子类显示的调用父类的构造函数,使用关键字base()
//关键字Base
       public class Person
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(int id,string name,int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
    }

    public class Student : Person
    {
        public string Hobby { get; set; }


        public Student(int id,string name,int age,string hobby):base(id,name,age)
        {
            this.Hobby = hobby;
        }
    } 
//继承过程中的执行顺序
//构造函数和字段初始化顺序

//对象实例化时,初始化动作按照如下顺序执行
//从子类到父类：
//字段被初始化
//父类构造函数的参数值被算出

//从父类到子类
//构造函数被执行

//举例如下
public class B 
{
    int x = 1;						//Executes 3rd
    public B (int x)				//Executes 4th
    {
        ...
    }
}

public class D : B
{
    int y = 1;						//Executes 1st						
    public D (int x)
    :base (x +1)					//Executes 2nd
    {
        ...							//Executes 5th
    }
}
//重构和解析
static void Foo(Asset a){}
static void Foo(House a){}

//重载方法被调用时,更具体的类型拥有更高的优先级
House h = new House(...);
Foo(h);                  //Calls Foo(House)

Asset a = new House(...);
Foo(a);					 //Calls Foo(Asset)	

//调用哪个方法是在编译时就确定下来的


//7.继承的特性
1)继承的单根性：一个子类只能有一个父类
2)继承的传递性

//8.new关键字
1)、创建对象
2)、隐藏从父类那里继承过来的同名成员
    public class Person
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(int id,string name,int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
        public void Hello()
        {
            Console.WriteLine("hello person");
        }
    }

    public class Student : Person
    {
        public string Hobby { get; set; }


        public Student(int id,string name,int age,string hobby):base(id,name,age)
        {
            this.Hobby = hobby;
        }

        public new  void Hello()
        {
            Console.WriteLine("hello student");
        }
    }


// 9.抽象类和抽象对象
// 使用abstract声明的类是抽象类
// 抽象类不可以被实例化，只有其具体的子类才可以被实例化
// 抽象类可以定义抽象成员
// 抽象成员和virtual成员很像，但是不提供具体的实现。
// 子类必须提供实现。除非子类也是抽象的。
//抽象类
public abstract class Asset
{
    // Note empty implementation (注意空实现)
    public abstract decimal NetValue{get;}
}

//实现类
public class Stock : Asset
{
    public long SharesOwned;
    public decimal CurrentPrice;
    
    // Override like a virtual method (像一个虚拟方法一样重写)
    public override decimal NetValue => CurrentPrice * SharesOwned;
}
// 隐藏被继承的成员
// 父类和子类可以定义相同的成员：
// class B中的Counter字段就隐藏了A里面的Counter字段
// （通常是偶然发生的）。例如子类添加某个字段之后，父类也添加了相同的一个字段。
// 编译器会发生警告
//父类
public class A 
{
    public int Counter = 1;
}

//子类
public class B : A
{
    public int Counter = 2;
}
// 按照如下规则进行解析：
// 编译是对A的引用会绑定到A.Counter
// 编译是对B的引用会绑定到B.Counter
//父类
public class A 
{
    public int Counter = 1;
}

//子类
public class B : A
{
    public int Counter = 2;
}

public class Program
{
    A a = new A();
    System.Console.WriteLine(a.Counter);// 1
    
    B b = new B();
    System.Console.WriteLine(b.Counter);// 2
    
    A x = new B();
    System.Console.WriteLine(x.Counter);// 1
}
// 如果想故意隐藏父类的成员，可以在子类的成员前面加上new 修饰符
// 这里的new 修饰符仅仅会抑制编译器的警告而已
//父类
public class A 
{
    public int Counter = 1;
}

//子类
public class B : A
{
    public new int Counter = 2;
}

//new和override
public class BaseClass
{
    public virtual void Foo() {Console.Write("BaseClass.Foo");}
}

public class Override : BaseClass
{
    public virtual void Foo() {Console.Write("Override.Foo");}
}

public class Hider : BaseClass
{
    public virtual void Foo() {Console.Write("Hider.Foo");}
}

publuc class Program
{
    public static void Main(string[] args)
    {
        Overrider over = new Overrider();
        BaseClass b1 = over;
        over.Foo();//Override.Foo
        b1.Foo();//Override.Foo
        
        Hider h = new Hider();
        BaseClass b2 = h;
        h.Foo();//Hider.Foo
        b2.Foo();//BaseClass.Foo
}
