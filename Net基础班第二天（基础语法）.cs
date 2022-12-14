Net基础班第二天（基础语法）
//1.注释符 
1)、注销 
2)、解释


//2.c#的3种注释符 
单行注释 		   // 
多行注释		   /*要注释的内容*/ 
文档注释	 	   ///  多用来解释类或者方法


//3.快捷键
Ctrl+K+D              //快速对齐代码
Ctrl+Z                //撤销
Ctrl+J                //快速弹出智能提示
Ctrl+S                //保存（一定要经常保存）
Shift+End、Shift+Home //转到行尾、转到行首
Ctrl+K+C              //注释所选代码
Ctrl+K+U              //取消对所选代码的注释
F1                    //转到帮助文档
#Region和#EndRegion   //折叠冗余代码


//4.变量 
用来在计算机当中存储数据。
存储变量的语法： 变量类型 	变量名; 	变量名=值;
    简写		变量类型   变量名 = 值；


//5.数据类型 
整数类型：   int 只能存储整数，不能存储小数。
小数类型：   double 既能存储整数，也能存储小数，小数点后面的位数 15~16位。
金钱类型：   decimal：用来存储金钱，值后面需要加上一个m. 
字符串类型： string,用来存储多个文本，也可以存储空，
            字符串类型的值需要被双引号引来， 这个双引号必须是英文半角状态下的双引号		 
字符类型：   char,用来存储单个字符，最多、最少只能有一个字符，不能存储空。
            字符类型的值需要用 单引号因起来。英文半角状态下的单引号。 
//举例展示；   
int n = 100;
double d = 100.1;
decimal m = 100m;
string name = "卢本伟";
char gender = '男'; 


//6.波浪线 
如果你的代码中出现了红色的波浪线，意味着你的代码中出现了语法错误。
如果你的代码中出现了绿色的波浪线，说明你的代码语法并没有错误，
只不过提示你有可能会出现错误，但是不一定会出现错误。//警告线


//7.变量的使用规则
如果你要是用变量的话，应该要先声明再赋值再使用。

//8.命名规则
首先要保证的就是这个变量的名字要有意义。
0 必须以字母、_或@开头 
1 现阶段给变量起名字的时候都以字母开头
2 后面可以跟任意“字母”、数字、下划线.
/*注意: 
1）你起的变量名不要与c#系统中的关键字重复.
2）在c#中,大小写是敏感的
3）同一个变量名不允许重复定义(先这么认为,不严谨)*/

//给变量起名字的时候要满足两个命名规范：
1)Camel 骆驼命名规范。要求变量名首单词的首字母要小写，
  其余每个单词的首字母要大写。 多用于给变量或字段命名。
2)Pascal 命名规范：要求每个单词的首字母都要大写，其余字母小写。
  多用于给类或者方法命名。


//9.赋值运算符 
=：表示赋值的意思，表示把等号右边的值，赋值给等号左边的变量。 
   由等号连接的表达式称之为赋值表达式。 
//注意:每个表达式我们都可以求解出一个定值，对于赋值表达式而言，
//等号左边的变量的值， 就是整个赋值表达式的值。 int number=10;


//10.+号的作用 
连接：当+号两边有一边是字符串的时候，+号就起到连接的作用。
相加：两边是数字的时候


//11.占位符 
使用方法：先挖个坑，再填个坑。 使用占位符需要注意的地方：
你挖了几个坑，就应该填几个坑，如果你多填了，没效果。如果你少填了，抛异常。
输出顺序：按照挖坑的顺序输出。 
//例如
string name = "卡卡西";
int age = 21;
string email = "1159646657@qq.com";
string address = "河北";
decimal salary = 5000m;
Console.WriteLine("我叫{0},今年{1},我的QQ邮箱是{2},籍贯是{3},工资是{4}", name, age, email, address, salary);


//12.异常 
异常是指：语法上并没有任何错误，只不过在程序运行的期间，由于某些原因出现了问题， 使程序不能再正常的运行。


//13.转义符 
转义符指的就是一个'\'+一个特殊的字符，组成了一个具有特殊意义的字符。
\n       //表示换行
\"       //表示一个英文半角的双引号 
\t       //表示一个tab键的空格
\b       //表示一个退格键，放到字符串的两边没有效果。
\r\n     //windows操作系统不认识\n,只认识\r\n 
\\       //表示一个\
@符号    
 取消\在字符串中的转义作用，使其单纯的表示为一个\
 将字符串按照编辑的原格式输出


//14.算数运算符 + - * / %
  

//15.类型转换 
隐式类型转换： 我们要求等号两遍参与运算的操作数的类型必须一致，
如果不一致，满足下列条件会发生 自动类型转换，或者称之为隐式类型转换。
 两种类型兼容 例如 int 和 double 兼容(都是数字类型) 目标类型大于原类型 
             例如 double > int  小的转大的
显示类型转换 1、两种类型相兼容 int--double 
            2、大的转成小的 double----int 
           语法： (待转换的类型)要转换的值;			

