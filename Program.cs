Console.WriteLine("Hello, World!");

//1

//int number = 0;
//int check = 0;
//int[]list= {10,11,89,34,5,67,12,55,32,90};

//Console.Write("Enter your number:");
//number=int.Parse(Console.ReadLine());

//for(int i = 0; i <list.Length; i++)
//{
//    if(number == list[i])
//    {
//        Console.WriteLine("Number index:"+i);
//        check = 1; 
//        break;
//    }
//}

//if(check != 1)
//{
//    Console.WriteLine("ERROR");
//}



//2

//int number = 0;
//int check = 0;
//int[] list = { 10, 11, 89, 34, 5, 67, 12, 55, 32, 90 };
//int[] newlist =new int[10];

//Console.Write("Enter your number:");
//number = int.Parse(Console.ReadLine());

//for (int i = 0; i < list.Length; i++)
//{
//    if (list[i] != number)
//    {
//        newlist[i] = list[i];
//    }
//}

//for (int j = 0;j < list.Length; j++)
//{
//    Console.WriteLine(newlist[j]);
//}



//3

//int[] list = { 10, 11, 89, 34, 5, 67, 12, 55, 32, 90 };
//int[] newlist = new int[10];

//for (int i = 0; i < list.Length; i++)
//{
//    newlist[i] = list[i];
//}

//for (int j = 0; j < list.Length; j++)
//{
//    Console.WriteLine(newlist[j]);
//}



//4

//int number = 0;
//int index = 0;
//int[] list = { 10, 11, 89, 34, 5, 67, 12, 55, 32, 90 };

//Console.Write("Enter your number:");
//number = int.Parse(Console.ReadLine());

//Console.Write("Enter your number index:");
//index = int.Parse(Console.ReadLine());

//for (int i = 0; i < list.Length; i++)
//{
//    if (i == index)
//    {
//        list[i] = number; 
//        break;
//    }
//}

//for (int j = 0; j < list.Length; j++)
//{
//    Console.WriteLine(list[j]);
//}



//5

//int check = 0;
//int count = 0;
//String repetition="" ;
//int[] list = { 10, 11, 10, 34, 11 };

//for (int i = 0; i < list.Length; i++)
//{
//    check = list[i];
//    for (int j = 0; j < list.Length; j++)
//    {
//        if (check == list[j])
//        {
//            count++;
//        }
//    }
//    if (count >1)
//    {
//        repetition += check + "" + "*";
//    }
//    count = 0;
//}

//Console.WriteLine(repetition);



//6

//int[] list1 = { 67, 33, 10, 34, 11 };
//int[] list2 = { 22, 90, 10, 5, 11 };
//int checklist = 0;
//int count = 0;
//String repetition = "";

//for (int i = 0; i < list1.Length; i++)
//{
//    checklist=list1[i];
//    for (int j = 0; j < list2.Length; j++)
//    {
//        if (checklist == list2[j])
//        {
//            count++;
//        }
//    }

//    if (count > 0)
//    {
//        repetition += checklist + "" + "*";
//    }
//    count = 0;
//}

//Console.WriteLine(repetition);



//7

//int check = 0;
//int count = 0;
//String repetition = "";
//int[] list = { 10, 11, 10, 34, 11 };

//for (int i = 0; i < list.Length; i++)
//{
//    check = list[i];
//    for (int j = 0; j < list.Length; j++)
//    {
//        if (check == list[j])
//        {
//            count++;
//        }
//    }
//    if (count > 1)
//    {
//        list[i] = 0; 
//    }
//    count = 0;
//}

//for (int i = 0; i<list.Length; i++)
//{
//    Console.WriteLine(list[i]);
//}



//8

//int[] list1 = { 67, 33, 10, 34, 11 };
//int[] list2 = { 67, 33, 10, 34, 11 };
//bool checklist ;
//String Checktotal = "";

//if (list1.Length == list2.Length)
//{
//    checklist = true;
//}
//else 
//{
//    checklist = false; 
//}

//if (checklist)
//{
//    for (int i = 0; i < list1.Length; i++)
//    {
//        if (list1[i] == list2[i])
//        {
//            Checktotal += "*";
//        }
//    }
//}

//if (Checktotal.Length == list1.Length)
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}



//9

//String[] list = {"1", ".", "1", ".", "1" };
//String[]newlist=new String[list.Length];
//String index = "";

//for (int i = 0; i < list.Length; i++)
//{
//    if (list[i] == ".")
//    index +=i.ToString();
//}
//Console.WriteLine(index);


//int j = 0;
//for (int i = 0; i < list.Length; i++)
//{
//    if (list[i]!=".")
//    {
//        newlist[j] = list[i];
//        j++;
//    }
//}
//Console.WriteLine(newlist.Length);
//while (j < list.Length)
//{
//    newlist[j] = ".";
//    j++;
//}

//for (int i = 0;i<newlist.Length; i++)
//{
//    Console.WriteLine(newlist[i]);
//}



//10

//int[] list = { 67, 33, 10, 34, 11 };
//int[]Invertlist=new int[list.Length];
//int index = list.Length-1;

//for (int i = 0; i < list.Length; i++)
//{
//    Invertlist[index] = list[i];
//    index--;
//}

//for (int i = 0;i < list.Length; i++)
//{
//    Console.WriteLine(Invertlist[i]);
//}



//11

//int[] list = { 67, 33, -10, 34, -11 };
//int[] Helptlist = new int[list.Length];
//int right=0;
//int left=list.Length-1;

//for(int i=0; i<list.Length; i++)
//{
//    if (list[i] > 0)
//    {
//        Helptlist[right] = list[i];
//        right++;
//    }
//}

//for(int k=0; k<list.Length; k++)
//{
//    if (list[k] < 0)
//    {
//        Helptlist[left] = list[k];
//        left--;
//    }
//}

//for(int j=0; j<list.Length; j++)
//{
//    Console.WriteLine(Helptlist[j]);
//}



//12

//String[] student = new String[3];
//String[] Numberstudent = new String[3];
//int[]Avgstudent = new int[3];
//int sum = 0;
//int avg = 0;
//String index = "";

//for (int i = 0; i < student.Length; i++)
//{
//    Console.Write("Enter your names student:");
//    student[i] = Console.ReadLine();
//}

//for (int i = 0; i < Numberstudent.Length; i++)
//{
//    Console.Write("Enter your Numberstudents student:");
//    Numberstudent[i] = Console.ReadLine();
//}

//for (int i = 0; i <Avgstudent.Length; i++)
//{
//    Console.Write("Enter your Avgstudents student:");
//    Avgstudent[i] = int.Parse(Console.ReadLine());
//    sum += Avgstudent[i];
//    avg = sum / Avgstudent.Length;
//}

//for (int i = 0;i < Avgstudent.Length; i++)
//{
//    if(Avgstudent[i] > avg)
//    {
//        index += i;
//    }
//}
//Console.WriteLine(index.Length);
//for (int i = 0;i<student.Length ; i++)
//{
//    if (i == int.Parse(index.Substring(index.Length-1, 1))) 
//    {
//        Console.WriteLine("Name:" + student[i]);
//        Console.WriteLine("Numberstudent:"+ Numberstudent[i]);
//        Console.WriteLine("Avgstudent:"+ Avgstudent[i]);
//    }
//}



//13

//int[] list1 =new int[5];
//int[] list2 = new int[5];
//int checklist = 0;
//int count = 0;
//String[] repetition = new string[5];

//for(int i=0; i<list1.Length; i++)
//{
//    Console.WriteLine("Enter your numberlist1:");
//    list1[i]=int.Parse(Console.ReadLine());
//}

//for (int k = 0; k < list1.Length;k++)
//{
//    Console.WriteLine("Enter your numberlist2:");
//    list2[k] = int.Parse(Console.ReadLine());
//}


//for (int i = 0; i < list1.Length; i++)
//{
//    checklist = list1[i];
//    for (int j = 0; j < list2.Length; j++)
//    {
//        if (checklist == list2[j])
//        {
//            count++;
//        }
//    }

//    if (count > 0)
//    {
//        for (int j = 0; j < list1.Length; j++)
//        {
//            repetition[j] = checklist.ToString();
//        }
//    }
//    count = 0;
//}

//for (int i = 0;i < list1.Length; i++)
//{
//    Console.WriteLine(repetition[i]);
//}


