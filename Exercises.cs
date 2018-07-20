using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public static class Exercises
    {
        public static void Exercises1()
        {
            int x = 10;
            int y = 5;

            Console.WriteLine("x = y + 3 ; x = " + (y + 3));
            Console.WriteLine("x = y - 2 ; x = " + (y - 2));
            Console.WriteLine("x *= y * 5 ; x = " + (x * y * 5));
            Console.WriteLine("x /= x /y ; x = " + (x / (x / y)));
            Console.WriteLine("x %= y ; x = " + (x % y));

            Console.ReadKey();
        }

        public static void Exercises2()
        {
            Console.WriteLine("Choose your number : ");
            int a;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of a is " + a);
            Console.WriteLine("The value of ++a is " + (++a));
            Console.WriteLine("The value of a is " + a);
            Console.WriteLine("the value of a++ is " + (a++));
            Console.WriteLine("The value of a is" + a);
            Console.WriteLine("The value of --a is " + (--a));
            Console.WriteLine("The value of a is " + a);
            Console.WriteLine("The value of a-- is" + (a--));
            Console.WriteLine("The value of a is " + a);
            Console.ReadKey();
        }

        public static void Conditionals1()
        {
            Console.WriteLine("Choose first number :");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose second number :");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose third number : ");
            int numberThree = int.Parse(Console.ReadLine());
            if (numberOne >= numberTwo)
                if (numberOne >= numberThree)
                    Console.WriteLine("Highest number is " + numberOne);
                else
                    Console.WriteLine("Highest number is " + numberThree);
            else
                if (numberTwo >= numberThree)
                Console.WriteLine("Highest number is " + numberTwo);
            else
                Console.WriteLine("Highest number is " + numberThree);

            Console.ReadKey();
        }

        public static void Conditionals2()
        {
            Console.WriteLine("Enter student's quiz score : ");
            int quizScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student's mid score :");
            int midScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student's final score :");
            int finalScore = int.Parse(Console.ReadLine());
            float average = ((quizScore + midScore + finalScore) / 3);
            if (average >= 90)
                Console.WriteLine("Student has grade " + "A");
            else
            if (average >= 70)
                Console.WriteLine("Student has grade " + "B");
            else
                if (average >= 50)
                Console.WriteLine("Student has grade " + "C");
            else
                Console.WriteLine("Student has grade " + "F");

            Console.ReadKey();

        }

        public static void Switch1()
        {
            Console.WriteLine("Press a key: ");
            string caseSwitchTest = Console.ReadLine();
            int caseSwitch;
            if (Int32.TryParse(caseSwitchTest, out caseSwitch))
                switch (caseSwitch)
                {
                    case 0:
                        Console.WriteLine(caseSwitch);
                        break;
                    case 1:
                        Console.WriteLine(caseSwitch);
                        break;
                    case 2:
                        Console.WriteLine(caseSwitch);
                        break;
                    case 3:
                        Console.WriteLine(caseSwitch);
                        break;
                    case 4:
                        Console.WriteLine(caseSwitch);
                        break;
                    case 5:
                        Console.WriteLine(caseSwitch);
                        break;
                    case 6:
                        Console.WriteLine(caseSwitch);
                        break;
                    case 7:
                        Console.WriteLine(caseSwitch);
                        break;
                    case 8:
                        Console.WriteLine(caseSwitch);
                        break;
                    case 9:
                        Console.WriteLine(caseSwitch);
                        break;
                    default:
                        break;
                }
            else
                Console.WriteLine("not allowed");

            Console.ReadKey();


        }

        public static void Switch2()
        {
            Console.WriteLine("What is the correct way to declare a variable to store an integer value in C#? ");
            Console.WriteLine("a. int 1x=10;");
            Console.WriteLine("b. int x=10;");
            Console.WriteLine("c. float x=10.0f;");
            Console.WriteLine("d. string x=10;");
            Console.WriteLine("Choose your answer : ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "a":
                    Console.WriteLine("Wrong answer");
                    break;
                case "b":
                    Console.WriteLine("Correct answer");
                    break;
                case "c":
                    Console.WriteLine("Wrong answer");
                    break;
                case "d":
                    Console.WriteLine("Wrong answer");
                    break;
            }
            Console.ReadKey();
        }

        public static void For1()
        {
            string pattern = "*******";
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine(pattern);
                pattern = pattern.Remove(pattern.Length - 1);
            }
            Console.ReadKey();
        }

        public static void For2()
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (i >= j)
                        Console.Write(j);
                    else
                        Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }

        

        public static void While1()
        {
            Console.WriteLine("What is the command keyword to exit a loop in C#?\n a. int \n b. continue \n c. break \n d.exit \n Enter your choice: b \n Incorrect! \n Again ? press y to continue:");
            string answer = "y";
            string choosedAnswer;
            while (answer == "y")
            {
                Console.WriteLine("Choose your answer : ");
                choosedAnswer = Console.ReadLine();
                if (choosedAnswer == "c")
                    Console.WriteLine("Correct Answer!");
                else
                    Console.WriteLine("Wrong Answer!");
                Console.WriteLine("Again ? Press y to answer again : ");
                answer = Console.ReadLine();
            }
            Console.ReadKey();
        }

        public static void While2()
        {
            int i = 1;
            while (i <= 122)
            {
                char c = (char)i;
                Console.Write(c+ " ");
                if (i % 10 == 0)
                    Console.WriteLine(" ");
                i++;
            }
            Console.ReadKey();
        }

        public static void doWhile1()
        {
            Console.WriteLine("What is the command keyword to exit a loop in C#?\n a. int \n b. continue \n c. break \n d.exit \n Enter your choice: b \n Incorrect! \n Again ? press y to continue:");
            string answer = "y";
            string choosedAnswer;
            do
            {
                Console.WriteLine("Choose your answer : ");
                choosedAnswer = Console.ReadLine();
                if (choosedAnswer == "c")
                    Console.WriteLine("Correct Answer!");
                else
                    Console.WriteLine("Wrong Answer!");
                Console.WriteLine("Again ? Press y to answer again : ");
                answer = Console.ReadLine();
            }
            while (answer == "y");
            Console.ReadKey();
        }

        public static void doWhile2()
        {
            int i = 1;
            do
            {
                char c = (char)i;
                Console.Write(c + " ");
                if (i % 10 == 0)
                    Console.WriteLine(" ");
                i++;
            }
            while (i <= 122);
            Console.ReadKey();
        }

        public static void Random1()
        {
            Random rnd = new Random();
            int computerNumber = rnd.Next(1, 7);
            Console.WriteLine("Enter your number :");
            int userNumber = int.Parse(Console.ReadLine());
            if (computerNumber == userNumber)
                Console.WriteLine("You won.");
            else
                Console.WriteLine("You lost . My number is : " + computerNumber);
            Console.ReadKey();
        }

        public static void Random2()
        {
            string answer = "y";
            Random rnd = new Random();
            int computerNumber = rnd.Next(1, 7);
            while (answer == "y")
            {
                Console.WriteLine("Enter your number :");
                int userNumber = int.Parse(Console.ReadLine());
                if (computerNumber == userNumber)
                    Console.WriteLine("You won.");
                else
                {
                    Console.WriteLine("You lost . My number is : " + computerNumber);
                }
                Console.WriteLine("Press y to try again :");
                answer = Console.ReadLine();
            }
            Console.ReadKey();
        }

        public static void Arrays1()
        {
            int[] numberList = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                numberList[i] = 100 - i;
            }
            int temp = 0;
            for (int write = 0; write < numberList.Length; write++)
            {
                for (int sort = 0; sort < numberList.Length - 1; sort++)
                {
                    if (numberList[sort] > numberList[sort + 1])
                    {
                        temp = numberList[sort + 1];
                        numberList[sort + 1] = numberList[sort];
                        numberList[sort] = temp;
                    }
                }
                
            }
            for (i = 0; i < numberList.Length; i++)
                Console.Write(numberList[i] + " ");
            Console.ReadKey();
        }

        public static void Arrays2()
        {
            int[] numberList = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                numberList[i] = 100 - i;
            }
            int temp = 0;
            for (int write = 0; write < numberList.Length; write++)
            {
                for (int sort = 0; sort < numberList.Length - 1; sort++)
                {
                    if (numberList[sort] < numberList[sort + 1])
                    {
                        temp = numberList[sort + 1];
                        numberList[sort + 1] = numberList[sort];
                        numberList[sort] = temp;
                    }
                }

            }
            for (i = 0; i < numberList.Length; i++)
                Console.Write(numberList[i] + " ");
            Console.ReadKey();
        }

        public static void Arrays3()
        {
            int[] numberList = new int[10];
            int i;
            Console.WriteLine("Choose a number to search it in our array : ");
            int searchNumber = int.Parse(Console.ReadLine());
            for (i = 0; i < 10; i++)
            {
                numberList[i] = 100 - i;
            }
            for (i = 0; i < numberList.Length; i++)
            {
                if (numberList[i] == searchNumber)
                    Console.WriteLine("Found");
                //else
                    //Console.WriteLine("Not Found");
            }
            Console.ReadKey();
        }

        public static void Arrays4()
        {
            int[] numberList = new int[10];
            int i;
            Console.WriteLine("Choose a number to search it in our array : ");
            int searchNumber = int.Parse(Console.ReadLine());
            for (i = 0; i < 10; i++)
            {
                numberList[i] = 1 + i;
            }
            int min = 0;
            int N = numberList.Length;
            int max = N - 1;
            do
            {
                int mid = (min + max) / 2;
                if (searchNumber > numberList[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (numberList[mid] == searchNumber)
                    Console.WriteLine("We found the number ! It is " + numberList[mid]);
                else
                    Console.WriteLine("We didn t found the number yet ...");
            } while (min <= max);
            Console.ReadKey();
        }

        public static void Arrays5()
        {
            String[,] matrix = new String[5, 5];
            int index = 1;
            int i;
            int j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (index != 8)
                    {
                        matrix[i, j] = index.ToString();
                    }
                    else matrix[i, j] = " ";
                    Console.Write(matrix[i, j] + " ");
                    index++;
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }

        public static void Arrays6()
        {
            int[,] matrix = new int[5, 5];
            int i;
            int j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (i < j)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = -1;
                    if (i == j)
                        matrix[i, j] = 0;
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }

        public static void Arrays7()
        {
            String[,] matrix = new String[5, 5];
            int i;
            int j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    matrix[i, j] = " ";
                    if (i == j)
                    {
                        matrix[i, j] = 1.ToString();
                    }
                    if (j == 0)
                    {
                        matrix[i, j] = 1.ToString();
                    }
                    if ((i > j) & (i > 1) & ( j > 0 ))
                    {
                        int temp1 = int.Parse(matrix[i - 1, j]);
                        int temp2 = int.Parse(matrix[i - 1, j - 1]);
                        matrix[i, j] = (temp1+temp2).ToString();
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }

        public static int getMode(int[] array)
        {
            int[] x = array;

            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int a in x)
            {
                if (counts.ContainsKey(a))
                    counts[a] = counts[a] + 1;
                else
                    counts[a] = 1;
            }

            int result = int.MinValue;
            int max = int.MinValue;
            foreach (int key in counts.Keys)
            {
                if (counts[key] > max)
                {
                    max = counts[key];
                    result = key;
                }
            }
            return (result);
        }

        public static void Arrays8()
        {
            Console.WriteLine("Choose the length of data set");
            int input = int.Parse(Console.ReadLine());
            int[] data = new int[input];
            int sum = 0;
            float result;
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("data[ " + i + "] = ");
                data[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Statistical information");
            Console.WriteLine("........................");
            for (int  i = 0; i <data.Length; i++)
            {
                sum = sum + data[i];

            }
            result = (sum / data.Length);
            Console.WriteLine(" Arithmetic mean = " + result );
            if (data.Length % 2 == 1)
            {
                Console.WriteLine("Median = " + data[data.Length / 2 + 1]);
            }
            else
            {
                result = ((data[data.Length / 2] + data[data.Length / 2 - 1]) / 2);
                Console.WriteLine("Median = " + result);
            }
            Console.WriteLine("Mode is " + getMode(data));
            Console.ReadKey();
        }

        struct students
        {
            public int id;
            public String name;
            public String sex;
            public int firstQuizScore;
            public int secondQuizScore;
            public int midScore;
            public int finalScore;
            public int totalScore;
        }

        public static void initMenu()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("M E N U");
            Console.WriteLine("========================================================");
            Console.WriteLine("1. Add student records");
            Console.WriteLine("2. Delete student records");
            Console.WriteLine("3. Update student records");
            Console.WriteLine("4. View student records");
            Console.WriteLine("5. Calculate an average of a selected student’s scores");
            Console.WriteLine("6. Show student who gets the max total score");
            Console.WriteLine("7. Show student who gets the min total score");
            Console.WriteLine("8. Find student by ID");
            Console.WriteLine("9. Sort records by total scores");
        }
        public static void Structure1()
        {
            students[] studentList = new students[2];
            Console.WriteLine("Populate students list : ");
            int actualIndex = 0;
            for (int i=0; i< 2; i++)
            {
                Console.WriteLine(" Student" + (i + 1) + " name is : ");
                studentList[i].id = i;
                studentList[i].name = Console.ReadLine();
                Console.WriteLine("Enter student" + (i + 1) + " gender : ");
                studentList[i].sex = Console.ReadLine();
                Console.WriteLine("Enter student" + (i + 1) + " quiz scores: ");
                Console.Write("first quiz score = ");
                studentList[i].firstQuizScore = int.Parse(Console.ReadLine());
                Console.Write("second quiz score = ");
                studentList[i].secondQuizScore = int.Parse(Console.ReadLine());
                Console.Write("mid score = ");
                studentList[i].midScore = int.Parse(Console.ReadLine());
                Console.Write("final score =");
                studentList[i].finalScore = int.Parse(Console.ReadLine());
                studentList[i].totalScore = (studentList[i].firstQuizScore + studentList[i].secondQuizScore + studentList[i].midScore + studentList[i].finalScore) / 4;
                actualIndex = i;
            }
            Console.WriteLine(".....................................................");
            initMenu();
            do
            {
                Console.WriteLine("Choose next action : ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        {
                            studentList[actualIndex + 1].id = actualIndex + 1;
                            Console.Write("Student" + (actualIndex + 1) + " name is : ");
                            studentList[actualIndex + 1].name = Console.ReadLine();
                            Console.WriteLine("Enter student" + (actualIndex + 1) + " gender : ");
                            studentList[actualIndex + 1].sex = Console.ReadLine();
                            Console.WriteLine("Enter student" + (actualIndex + 1) + " quiz scores: ");
                            Console.Write("first quiz score = ");
                            studentList[actualIndex + 1].firstQuizScore = int.Parse(Console.ReadLine());
                            Console.Write("second quiz score = ");
                            studentList[actualIndex + 1].secondQuizScore = int.Parse(Console.ReadLine());
                            Console.Write("mid score = ");
                            studentList[actualIndex + 1].midScore = int.Parse(Console.ReadLine());
                            Console.Write("final score =");
                            studentList[actualIndex + 1].finalScore = int.Parse(Console.ReadLine());
                            studentList[actualIndex + 1].totalScore = (studentList[actualIndex + 1].firstQuizScore + studentList[actualIndex + 1].secondQuizScore + studentList[actualIndex + 1].midScore + studentList[actualIndex + 1].finalScore) / 4;
                            actualIndex++;
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("Select id of the student you want to erase his records: ");
                            int tempID = int.Parse(Console.ReadLine());
                            studentList[tempID].name = " ";
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("Select id of the student you want to update his records: ");
                            int tempID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter new student name: ");
                            studentList[tempID].name = Console.ReadLine();
                        }
                        break;
                    case "4":
                        {
                            for (int i = 0; i < studentList.Length; i++)
                            {
                                Console.WriteLine("name = " + studentList[i].name);
                                Console.WriteLine("id = " + studentList[i].id);
                                Console.WriteLine("first quiz score = " + studentList[i].firstQuizScore);
                                Console.WriteLine(" second quiz score = " + studentList[i].secondQuizScore);
                                Console.WriteLine("mid score = " + studentList[i].midScore);
                                Console.WriteLine("final score = " + studentList[i].finalScore);
                                Console.WriteLine("total score = " + studentList[i].totalScore);
                                Console.WriteLine(" ");
                            }
                        }
                        break;
                    case "5":
                        {
                            Console.WriteLine("Select student id for finding out his average score");
                            int tempID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Student wiht id " + studentList[tempID].id + " has an average score of " + studentList[tempID].totalScore);
                        }

                        break;
                    case "6":
                        {
                            Console.Write("Student with highest max score is student with name : ");
                            int max_score = Int32.MinValue;
                            int max_index =-1;
                            for (int i = 0; i<studentList.Length; i++)
                            {
                                if (studentList[i].totalScore >= max_score)
                                {
                                    max_score = studentList[i].totalScore;
                                    max_index = i;
                                }
                            }
                            Console.WriteLine(studentList[max_index].name + " with an average score of " + studentList[max_index].totalScore);
                        }
                        break;
                    default:
                        break;
                }
            }
            while ( true );
            Console.ReadKey();
        }
    }
}
