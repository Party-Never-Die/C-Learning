//.Net基础班第十一天（面向对象继承）

//1、里氏转换 
1)、子类可以赋值给父类 
2)、如果父类中装的是子类对象，那么可以讲这个父类强转为子类对象。

public class Person
    {
       
        public void PersonHello()
        {
            Console.WriteLine("hello person");
        }
    }
    public class Student : Person
    {
        public   void StudentHello()
        {
            Console.WriteLine("hello student");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Person person = new Student();
            Student student = (Student)person;
            student.StudentHello();
            Console.ReadKey();
        }
    }
//2、子类对象可以调用父类中的成员，但是父类对象永远都只能调用自己的成员


//3、is和as
//is：表示类型转换，如果能够转换成功，则返回一个true，否则返回一个false 
bool = person is Student;
//as：表示类型转换，如果能够转换则返回对应的对象，否则返回一个null
Student s = person as Student;


//4、protected 
// 受保护的：可以在当前类的内部以及该类的子类中访问。

//5、ArrayList集合的长度问题

// 每次集合中实际包含的元素个数(count)超过了可以包含的元素的个数(capcity)的时候，
// 集合就会向内存中申请多开辟一倍的空间，来保证集合的长度一直够用。

// 6、ArrayList的各种方法
public class Program
    {
        public static void Main()
        {
            ArrayList list = new ArrayList();
            //添加单个元素 
            list.Add(true);
            //添加集合元素 
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
             
            //list.Clear();清空所有元素 

            //list.Remove(true);删除单个元素 写谁就删谁 

            //list.RemoveAt(0);根据下标去删除元素 

            //list.RemoveRange(0, 3);根据下标去移除一定范围的元素 

            // list.Sort();//升序排列 要进行排序的类型差不多

            //list.Reverse();反转 

            //list.Insert(1, "插入的");在指定的位置插入一个元素 

            //list.InsertRange(0, new string[] { "张三", "李四" });在指定的位置插入一个集合 

            //bool b = list.Contains(1);判断是否包含某个指定的元素
        }
    }
// 7、Hastable 键值对集合  
// 在键值对集合当中，我们是根据键去找值的。 
// 键值对对象[键]=值; 
// *****:键值对集合当中，键必须是唯一的，而值是可以重复的，如果加入相同的键就会异常

    public class Program
    {
        public static void Main()
        {
            Hashtable hashtable = new Hashtable();
            
            //添加数据
            hashtable.Add("1", "zhang");
            hashtable.Add(2, "男");
            hashtable.Add(3, "true");
            hashtable.Add(false, "错误的");
            //另一种添加数据的方式，不会抛异常，没有就加入，有就会替换
            hashtable[6] ="143";
            
            //Contains、ContainsKey、ContainsValue
            bool b1 = hashtable.Contains("1");
            bool b2 = hashtable.ContainsKey("2");
            bool b3 = hashtable.ContainsValue("3");
            
            //清空
            //hashtable.Clear();
            
            //按照键进行移除
            //hashtable.Remove("1");

            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(hashtable[item]);
            }
        }
    }


// 8、foreach循环
// var：根据值推断类型
// item：代表集合里的每一项
// collection：代表要遍历的集合
//foreach+Tab+Tab
foreach (var item in collection)
{

}


// 9、Path
    public class Program
    {
        public static void Main()
        {
            string str = @"C:\3000soft\Red Spider\Data\Message\老赵.wav";
            //获得文件名    
            Console.WriteLine(Path.GetFileName(str));//老赵.wav
            //获得文件名但是不包含扩展名   
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));//老赵
            //获得文件的扩展名    
            Console.WriteLine(Path.GetExtension(str));//.wav
            //获得文件所在的文件夹的名称   
            Console.WriteLine(Path.GetDirectoryName(str));//C:\3000soft\Red Spider\Data\Message
            //获得文件所在的全路径 
            Console.WriteLine(Path.GetFullPath(str));//C:\3000soft\Red Spider\Data\Message\老赵.wav
            //连接两个字符串作为路径 
            Console.WriteLine(Path.Combine(@"C:\a\", "b.txt"));//C:\a\b.txt"
        }
    }
//10、File  
// 只能读小文件
public class Program
    {
        public static void Main()
        {
            //1024byte=1kb  1024kb=1M 1024M=1G 1024G=1T 

            //创建一个文件 
            File.Create(@"C:\Users\SpringRain\Desktop\new.txt");

            //删除一个文件 
            //File.Delete(@"C:\Users\SpringRain\Desktop\new.txt"); 

            //复制一个文件 第一个是要复制的文件  第二个参数是要复制后的路径
            //File.Copy(@"C:\Users\SpringRain\Desktop\code.txt", @"C:\Users\SpringRain\Desktop\new.txt"); 

            //剪切 
            //File.Move(@"C:\Users\SpringRain\Desktop\code.txt", @"C:\Users\SpringRain\Desktop\newnew.txt"); 

            //byte[] buffer = File.ReadAllBytes(@"C:\Users\SpringRain\Desktop\1.txt"); 
            //将字节数组转换成字符串 
            //string s = Encoding.UTF8.GetString(buffer); 
            //Console.WriteLine(s); 

            //string s="今天天气好晴朗，处处好风光"; 
            //将字符串转换成字节数组
            //byte[] buffer=  Encoding.Default.GetBytes(s); 
            //以字节的形式向计算机中写入文本文件   没有的话创建一个，有的话就覆盖(会覆盖原数据)
            //File.WriteAllBytes(@"C:\Users\SpringRain\Desktop\1.txt", buffer); 
            //Console.ReadKey();

            //以行的形式读取  
            string[] contents =  File.ReadAllLines(@"C:\Users\SpringRain\Desktop\抽象类特点.txt", Encoding.Default);

            //以行的形式写入   没有的话创建一个，有的话就覆盖(会覆盖原数据)
            File.WriteAllLines(@"C:\Users\SpringRain\Desktop\抽象类特点.txt", new string[] { "abc", "456" });

            //ReadAllText
            string contents2 = File.ReadAllText(@"C:\Users\SpringRain\Desktop\抽象类特点.txt", Encoding.Default);

            //WriteAllText  没有的话创建一个，有的话就覆盖(会覆盖原数据)
            File.WriteAllText(@"C:\Users\SpringRain\Desktop\抽象类特点.txt", contents2);

            //追加   不会覆盖
            File.AppendAllText(@"C:\Users\SpringRain\Desktop\new.txt", "看我有木有把你覆盖掉");
        } 

//11、编码格式 
// 产生乱码的原因就是因为你保存这个文件的编码格式跟你打开这个文件的编码格式不一样