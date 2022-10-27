using System;

namespace E07TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCnt = int.Parse(Console.ReadLine());

            //how much will be % people in each group if groups vary as in "for"{}?


            int totalPeopleCnt = 0;
            int peopleGroup1 = 0;
            int peopleGroup2 = 0;
            int peopleGroup3 = 0;
            int peopleGroup4 = 0;
            int peopleGroup5 = 0;


                for (int i = 1; i <= groupCnt; i++)
            {
                int peopleCntPerGroup = int.Parse(Console.ReadLine());
 
                if (peopleCntPerGroup <= 5)
                {  
                    peopleGroup1 += peopleCntPerGroup;
                }
                else if (peopleCntPerGroup >= 6 && peopleCntPerGroup <= 12)
                {  
                    peopleGroup2 += peopleCntPerGroup;
                }

                else if (peopleCntPerGroup >= 13 && peopleCntPerGroup < 26)
                { 
                    peopleGroup3 += peopleCntPerGroup;
                }

                else if (peopleCntPerGroup>= 26 && peopleCntPerGroup <= 40)
                {
                    peopleGroup4 += peopleCntPerGroup;
                }
                else 
                {
                    peopleGroup5 += peopleCntPerGroup;
                }
                
            }


            totalPeopleCnt = peopleGroup1 + peopleGroup2 + peopleGroup3 + peopleGroup4 + peopleGroup5;

            double percentagePplGroup1 = ((double)peopleGroup1 / totalPeopleCnt) * 100;
            double percentagePplGroup2 = ((double)peopleGroup2 / totalPeopleCnt) * 100;
            double percentagePplGroup3 = ((double)peopleGroup3 / totalPeopleCnt) * 100;
            double percentagePplGroup4 = ((double)peopleGroup4 / totalPeopleCnt) * 100;
            double percentagePplGroup5 = ((double)peopleGroup5 / totalPeopleCnt) * 100;


            Console.WriteLine($"{percentagePplGroup1:f2}%");
            Console.WriteLine($"{percentagePplGroup2:f2}%");
            Console.WriteLine($"{percentagePplGroup3:f2}%");
            Console.WriteLine($"{percentagePplGroup4:f2}%");
            Console.WriteLine($"{percentagePplGroup5:f2}%");

        }
    }
}

