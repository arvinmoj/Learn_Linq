using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0 , 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 ,
                              10 , 11 , 12 , 13 , 14 , 15 , 16 , 17 , 18 , 19 ,20  };
            // Select All                 
            int[] result1 = (from n in numbers select n).ToArray();

            // Sort By Ascending 0 to 20 (صعودی)
            int[] result2 = (from n in numbers orderby n ascending select n).ToArray();

            // Sort By Descending 20 to 0 (نزولی)
            int[] result3 = (from n in numbers orderby n descending select n).ToArray();
            
            // where (شرط)
            int[] result4 = (from n in numbers where n > 10 select n).ToArray();
            int[] result5 = (from n in numbers where n > 10 && n < 15 select n).ToArray();

            // Sort And Where
            int[] result6 = (from n in numbers 
                            where n > 10 && n <= 15 
                          orderby n ascending select n).ToArray();
            
            // زمانی که نمیدانیم هست یا نیست 
            // ()First : اولین عنصر از آرایه را بر می گرداند.
            // ()First :   هنگامی که عنصری وجود نداشت با 
            //             استثنا مواجه می شود.
            int result7 = (from n in numbers where n==4 select n).First();
            // Error
            //int result8 = (from n in numbers where n==40 select n).First();

            // زمانی که نمیدانیم هست یا نیست 
            // ()FirstOrDefault : اولین عنصر از آرایه را بر می گرداند.
            // ()FirstOrDefault : هنگامی که عنصری وجود نداشت با استثنا مواجه نمی شود.
            int result9 = (from n in numbers where n==4 select n).FirstOrDefault();
            int result10 = (from n in numbers where n==40 select n).FirstOrDefault();

            // زمانی که مطمئن هستیم وجود دارد 
            // ()Single : دقیقاً 1 نتیجه وجود دارد ، در صورت عدم بازگشت نتیجه یا بیش از یک نتیجه ، یک استثنا پرتاب می شود.
            int result11 = (from n in numbers where n==4 select n).Single(); 
            // Error
            //int result12 = (from n in numbers where n==40 select n).Single();

            // زمانی که مطمئن هستیم وجود دارد 
            // ()SingleOrDefault : همان است که single را
            //                     پشتیبانی میکند  null
            int result13 = (from n in numbers where n==4 select n).SingleOrDefault();
            int result14 = (from n in numbers where n==40 select n).SingleOrDefault();

            // Any -> True or False
            bool result15 = (from n in numbers where n==4 select n).Any();
            bool result16 = (from n in numbers where n==40 select n).Any();

            // Count 
            int result17 = (from n in numbers select n).Count();

            // Max
            int result18 = (from n in numbers select n).Max();

            // Min
            int result19 = (from n in numbers select n).Min();

            // Sum
            int result20 = (from n in numbers select n).Sum();

            List<string> Names = new List<string>();
            Names.Add("Ali");
            Names.Add("Amir");
            Names.Add("Arvin");
            Names.Add("Arina");
            Names.Add("Shervin");

            // Select All
            var result21 = (from n in Names select n).ToList();

            // Select "a" in List
            var result22 = (from n in Names where n.ToLower().Contains("a") select n).ToList();

            // Select "a" StartsWith
            var result23 = (from n in Names where n.ToLower().StartsWith("a") select n).ToList();

            // Select "a" EndsWith
            var result24 = (from n in Names where n.ToLower().EndsWith("a") select n).ToList();

            // Count Syntax
            int[] Distinct = { 1 , 1 , 2 , 2 , 3 , 4 , 4 , 5 , 5};
            var result25 = (from d in Distinct select d).Distinct().Count();

            // Count Conditional
            int[] Conditional = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int result26 = (from c in Conditional select c).Count(n => n % 2 == 1);
            
        }
    }
}
