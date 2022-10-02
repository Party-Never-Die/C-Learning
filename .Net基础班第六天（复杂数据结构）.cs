.Net基础班第六天(复杂数据结构)


//1.常量 
 声明的 常量的语法: const 变量类型 变量名=值;     
 常量不能重复赋值
 const int number = 10;


//2、枚举 
 1)语法 
 [publi c] enum 枚举名 ·
 {  
 值1,  
 值2,  
 值3,  
 ..... ... 
 } 
 public:访问修饰符。公开的公共的,哪都可以访问。 
 enum:关键字,声明枚举的关键字  
 枚举名:要符合Pascal命名规范
 将枚举声明到命名空间的下面,类的外面,表示这个命名空间下,
 所有的类都可以使用这个枚举。
 枚举就是一个变量类型 ,int--double  string  decimal. 
 只是枚举声明、赋值、使用的方式跟那些普通的变量类型不一样。
 //枚举类型定义
  public enum  Gender
 {
  男,
  女
 }
 //使用
 Gender gender = Gender.男;
 2)枚举转化
 我们可以将一个枚举类型的变量跟int类型和string类型互相转换。 
 枚举类型默认是跟int类型相互兼容的,所以可以通过强制类型转换的语法互相转换。 
 //枚举类型的数字是默认从0开始的
 Gender gender = Gender.男;
 int n = (int)gender;//这里n是0
 //有值时转换为枚举类型
 //当转换一个枚举中没有的值的时候,不会抛异常,而是直接将数字显示出来。
 int n1 = 2;
 Gender g = (Gender)n1;
 枚举同样也可以跟string类型互相转换,如果将枚举类型转换成string类型,
 则直接调用ToString(). 如果将字符串转换成枚举类型则需要下面这 样一行代码:  
 (要转换的枚举类型)Enum.Parse(typeof(要转换的枚举类型),"要转换的字符串"); 
 如果转换的字符串是数字,则就算枚举中没有,也会不会抛异常。 
 如果转换的字符串是文本,如果枚举中没有,则会抛出异常。
 //枚举转换为字符串
 Gender gender = Gender.男;
 string s = gender.ToString();//s的值为"男" 
 //字符串转换为枚举 
 string s = "0";
 Gender g = (Gender)Enum.Parse(typeof(Gender),s);

 
//3.所有的类型都能够转换成string类型,调用ToString()。


//4.结构 
 可以帮助我们一次性声明多个不同类型的变量。  
 语法: [public] struct 结构名 
 {  
 成员;//字段 
 } 
 变量在程序运行期间只能存储一个值,而字段可以存储多个值。
 //定义
 //字 段前面要加下划线_
 public struct Person
 {
    public string _name { get; set; }
    public int _age { get; set; }
    p ublic string _address { get; set; }
 }
 //使用
 Person zsPerson;
 zsPerson._name = "张三";


//5.数组 
 一次性存储多个相同类型的变量。  
 语法: 
 数组类型[] 
 数组名=new 
 数组类型[数组长度];
 ***数组的长度一旦固定了,就不能再被改变了
 int[] nums = new int[10];
 int[] numsTwo = {1,2,3} 
 int[] numsThree = new int[]{1,2,3}
 int[] numsThree = new int[3]{1,2,3}

 
//6.冒泡排序
 就是将一个数组中的元素按照从大到小或者从小到大的顺序进行排列。 
 int[] nums={9,8,7,6,5,4,3,2,1,0}; 	0 1 2 3 4 5 6 7 8 9 
 第一趟比较:8 7 6 5 4 3 2 1 0 9 交换了9次     i=0  j=nums.Length-1-i 
 第二趟比较:7 6 5 4 3 2 1 0 8 9 交换了8次     i=1  j=nums.Length-1-i 
 第三趟比较:6 5 4 3 2 1 0 7 8 9 交换了7次     i=2  j=nums.Length-1-i 
 第四趟比较:5 4 3 2 1 0 6 7 8 9 交换了6次     i=3  j=nums.Length-1-i 
 第五趟比较:4 3 2 1 0 5 6 7 8 9 交换了5次 
 第六趟比较:3 2 1 0 4 5 6 7 8 9 交换了4次 
 第七趟比较:2 1 0 3 4 5 6 7 8 9 交换了3次 
 第八趟比较:1 0 2 3 4 5 6 7 8 9 交换了2次 
 第九趟比较:0 1 2 3 4 5 6 7 8 9 交换了1次 
 for(int i=0;i<number.Length-1;i++) 
 {  
     for(int j=0;j<nums.Length-1-i;j++)  
      {   
          if(nums[j]>nums[j+1])  
           {   
            int temp=nums[j];    
            nums[j]=nums[j+1];    
            nums[j+1]=temp;   
           } 
      }
 }


//7.方法 
 函数就是将一堆代码进行重用的一种机制。 
 函数的语法: [public] static 返回值类型 方法名([参数列表]) {  方法体； } 
 public:访问修饰符,公开的,公共的,哪都可以访问。 
 static:静态的 
 返回值类型:如果不需要写返回值,写void  
 方法名:Pascal 每个单词的首字母都大些。其余字母小写  
 参数列表:完成这个方法所必须要提供给这个方法的条件。
 如果没有参数,小括号也不能省略。
 方法写好后,如果想要被执行,必须要在Main()函数中调用。  
 方法 的调用语法: 类名.方法名([参数]);
 ***在某些情况下,类名是可以省略的,如果你写的方法跟Main()函数同在一个类中,
 这个时候, 类名可以省略。


//8 .return 
1)、在方法中返回要返回的值。 
2)、立即结束本次方法。  