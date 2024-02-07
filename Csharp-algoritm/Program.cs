//int n = 21;
//if (n %3==0 && n % 7 == 0)
//{
//    Console.WriteLine(n  + " 3  v ye 7 bolunur");
//}
//else
//{
//    Console.WriteLine(n + " 3 ve ye 7 bolunmur");
////}

//task2
//int n = 2;
//int m = 10;
//if (n % 2 == 0 && m % 2 == 0)
//{
//    int cem = n + m;
//    Console.WriteLine("cem " + cem);
//}
//else
//{
//    Console.WriteLine("n ve me ededleri cut olmalidir");
//}
//task3
//int n = 1;
//int m = 10;
//int sum = 0;
//for (int i = n+1 ; i <= m; i++)
//{
//    if (i % 2 != 0)
//    {
//        sum+= 1;    
//    }
//}
//Console.WriteLine( "n ve m ededeleri arasindaki tek ededelerin cemi:" + sum);

//Task5
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine("cut eddelerin sayi:" +count);

//Task 4
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] %2 != 0)
//    {
//        sum += arr[i];
//    }
//}
//Console.WriteLine("Tek ededelerin cemi:"+sum);

//Task 6
//int n = 1;
//int m = 10;
//int count = 0;
//for (int i = n + 1; i < m; i++)
//{
//    if (i % 2 != 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine( "tek eddelerin saysi:"+ count);
//Task 7
//int n = 1;
//int m = 10;

//int sum = 0;
//for (int i = n + 1; i < m; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }
//}
//Console .WriteLine(sum);
//Task 8
//int n = 1;
//int m = 10;
//int count = 0;
//for (int i = n + 1; i < m; i++)
//{
//    if (i %2== 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
//Task 9
int num = 1;
if (num <= 1 || num % 2 == 0)
{
    Console.WriteLine("eded murekkebdir");
}
else
{
    Console.WriteLine("sade");
}