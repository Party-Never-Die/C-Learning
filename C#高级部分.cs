// 高级部分

// 1.索引器
// C#中索引器是否只能根据数字进行索引？是否允许多个索引器参数？
// 答：不是只能根据数字索引，允许多个参数


// 2.扩展方法
// 1)扩展方法所在的类必须是static类
// 2)扩展方法的第一个参数类型是被拓展的类型，类型前面标注this
// 3)使用扩展方法的代码必须添加对拓展方法所在类namespace的using
// 4)扩展方法最终还是被编译器处理成普通静态方法的调用
// 5)扩展方法由于本质上还是静态方法的调用，所以不能访问类的外部访问不了的成员

//扩展方法
namespace System
{
    public static class StringExtend
    {
        public static string AppendString(this string str)
        {
            return str + "我被扩展了";
        }
    }
}


    public class Program
    {
        public static void Main(string[] args)
        {

            string s1 = "hello";
            string s2 = s1.AppendString();
            Console.WriteLine(s2);
        }
    }

// 3.CTS.CLS.CLR
// 1).Net平台下不只有C#语言，还有VB.Net.F#等语言。
// IL是程序最终编译的可以执行的二进制代码(托管代码)，
// 不同的语言最终都编译成标准的IL(中间语言，MSIL);
// 这样C#可以调用VB.Net写的程序集(Assembliy，dll，exe)。
// 在.Net平台下：不同语言之间可以互联互通.互相调用。
// 2)不同语言中的数据类型各不相同，比如整数类型再VB.Net中是Integer.C#中是int。
// .Net平台规定了通用数据类型(CTS，Commom Type System)，
// 各个语言编译器把自己语言的类型翻译成CTS中的类型。int是C#中的类型，
// Int32是CTS中的类型：int是C#的关键字，Int32不是。
// 3)不同语言的语法不一样，比如定义一个类A继承B的C#语法是class A:B{}，
// VB.Net的语法是Class A Inherits B。.Net平台规定了通用语法规范
// (CLS，Common Language Specification)
// 4)IL代码由公共语言运行时(CLR，Common Language Runtime)驱动运行，
// CLR提供了垃圾回收(GC，Garbage Collection)，
// 没有任何引用的对象可以被自动回收，分析什么时候可以回收.JIT(即时编译器)
// 5)值类型是放在“栈内存”中，引用类型放到“堆内存”，栈内存会方法结束后自动释放
// ，“堆内存”则需要GC来回收。

// 4.关于相等
// 1)查看判断两个对象是否是同一个对象要用：object.ReferenceEquals();

object.ReferenceEquals(p1, p2);
// 2)==比较的是两个对象是否是同一个引用，除非对==运算符进行运算重载，才能改变==号的作用
// 3)object的Equals方法也比较了两个变量是否指向同一个引用;
// 如果类override了Equals方法，就可以比较其中的内容了


// 5.委托
// 委托是一种数据类型，可以声明委托类型的变量。委托是一种可以指向方法的数据类型。
// 声明委托的方式：delegate 返回值类型	委托类型名(参数);
// 内置泛型委托Action(无返回值)和Func(有返回值)

//声明委托
delegate void MyDel(int n);

//创建委托对象和使用委托
    public class Program
    {
        public static void Main(string[] args)
        {
            MyDel d = new MyDel(NumPlus);//简化写法MyDel d = NumPlus;
            int n = d(1);
            Console.WriteLine(n);
        }
        public static int NumPlus(int n)
        {
            return n + 100;
        }
    }
    delegate int MyDel(int n);

// 6.匿名方法
// 使用Delegate的很多时候没必要使用一个普通的方法，
// 因为这个方法只有这个Delegate会用，并且只用一次，这个时候使用匿名方法最合适。

    public class Program
    {
        public static void Main(string[] args)
        {
            Action<int> a1 = delegate (int n)
            {
                Console.WriteLine(n+1);
            };
            a1(100);   
        }        
    }


// 7.lambda表达式

//Action写法
    public class Program
    {
        public static void Main(string[] args)
        {
            //匿名函数写法
            Action<int> a1 = delegate  (int i) { Console.WriteLine(i); };
            //lambda写法
            Action<int> a2 = (int i) => { Console.WriteLine(i); };
            //省略参数类型(编译器自动根据委托类型推断)
            Action<int> a3 = (i) => { Console.WriteLine(i); };
            //如果只有一个参数可以省略小括号
            Action<int> a4 = i => { Console.WriteLine(i); };
            //没有返回值，只有一行代码，省略{}
            Action<int> a5 = i => Console.WriteLine(i) ;
            a1(1);
            a2(2);
            a3(3);
            a4(4);
            a5(5);
        }        
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            //匿名函数写法
            Func<int, bool> f1 = delegate (int n){return true;};
            //lambda写法
            Func<int, bool> f2 =  (int n) => { return true; };
            //省略参数类型(编译器自动根据委托类型推断)
            Func<int, bool> f3 = (n) => { return true; };
            //如果只有一个参数可以省略小括号
            Func<int, bool> f4 = n => { return true; };
            //有返回值，只有一行代码，省略{}和return
            Func<int, bool> f5 = n =>  true;
            Console.WriteLine(f1(1));
            Console.WriteLine(f2(1));
            Console.WriteLine(f3(1));
            Console.WriteLine(f4(1));
            Console.WriteLine(f5(1));
        }        
    }

// 8.委托的组合
// 委托对象可以“+相加”，调用组合后的新委托对象会依次调用被组合起来的委托：
// MyDel  d4 =d1+d2+d3;
// 组合的委托必须是同一个委托类型
// 委托的“-”则是从组合委托中把委托移除
// 委托如果有返回值，则有一些特殊。委托的组合一般是给事件用的，用不同的委托的时候很少用


// 9.反射
// 1)反射简介
// .Net中的类都被编译成IL，反射就可以在运行时获得类的信息
// (有哪些方法.字段.构造函数.父类是什么等等)，还可以动态创建对象.调用成员。
// 每个类都对应一个Type对象，每个方法对应一个MethodInfo对象，
// 每个属性对应一个PropertInfo......。这些就是类.方法.属性的“元数据”。
// Type对象和这个类的对象没有直接关系。这些“元数据对象”和成员有关，和对象无关，
// 也就是每个成员对应一个对象。
// 2)类元数据Type
// 使用写好的Person类
// 获取类信息对象Type的方法：
// 从对象获取：Type type = person.GetType();
// 从类名获取：Type type = typeof(Person);
// 从全类名(命名空间+类名)获取：Type type = Type.GetType("com.rupeng.Person");
// Activator.CreateInstance(type)使用无参数构造方法创建此类的对象(如果没有无参构造函数会报异常)

//类元数据Type

namespace 类元数据
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();

            Type t1 = p1.GetType();
            Type t2 = typeof(Person);
            Type t3 = Type.GetType("类元数据.Person");

            object obj =  Activator.CreateInstance(t1);
            Person p2 = (Person)obj;
            Console.WriteLine(p2);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
        }
    }
    public class Person
    {
        public Person()
        {

        }
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayHi()
        {
            Console.WriteLine("测试反射");
        }
    }
}


// 3)Type的成员 
// IsInterface.IsArray.IsPrimitive.IsEnum：是否接口.数组.原始类型.枚举等
// string Name得到类名(不包括命名空间);string FullName 包含命名空间
// BaseType得到父类的类型Type
// Boolean IsInstanceOfType(Object obj)：
// 判断给定的对象obj是否是当前类类型的(可以是当前类的子类的对象)
// Boolean IsAssignableFrom(Type type)
// 半段type是否是当前类的类型或者当前类的子类类型。
// 或者说：type类型的对象能否赋值给当前类类型的变量。

//Type的成员
namespace Type的成员
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Type t1 = typeof(Person);//拿到的是Type的子类的对象System.RuntimeType
            Type t2 = t1.GetType();

            //获取父类
            Type t3 = t2.BaseType;

            //获取全名
            string fullname = t1.FullName;

            //获取类名
            string name = t1.Name;

            //是否是抽象类IsAbstract
            Type t4 = typeof(A);
            bool b1 = t4.IsAbstract;

            //是否是数组IsArray
            int[] nums = {1,2,3};
            Type t5 = nums.GetType();//Type t5 = typeof(int[]);
            bool b2 = t5.IsArray;

            //是否是枚举IsEnum
            Type t6 = typeof(Gender);
            bool b3 = t6.IsEnum;

            //    IsClass
            //    IsPublic
            //    IsSealed
            //    IsPrimitive
            //    IsValueType
            //    IsInterface

            //获取单个构造函数 GetConstructor(Type[] types)
            Type t7 = typeof(Person);
            ConstructorInfo c1 = t7.GetConstructor(new Type[0]);
            ConstructorInfo c2 = t7.GetConstructor(new Type[]{typeof(string), typeof(int)});

            //获取所有的构造函数GetConstructors()

            //获取所有的方法GetMethods
            MethodInfo[] methodes = t7.GetMethods();
            foreach (MethodInfo item in methodes)
            {
                //Console.WriteLine(item);
            }

            //获取单个方法,如果存在重载，使用GetMethod的重载方法
            MethodInfo m1 = t7.GetMethod("SayHi");


            //获取所有的属性GetProperties
            PropertyInfo[] props = t7.GetProperties();
            foreach (PropertyInfo item in props)
            {
                //Console.WriteLine(item);
            }

            //获取单个属性
            PropertyInfo prop = t7.GetProperty("Name");
            Console.WriteLine(prop);
        }
    }
    public enum Gender
    {

    }
    public abstract class A
    {
        public abstract string Name { get; }
    }
    public class Person
    {
        public Person()
        {

        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayHi()
        {
            Console.WriteLine("测试反射");
        }
    }
}


// 4)ConstructorInfo.MethodInfo.PropertyInfo
// 1)ConstructorInfo.MethodInfo.PropertyInfo的父类的主要成员以及各自的主要成员
// ConstructorInfo继承自MethodBase，MethodBase继承自MemberInfo
// MethodInfo继承自MethodBase
// PropertyInfo继承自MemberInfo
// (2)MemberInfo主要成员
// string Name
// object[] GetCustomAttributes(Type attributeType, bool inherit)
// (3)MethodBase主要成员
// IsAbstract
// IsPrivate
// IsStatic
// IsVirtual
// GetMethodBody()
// object Invoke(object obj,object[] parameters):调用这个方法
// (4)MethodInfo主要成员
// Type ReturnType:返回值的类型
// (5)ConstructorInfo主要成员
// object Invoke(object[] parameters):调用构造函数
// (6)PropertyInfo主要成员
// bool CanRead：是否可读
// bool CanWrite：是否可写
// Type PropertType：属性值的类型
// public object GetValue(Object obj)：获取obj对象的属性值
// void SetValue(object obj,object value)：给object对象的属性赋值


// ConstructorInfoMethodInfoPropertyInfo

namespace ConstructorInfoMethodInfoPropertyInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Type type = typeof(Person);
            object obj = Activator.CreateInstance(type);//new Person()
            PropertyInfo propName = type.GetProperty("Name");
            propName.SetValue(obj,"lipengchao");//object.Name ="lipengchao"
            PropertyInfo propAge = type.GetProperty("Age");
            propAge.SetValue(obj, 18);//object.Age =18

            MethodInfo methodSayHi = type.GetMethod("SayHi", new Type[0]);
            methodSayHi.Invoke(obj, new object[0]);//object.SayHi
        }
    }
    public class Person
    {        
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayHi()
        {
            Console.WriteLine("我是"+this.Name+",我的年龄是"+this.Age);
        }
    }
}



// 10.正则表达式(百度搜)
// 匹配内容或者提取内容


// 11.xml
// 1)简介
// xml优点：容易读懂;格式标准任何语言都内置了xml分析引擎，
// 不用单独进行文件分析引擎的编写。
// xml就是用一种格式化的方式来存储数据
// .net程序中的一些配置文件app.config.web.config文件都是xml文件
// xml语法规范：标签/节点(Tag/Node).嵌套(Nest).属性。标签要闭合，
// 属性值要用“”包围，标签可以互相嵌套
// xml树，父节点.子节点.兄弟节点
// xml编写完成以后可以用浏览器来查看，如果写错了浏览器会提示。
// 如果明明没错，浏览器还是提示错误，则可能是文件编码问题。


// 2)xml语法特点
// (1)严格区分大小写
// (2)有且只能有一个根节点
// (3)有开标签必须有结束标签，除非自闭和
// (4)属性必须使用双引号
// (5)文档声明：<?xml version="1.0" encoding="utf-8"?>
// (6)注释：<!--  -->
// (7)注意编码问题，文本文件实际编码要与文档声明中的编码一致


// 3)读取xml文件

//文件内容
<Person>
  <Student StuId = "11">
    <StuName>张三</StuName>
  </Student>
  
  
  <Student StuId = "22">
    <StuName>李四</StuName>
  </Student>
  
</Person>


//读取XML文件
namespace 读取xml文件
{
    public class Program
    {
        public static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            //加载文档
            doc.Load(@"E:\Desktop\test.xml");
            //doc.DocumentElement根节点
            //doc.DocumentElement.ChildNodes获取根节点的字节点
            XmlNodeList xmlNodeList = doc.DocumentElement.ChildNodes;
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                XmlElement xmlElement = (XmlElement)xmlNode;
                //获取该节点的属性
                string stuId = xmlElement.GetAttribute("StuId");
                //获取该节点的单个子节点
                XmlNode node = xmlElement.SelectSingleNode("StuName");
                //获取节点内的内容
                string name = node.InnerText;
                Console.WriteLine(stuId+","+ name);
            }
        }
    }
}

//生成XML文件
namespace 生成xml文件
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Person[] persons = new Person[] { new Person(1, "张三", 18), new Person(2, "李四", 20) };
            XmlDocument doc = new XmlDocument();
            XmlElement xmlpersons = doc.CreateElement("Persons");//创建Persons节点
            doc.AppendChild(xmlpersons);//将Persons节点作为文档的根节点
            foreach(Person person in persons)
            {
                XmlElement xmlPerson = doc.CreateElement("Person");//创建一个Person节点
                xmlPerson.SetAttribute("Id", person.Id.ToString());//给Person节点的Id属性赋值

                XmlElement xmlName = doc.CreateElement("Name");//创建一个Name节点
                xmlName.InnerText =person.Name;//给Name节点的内部内容赋值

                XmlElement xmlAge = doc.CreateElement("Age");//创建一个Age节点
                xmlAge.InnerText = person.Age.ToString();//给Age节点的内部内容赋值

                xmlPerson.AppendChild(xmlName);//给Person添加一个子节点Name
                xmlPerson.AppendChild(xmlAge);//给Person添加一个子节点Age

                xmlpersons.AppendChild(xmlPerson);//给Persons添加一个子节点Person
            }
            doc.Save(@"E:\Desktop\生成.xml");

        }
    }
    public class Person
    {
        public Person(int id,string name,int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

//生成xml
<Persons>
  <Person Id="1">
    <Name>张三</Name>
    <Age>18</Age>
  </Person>
  <Person Id="2">
    <Name>李四</Name>
    <Age>20</Age>
  </Person>
</Persons>