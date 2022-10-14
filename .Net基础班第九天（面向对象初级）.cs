// .Net基础班第九天（面向对象初级
// 1.面向过程-----> 面向对象
// 面向过程:面向的是完成这件事儿的过程,强调的是完成这件事儿的动作。
// 面向对象:找个对象帮你做事儿
// 我们把这些具有相同属性和相同方法的对象进行进一步的封装,抽象出来类这个概念。 
// 类就是个模子,确定了对象应该具有的属性和方法。 
// 对象是根据类创建出来的。 类就是一个盖大楼的图纸   对象就是盖出来的大楼。
// 2.类 
// 语法: [public] class 类名 
// {  
// 字段;  
// 属性;  
// 方法; 
// }
// 写好了一个类之后,我们需要创建这个类的对象,
// 那么,我们管创建这个类的对象过程称之为类的实例化。 
// 使用关键字 new.
// this:表示当前这个类的对象。 
// 类是不占内存的,而对象是占内存的。

// 获取类型的默认值
Person p = default(Person);
    public class Program
    {        
        public static void Main()
        {
            Person person = new Person();
            person.Name = "张三";
            person.Age = -10;
            person.Test();
            Console.ReadKey();
        }
    }

    public class Person
    {

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        private int _age;
        public int Age
        {
            get{ return _age; }
            set{ 
                    if(value < 0)
                    {
                        value = 0;
                    }
                    _age = value;
                }
        }
        private string _address;

        public void Test()
        {
            Console.WriteLine("hello");
        }   
    }
// 3.属性 
// 属性的作用就是保护字段.对字段的赋值和取值进行限定。 
// 属性的本质就是两个方法,一个叫get()一个叫set()。 
// 既有get()也有set()我们称之为可读可写属性。
// 只有set()我们称之为只读属性 ,
// 没有get()只有set()我们称之为只写属性
// Field字段		Method方法		Property属性

// 4.访问修饰符 
// public:公开的公共的,在哪都能访问。 
// private:私有的,只能在当前类的内部进行访问,出了这个类就访问不到了。

// 5.对象的初始化
// 当我们创建好一个类的对象后,需要给这个对象的每个属性去赋值。
// 我们管这个过程称之为对象的初始化。

// 6.静态和非静态的区别 
// 1).在非静态类中,既可以有实例成员,也可以有静态成员。 
// 2).在调用实例成员的时候,需要使用对象名.实例成员; 
// 在调用静态成员的时候,需要使用类名.静态成员名; 
//     静态成员必须使用类名去调用,而实例成员使用对象名调用。    
//     静态函数中,只能访问静态成员,不允许访问实例成员。       
// 实例函数中,既可以使用静态成员,也可以使用实例成员。       
// 静态类中只允许有静态成员,不允许出现实例成员。
// 使用:
//  1).如果你想要你的类当做一个"工具类"去使用,这个时候可以考虑将类写成静态的。 
//  2).静态类在整个项目中资源共享。 
//  只有在程序全部结束之后,静态类才会释放资源。

// 堆	栈	静态存储区域
// 释放资源。GC Garbage Collection垃圾回收器
    public class Program
    {        
        public static void Main()
        {
            Person person = new Person();
            Person.Name = "张三";   
            person.Age = 18;
            person.Test();
            Console.ReadKey();
        }
      
    }

    public class Person
    {

        private static  string  _name;
        public static string Name
        {
            get { return Person._name; }
            set { Person._name = value; }
        }
        private  int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        

        public void Test()
        {
            Console.WriteLine("hello");
        }

        public static  void Test2()
        {
            Console.WriteLine("hello");
        }
    }
// 7.构造函数 
// 作用:帮助我们初始化对象(给对象的每个属性依次的赋值) 
// 构造函数是一个特殊的方法: 
// 1).构造函数没有返回值,连void也不能写。 
// 2).构造函数的名称必须跟类名一样。
// 创建对象的时候会执行构造函数 构造函数是可以有重载的。
//  *** 类当中会有一个默认的无参数的构造函数,当你写一个新的构造函数之后,
//  不管是有参数的还是无参数的,那个默认的无参数的构造函数都被干掉了。 

// 构造函数和字段的初始化顺序
// 字段的初始化发生在构造函数之前
// 字段按照声明的先后顺序进行初始化

//expression-bodiesd
//C#7之后,允许单语句的构造函数写成expression-bodiesd成员的形式
public class Panda
{
    string name;
    
    public Panda(string n) => name = n;
}

//构造函数复用
//当同一个类型的下的构造函数A调用构造函数B的时候,B先执行

public class Wine
{
    public decimal Price;
    public int Year;
    public Wine (decimal price)
    {
        Price = price;
    }
    
    public Wine (decimal price,int year):this(price)
    {
        Year = year;
    }
}

// 8.new关键字 
// Person zsPerson=new Person(); 
// new帮助我们做了3件事儿: 
// 1).在内存中开辟一块空间 
// 2).在开辟的空间中创建对象 
// 3).调用对象的构造函数进行初始化对象
// 9.this关键字 
// 1).代表当前类的对象 
// 2).在类当中显示的调用本类的构造函数  :this

// 10.析构函数(在程序结束的时候执行)
// this与析构函数
public class Student
    {
        ~Student()
        {
            Console.WriteLine("我是析构函数");
        }

        public Student(string name,int age,string address)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }

        public Student(string name,int age) : this(name, age, "中国")
        {
            this.Name = name;
            this.Age = age;
        }

        public string _name;
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        private int _age;
        public int Age
        {
            set { _age = value; }
            get { return _age; }
        }

        public string _address;
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
    }

// 11.deconstructor
// C#7 引入了deconstructor模式,作用基本和构造函数相反,
// 它会把字段反赋值给一堆变量
//Person类
public class Person
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public string State { get; set; }

    public Person(string fname, string mname, string lname,
                  string cityName, string stateName)
    {
        FirstName = fname;
        MiddleName = mname;
        LastName = lname;
        City = cityName;
        State = stateName;
    }

    // Return the first and last name.
    public void Deconstruct(out string fname, out string lname)
    {
        fname = FirstName;
        lname = LastName;
    }

    public void Deconstruct(out string fname, out string mname, out string lname)
    {
        fname = FirstName;
        mname = MiddleName;
        lname = LastName;
    }

    public void Deconstruct(out string fname, out string lname,
                            out string city, out string state)
    {
        fname = FirstName;
        lname = LastName;
        city = City;
        state = State;
    }
}

//使用
public class Program
{
    public static void Main()
    {
        var p = new Person("John", "Quincy", "Adams", "Boston", "MA");

        // Deconstruct the person object.
        
        //第一种方式
        //(string fName,string lName,string city,string state) = p;
        
        //第二种方式
    //string fName,lName,city,state;
    //p.Deconstruct(out string fName,out string lName,out string city,out string state);
       
        //第三种方式
        var (fName, lName, city, state) = p;
        Console.WriteLine($"Hello {fName} {lName} of {city}, {state}!");
    }
}