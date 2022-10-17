namespace ExamQuestion
{

    internal class program

    {
        
        // total points mothod
        public static double TotalPoints(double an1, double an2, double an3, double an4, double an5)
        {

            return an1 + an2 + an3 + an4 + an5;

        }

        
        

        static void Main(string[] args)

        

        {


           
            

            double correctanwer1 = 20.5;
            double correctanwer2 = 10.5;
            double correctanswer3 = 66;
            double correctanswer4 = 100;
            double correctanswer5 = 10.6;




            



            // Exam Questions + User imput



            Console.WriteLine("****MATH TEST*****");

            Console.WriteLine("Please enter student name to start the Exam :");
            var studentName = Console.ReadLine();


            Console.WriteLine(" 1. What is the ressult of 1/2 + 20 ?");
            var useranswer1 = double.Parse(Console.ReadLine());

            Console.WriteLine(" 2. What is the ressult of 2/20 + 10 ?");
            var useranswer2 = double.Parse(Console.ReadLine());


            Console.WriteLine(" 3. What is the ressult of 56 + 10 ?");
            var useranswer3 = double.Parse(Console.ReadLine());

            Console.WriteLine(" 4. Waht is the 10% of 1000 ?");
            var useranswer4 = double.Parse(Console.ReadLine());


            Console.WriteLine(" 5. WHat is the total of 10 + 6% ?");
            var useranswer5 = double.Parse(Console.ReadLine());



            // correct and worng anwers points set 

            var userinput1 = useranswer1;
            if (userinput1 != correctanwer1)
            {
                userinput1 = 0;
            }
            else if (userinput1 == correctanwer1)
            {
                userinput1 = 5;

            }
            var userinput2 = useranswer2;
            if (userinput2 != correctanwer2)
            {
                userinput2 = 0;

            }

            else if (userinput2 == correctanwer2)
            {

                userinput2 = 5;
            }
            var userinput3 = useranswer3;

            if (userinput3 != correctanswer3)
            {
                userinput3 = 0;

            }
            else if (userinput3 == correctanswer3)
            {
                userinput3 = 5;

            }



            var userinput4 = useranswer4;
            if (userinput4 != correctanswer4)
            {
                userinput4 = 0;

            }
            else if (userinput4 == correctanswer4)
            {
                userinput4 = 5;

            }

            var userinput5 = useranswer5;

            if (userinput5 != correctanswer5)
            {
                userinput5 = 0;

            }

            else if (userinput5 == correctanswer5)

            {
                userinput5 = 5;

            }


            // sum of total points

            var ExamTotalPoints = TotalPoints(userinput1, userinput2, userinput3, userinput4, userinput5);



            // score pass or fail


            var examresult = ExamTotalPoints;


            if (examresult < 25)

            {
                Console.WriteLine($"sorry {studentName} you failed the test with score of {examresult}");

            }


            else if (examresult == 25)

            {

                Console.WriteLine($"Congrast!{studentName} you pass the exam with socre of {examresult}");
            }






































        }


















    }
      
}