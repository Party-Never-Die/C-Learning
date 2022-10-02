.Net基础班第四天(流程控制)


//1.异常捕获 

 我们在程序中经常会出现各种各样的异常,你如果想要你的程序变得坚强一些。
 在你的代码中应该经常性的使用try-catch来进行异常捕获。
 语法: 
 try 
 { 
 可能会出现异常的代码;
 .... ... ... 
 } 
 //try和catch之间不能有其他的代码 
 catch
 {
 出现异常后要执行的代码;
 }
 执行过程:如果try中的代码没有出现异常,那么catch中的代码不会执行。 
 如果try中的代码出现了异常,那怕这行出现异常的代码后面还有一百行都不会执行了,
 而是直接跳到catch中执行代码


//2.变量的作用域 
 变量的作用域就是你能够使用到这个变量的范围。
 变量的作用域一般从声明它的那个括号开始到那个括号所对应的结束的括号结束。
 在这个范围内,我们可以访问并使用变量。超出这个范围就访问不到了


//3.switch-case 
 用来处理多条件的定值的判断。 
 语法: switch(变量或者表达式的值)
 { 
 case 值1:要执行的代码;
 break; 
 case 值2:要执行的代码;
 break;
 case 值3:要执行的代码; 
 break; 
 .......... 
 default:要执行的代码;
 break;
 } 
 执行过程:程序执行到switch处,首先将括号中变量或者表达式的值计算出来, 
 然后拿着这个值依次跟每个case后面所带的值进行匹配,一旦匹配成功,
 则执行 该case所带的代码,执行完成后,遇到break。跳出switch-case结构。
 如果,跟每个case所带的值都不匹配。
 就看当前这个switch-case结构中是否存在 default,
 如果有default,则执行default中的语句,如果没有default,
 则该switch-case结构 什么都不做。


//4.while循环
 while循环: 
 while(循环条件) 
 {
 循环体;
 } 
执行过程:程序运行到while处,首先判断while所带的小括号内的循环条件是否成立, 
如果成立的话,也就是返回一个true,则执行循环体,执行完一遍循环体后,
再次回到 循环条件进行判断,如果依然成立,则继续执行循环体,如果不成立,
则跳出while循环。 
在while循环当中,一般总会有那么一行代码,能够改变循环条件,使之终有一天不再成立,
如果没有那么一行代码能够改变循环条件,也就是循环条件永远都成立,
我们称之这种循环 叫做死循环。 
最简单的最常用的死循环: while(true)
{

}
特点:先判断,再执行,有可能一遍循环都不执行。 


//5.break 
1)、可以跳出switch-case结构。 
2)、可以跳出当前循环。 
break一般不单独的使用,而是跟着if判断一起使用,
表示,当满足某些条件的时候,就不再循环了。


//6.do-while循环。 
语法: 
do 
{ 
循环体; 
}
while(循环条件); 
执行过程:程序首先会执行do中的循环体,执行完成后,去判断do-while循环的循环条件, 
如果成立,则继续执行do中的循环体,如果不成立,则跳出do-while循环。 
特点:先循环,再判断,最少执行一遍循环体。


//7.continue
跳出当次循环

