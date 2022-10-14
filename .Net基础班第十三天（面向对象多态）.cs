//.Net基础班第十三天(面向对象多态)

// 1.c#中的访问修饰符 
// public :公开的公共的 
// private:私有的,只能在当前类的内部访问 
// protected:受保护的,只能在当前类的内部以及该类的子类中访问。 
// internal:只能在当前项目中访问。在同一个项目中,internal和public的权限是一样。 
// protected internal:protected+internal

// 1).能够修饰类的访问修饰符只有两个:public.internal。
//(类的默认访问是internal)
// 2).可访问性不一致。 子类的访问权限不能高于父类的访问权限,会暴漏父类的成员

// 2.设计模式 
// 设计这个项目的一种方式。


// 3.简单工厂设计模式
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您想要的笔记本品牌");
            string brand = Console.ReadLine();
            NoteBook nb = GetNoteBook(brand);
            nb.SayHello();
            Console.ReadKey();
        }


        /// <summary>
        /// 简单工厂的核心 根据用户的输入创建对象赋值给父类
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "Lenovo": nb = new Lenovo();
                    break;
                case "IBM": nb = new IBM();
                    break;
                case "Acer": nb = new Acer();
                    break;
                case "Dell": nb = new Dell();
                    break;
            }
            return nb;
        }
    }

    public abstract class NoteBook
    {
        public abstract void SayHello();
    }

    public class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本,你联想也别想");
        }
    }


    public class Acer : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是鸿基笔记本");
        }
    }

    public class Dell : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔笔记本");
        }
    }

    public class IBM : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是IBM笔记本");
        }
    }
}

//4.值传递和引用传递
// 值类型在复制的时候,传递的是这个值得本身。    
// 引用类型在复制的时候,传递的是对这个对象的引用。 


// 5.序列化和反序列化
// 序列化:就是将对象转换为二进制    
// 反序列化:就是将二进制转换为对象    
// 作用:传输数据。   

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace _05序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //要将p这个对象 传输给对方电脑
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 19;
            //p.Gender = '男';
            //using (FileStream fsWrite = 
            //new FileStream(@"C:\Users\SpringRain\Desktop\111.txt", 
            //               FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    //开始序列化对象
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);
            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey();

            //接收对方发送过来的二进制 反序列化成对象
            Person p;
            using (FileStream fsRead = 
                   new FileStream(@"C:\Users\SpringRain\Desktop\111.txt", 
                                  FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
            Console.ReadKey();
        }
    }


    [Serializable]
    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}

//6.partial部分类
    public partial class Person
    {      
        public virtual void Hello()
        {
            Console.WriteLine("hello Person");
        }
    }

    public partial class Person
    {
        public virtual void Study()
        {
            Console.WriteLine("hello Person");
        }
    }


// 7.sealed
// sealed密封类,不能够被其他类继承,但是可以继承于其他类。
    public sealed class Person
    {      
        public void Hello()
        {
            Console.WriteLine("hello Person");
        }
    }

// 针对重写的成员,可以使用sealed关键字把它“密封”起来,防止它被其他子类重写
// public sealed override decimal Liability {get {return Mortgage;}}


// 8.接口 
// [public] interface I..able {  成员; }            
// 1)接口是一种规范。 只要一个类继承了一个接口,这个类就必须实现这个接口中所有的成员
// 为了多态。 接口不能被实例化。 也就是说,接口不能new(不能创建对象)。
// 接口的成员都是隐式抽象抽象的。
// 2)接口中的成员不能加“访问修饰符”,接口中的成员访问修饰符为public,不能修改。
// (默认为public) 接口中的成员不能有任何实现(“光说不做”,
// 只是定义了一组未实现的成员)。
// 3)接口中只能有方法.属性.索引器.事件,不能有“字段”和构造函数。
// 4)接口与接口之间可以继承,并且可以多继承。
// 接口并不能去继承一个类,而类可以继承接口  
// (接口只能继承于接口,而类既可以继承接口,也可以继承类)
// 实现接口的子类必须实现该接口的全部成员。
// 一个类可以同时继承一个类并实现多个接口,
// 如果一个子类同时继承了父类A,并实现了接口IA,那么语法上A必须写在IA的前面。
// class MyClass:A,IA{},因为类是单继承的。
// 当一个抽象类实现接口的时候,需要子类去实现接口。

//接口的实现

//接口
public interface IEnumerator 
{
    bool MoveNext();
    object Current();
    void Reset();
}
//实现
public class Countdown : IEnumerator 
{
    int count = 11;
    public bool MoveNext() => count-- > 0;
    object Current() => count;
    void Reset() { throw  new NotSupportedException(); }
}

//接口和对象的转换
public interface IFoo 
{
    void DO();
}

public class Parent : IFoo 
{
    public void DO() => Console.WriteLine("Parent");
}

public class Program
{
    public static void Main(string[] agrs)
    {
        IFoo  f = new Parent();
        f.Do();	//Parent
    }
}

//如果Cuoutdown是一个internal的class,但是可以通过把它的实例转化成IEnumerator
//接口来公共访问它的成员

//程序集1
public interface IFoo 
{
    void DO();
}

internal class MyClass : IFoo
{
    public void DO() => Console.WriteLine("MyClass");
}

public class MyTool
{
    public static object GetMyClass() => new MyClass();
}

//程序集2
public class Program
{
    public static void Main(string[] args)
    {
        object obj = MyTool.GetMyClass();
        IFoo  foo = obj as IFoo;
        foo?.Do(); //MyClass
    }
}

//接口的扩展
//接口可以继承其他接口
//IRedoable继承了IUndoable的所有成员
public interface IUndoable { void Undo();}
public interface IRedoable : IUndoable { void Redo();}

//显示接口的实现
//第一种情况:如果实现的两个接口中方法完全一样,实现一个就可以了

public interface IFoo
{
    void DO();
}

public interface IBar
{
    void DO();
}

public class Parent : IFoo,Ibar
{
    public void Do() => Console.WriteLine("Parent");
}

public class Program
{
        public static void Main(string[] args)
    {
        Parent p = new Parent();
        IFoo f = p;
        IBar b = p;
        f.Do();//Parent
        b.Do();//Parent
    }
}



//第二种情况:如果实现的两个接口中方法不完全一样,需要显示实现
public interface IFoo
{
    void DO();
}

public interface IBar
{
    int DO();
}

public class Parent : IFoo,Ibar
{
    public void Do() => Console.WriteLine("Foo");
    
    int IBar.Do()
    {
        Console.Write("Bar")
        return 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Parent p = new Parent();
        p.Do();//Foo
        
        ((IBar)p).Do();//Bar
        ((Foo)p).Do();//Foo
    }
}
// 显示实现接口的目的:解决方法的重名问题 ；故意隐藏那些对于类型来说不常用的成员
// 显式接口实现没有访问修饰符,因为它不能作为其定义类型的成员进行访问。
// 而只能在通过接口实例调用时访问。
// 什么时候显示的去实现接口:
// 当继承和接口中的方法和参数一摸一样的时候,要使用显示的实现接口

//实现显示接口
    public interface IFlyable
    {
        void Fly();
    }
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Bird的飞");
        }
        void IFlyable.Fly()
        {
            Console.WriteLine("接口飞");
        }
    }
    public class Program
    {
        public static void Main()
        {
            IFlyable flyable = new Bird();
            flyable.Fly();//接口飞
            Bird bird = new Bird();
            bird.Fly();//Bird的飞
        } 
    }


// virtual的实现接口成员



//隐式实现的接口成员是sealed
//如果想要进行重写的话,必须在基类中把成员标记为virtual或abstract

//例1:
public interface IFoo
{
    void Do();
}

public class Parent : IFoo
{
    public void Do() => Console.WriteLine("Parent");
}

public class Child : Parent
{
    public void Do() => Console.WriteLine("Child");
}

public class Program
{
    public static void Main()
    {
        Child c = new Child();
        c.Do();				//Child
        ((Parent)c).Do();	//Parent
        ((IFoo)c).Do();		//Parent
    } 
}
    


//例2:
public interface IFoo
{
    void Do();
}

public class Parent : IFoo
{
    public virtual void Do() => Console.WriteLine("Parent");
}

public class Child : Parent
{
    public override void Do() => Console.WriteLine("Child");
}

public class Program
{
    public static void Main()
    {
        Child c = new Child();
        c.Do();				//Child
        ((Parent)c).Do();	//Child
        ((IFoo)c).Do();		//Child
        
        Parent p = new Parent();
        p.Do();				//Parent
        ((IFoo)p).Do();		//Parent
    } 
}


//显示实现的接口成员不可以被标记为virtual,
//也不可以通过寻常的方式来重写,但是可以对其进行重新实现

//例3:
public interface IFoo
{
    void Do();
}

public class Parent : IFoo
{
    void IFoo.Do() => Console.WriteLine("Parent");
}

public class Child : Parent
{
    public void Do() => Console.WriteLine("Child");
}

public class Program
{
    public static void Main()
    {
        Child c = new Child();
        c.Do();				//Child
        ((IFoo)c).Do();		//Parent        
    } 
}

//例4:
public interface IFoo
{
    void Do();
}

public class Parent : IFoo
{
    void IFoo.Do() => Console.WriteLine("Parent");
}

public class Child : Parent, IFoo
{
    public void Do() => Console.WriteLine("Child");
}

public class Program
{
    public static void Main()
    {
        Child c = new Child();
        c.Do();				//Child
        ((IFoo)c).Do();		//Child        
    } 
}

//例5:
public interface IFoo
{
    void Do();
}

public class Parent : IFoo
{
    public void Do() => Console.WriteLine("Parent");
}

public class Child : Parent, IFoo
{
    public void Do() => Console.WriteLine("Child");
}

public class Program
{
    public static void Main()
    {
        Child c = new Child();
        c.Do();				//Child
        ((IFoo)c).Do();		//Child       
        ((Parent)c).Do();	//Parent     
    } 
}


//重新实现接口的替代方案

//即使显示实现的接口,接口的重新实现也可能有一些问题:
//1.子类无法调用基类的方法
//2.基类的开发人员没有预见到方法会被重新实现,并且可能不允许潜在的后果

//最好的办法是设计一个无需重新实现的基类
//1.隐式实现接口成员的时候,按需标记virtual
//2.显示实现接口成员的时候,可以这样做:
public class TextBox : IUndoable
{
    void IUndoable.Do()  => Undo();
    protected virtual void Undo()  =>  Console.WriteLine("TextBox");
}

public class RichTextBox : IUndoable
{
    protected override void Undo()  =>  Console.WriteLine("RichTextBox");
}

//如果不想有子类,那么直接把class给sealed


// 9.类中默认的访问权限是private
// 10.自动属性和普通属性
// 写法上有区别,本质上没有区别,反编译后是一样的

    public  class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Age { get; set; }
    }

// 11.base关键字
// base和this略像,base主要用于:
// 从子类访问父类里被重写的函数
// 调用父类的构造函数

//这种写法可保证,访问的一定是Asset的Liability属性,
//无论该属性是被重写还是被隐藏了
public class House : Asset
{
    public override decimal Liablity => base.Liablity + Mortgage;
}
