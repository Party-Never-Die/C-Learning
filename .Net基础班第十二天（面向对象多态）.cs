//.Net基础班第十二天（面向对象多态）


// 1.绝对路径和相对路径 
// 绝对路径：通过给定的这个路径直接能在我的电脑中找到这个文件。 
// 相对路径：文件相对于应用程序的路径。 
// 结论： 我们在开发中应该去尽量的使用相对路径。

// 2.List泛型集合
// 可以转换为数组
// list.ToArray
// 数组.ToList()
List<Person> list = new List<Person>();

// 3.装箱.拆箱 
// 装箱：就是将值类型转换为引用类型。
// 拆箱：将引用类型转换为值类型。 
// 看两种类型是否发生了装箱或者拆箱，要看，这两种类型是否存在继承关系。

// 4.字典类型 
Dictory<int,string>  dic = new Dictory<int,string>();
foreach(KeyValuePair<int,string> kv in dic)
{
    Comsole.WriteLine(kv.Key+"="+kv.Value);
}

// 5.Filestream和StreamReader.StreamWriter
// 将创建文件流对象的过程写在using当中，会自动的帮助我们释放流所占用的资源。
// FileStream：操作字节的
// StreamReader和StreamWriter：操作字符的
//使用FileStream来读取数据
FileStream fsRead = new FileStream(@"C:\Users\SpringRain\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Read);
byte[] buffer = new byte[1024 * 1024 * 5];
//3.8M  5M
//返回本次实际读取到的有效字节数
int r = fsRead.Read(buffer, 0, buffer.Length);
//将字节数组中每一个元素按照指定的编码格式解码成字符串
string s = Encoding.UTF8.GetString(buffer, 0, r);
//关闭流
fsRead.Close();
//释放流所占用的资源
fsRead.Dispose();
Console.WriteLine(s);
Console.ReadKey();

//使用FileStream来写入数据
using (FileStream fsWrite = new FileStream(@"C:\Users\SpringRain\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Write)
{
    string str = "看我游牧又把你覆盖掉";//覆盖前几个对应的文字
    byte[] buffer = Encoding.UTF8.GetBytes(str);
    fsWrite.Write(buffer, 0, buffer.Length);
}
Console.WriteLine("写入OK");
Console.ReadKey();


// 使用文件流来实现多媒体文件的复制
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07使用文件流来实现多媒体文件的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            //思路：就是先将要复制的多媒体文件读取出来，然后再写入到你指定的位置
            string source = @"C:\Users\SpringRain\Desktop\1.复习.wmv";
            string target = @"C:\Users\SpringRain\Desktop\new.wmv";
            CopyFile(source, target);
            Console.WriteLine("复制成功");
            Console.ReadKey();
        }
        public static void CopyFile(string soucre, string target)
        {
            //1.我们创建一个负责读取的流
            using (FileStream fsRead = new FileStream(soucre, FileMode.Open, FileAccess.Read)
            {
                //2.创建一个负责写入的流
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write)
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //因为文件可能会比较大，所以我们在读取的时候 应该通过一个循环去读取
                    while (true)
                    {
                        //返回本次读取实际读取到的字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        //如果返回一个0，也就意味什么都没有读取到，读取完了
                        if (r == 0)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);
                    }   
                }
            }
        }      
    }
}


//StreamReader和StreamWriter
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _08StreamReader和StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用StreamReader来读取一个文本文件
            using (StreamReader sr = new StreamReader(@"D:\桌面\a.txt", Encoding.Default)
            {
                using (StreamWriter sw = new StreamWriter(@"D:\桌面\b.txt",true)
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine();
                        sw.Write(sr.ReadLine();
                    }
                }
                Console.WriteLine("OK");
                Console.ReadKey();
            }


            //使用StreamWriter来写入一个文本文件
            //下面的参数true代表追加，不写代表覆盖
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\SpringRain\Desktop\newnew.txt",true)
            //{
            //    sw.Write("看我有木有把你覆盖掉");
            //}
            //Console.WriteLine("OK");
            //Console.ReadKey();
        }
    }
}

// 5.实现多态的手段 
// 1).虚方法 
// 步骤： 
// a.将父类的方法标记为虚方法 ，使用关键字 virtual，这个函数可以被子类重新写一个遍。
// b.在子方法加override
//虚方法
    public class Person
    {      
        public virtual void Hello()
        {
            Console.WriteLine("hello Person");
        }
    }
    public class Student : Person
    {
        public override void Hello()
        {
            Console.WriteLine("hello Student");
        }
    }
    public class Teacher : Person
    {
        public override void Hello()
        {
            Console.WriteLine("hello Teacher");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Person p1 = new Student();
            p1.Hello();
            Person p2 = new Teacher();
            p2.Hello();
        } 
    }
// 2).抽象类 abstract 
// 当父类中的方法不知道如何去实现的时候，可以考虑将父类写成抽象类，将方法写成抽象方法。
// 抽象类
    public abstract class Animal
    {
        public abstract void Bark();
    }
    public class Cat: Animal
    {
       
        public override void Bark()
        {
            Console.WriteLine("Cat叫");
        }
    }
    public class Dog : Animal
    {

        public override void Bark()
        {
            Console.WriteLine("Dog叫");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Animal a1 = new Cat();
            Animal a2 = new Dog();
            a1.Bark();
            a2.Bark();
        } 
    }


