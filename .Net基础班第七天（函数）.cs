// .Net基础班第七天(函数)


// 1.函数的调用问题


// 我们在Main()函数中,调用Test()函数,我们管Main()函数称之为调用者,
// 管Test()函数称之为被调用者。
// 如果被调用者想要得到调用者的值：
// 1).传递参数。 2).使用静态字段来模拟全局变量。静态字段在类中声明。 
// 如果调用者想要得到被调用者的值： 1).返回值
// 2. 不管是实参还是形参,都是在内存中开辟了空间的。
// 3.方法的功能一定要单一
// GetMax(int n1,int n2) 方法中最忌讳的就是出现提示用户输入的字眼。
// 4.out.ref.params 
// 1).out参数。 如果你在一个方法中,返回多个相同类型的值的时候,
// 可以考虑返回一个数组。 但是,如果返回多个不同类型的值的时候,返回数组就不行了,
// 那么这个时候,
// 我们可以考虑使用out参数。 
// out参数就侧重于在一个方法中可以返回多个不同类型的值。
 public static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int max;
            int min;
            int sum;
            int avg;
            Test(nums, out max, out min, out sum, out avg);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.ReadKey();
        }
        /// <summary>
        /// 计算一个数组的最大值,最小值,总和,平均值
        /// </summary>
        /// <param name="nums">要计算的数组</param>
        /// <param name="max">数组的最大值</param>
        /// <param name="min">数组的最小值</param>
        /// <param name="sum">数组的总和</param>
        /// <param name="avg">数组的平均值</param>
     public static void Test(int[] nums,out int max,out int min,out int sum,out int avg)
        {
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(max < nums[i])
                {
                    max =nums[i];
                }

                if(min > nums[i])
                {
                    min = nums[i];
                }
                sum+=nums[i];
            }
            avg = sum/nums.Length;
        }
//    2).ref参数 能够将一个变量带入一个方法中进行改变,改变完成后,再将改变后的值带出方法。
//     ref参数要求在方法外必须为其赋值,而方法内可以不赋值。
            public static void Main()
        {
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            //int max = 0;
            //int min = 0;
            //int sum = 0;
            //int avg =0;
            //Test(nums, out max, out min, out sum, out avg);
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Console.WriteLine(sum);
            //Console.WriteLine(avg);

            int salary = 8000;
            Jiangjin(ref salary);
            Console.ReadKey();
        }
        public static void Jiangjin(ref int  salary)
        {
            salary = salary + 1000;
        }     
// 3).params可变参数 将实参列表中跟可变参数数组类型一致的元素都当做数组的元素去处理。
// params可变参数必须是形参列表中的最后一个元素。
        public static void Main()
        {
            Test("张三", 70, 80, 90);
            Console.ReadKey();
        }
        public static void Test(string s, params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine(sum);
        }
// 5.方法的重载 
// 概念：方法的重载指的就是方法的名称相同,但是参数不同。 参数不同,分为两种情况 
// 1).如果参数的个数相同,那么参数的类型就不能相同。 
// 2).如果参数的类型相同,那么参数的个数就不能相同。 
// ***方法的重载跟返回值没有关系。   
// 6.方法的递归 
// 方法自己调用自己。 找出一个文件夹中所有的文件。 