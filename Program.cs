

#region Task1

//int[] array1 = { 2, 3, 5, 4, 5, 6, 7 };
//int[] array2 = { 1, 1, 9, 6, 8, 11, 7 };

//var diffEl = array1.Except(array2).ToArray();
//foreach (var item in diffEl)
//{
//    Console.WriteLine(item);
//}

//Custom//

//static void FindDifference(int[] firstArray, int[] secondArray)
//{
//    int count = 0;
//    int[] difference = new int[firstArray.Length];

//    foreach (var item1 in firstArray)
//    {
//        bool found = false;

//        foreach (var item2 in secondArray)
//        {
//            if (item1 == item2)
//                found = true;
//            break;
//        }

//        if (!found)
//        {
//            difference[count++] = item1;
//        }
//    }
//    Array.Resize(ref difference, count);

//    foreach (var item in difference)
//    {
//        Console.Write(item + " ");
//    }
//}
//FindDifference(array1, array2);

#endregion

#region Task2


//using ClassHometask2.Modes;

//Product product = new Product ("IPhone 13")
//{
//    Count = 10,
//    Price =1500
//};

//product.Sell(3);

//Console.WriteLine($"Latest situation - Selled {product.Name} , Stock: {product.Count}, Income {product.TotalIncome}");
#endregion

#region Task3
//using ClassHometask2.Modes;

//Console.WriteLine("Enter you username: ");
//string username = Console.ReadLine();
//Console.WriteLine("Enter your password: ");

//string password = Console.ReadLine();

//User user = new User(username, password);



//Console.WriteLine($" Username is : {user.userName} Password is : {user.myPassword}");
#endregion

#region Task4

//static string CalcAvg(int[] array)
//{
//    int sum = 0;
//    int average = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        sum += array[i];
//        average = sum / array.Length;
//    }

//    if (average > 60)
//    {
//        return "Mezun oldunuz";
//    }
//    else
//    {
//        return "Mezun ola bilmediniz";
//    }
//    return null;
//}

//int[] myarray = { 22, 3, 44, 55,100,200 };

//Console.WriteLine(CalcAvg(myarray));
#endregion

#region Task5

//static double Sale(double price1, double price2, double price3)
//{
//    double totalPrice=0;

//    if (price1<price2 && price1<price3)
//    {
//        totalPrice = price2 + price3;
//    }else if(price2<price3 && price2 < price1)
//    {
//        totalPrice = price3 + price1;
//    }else if(price3<price2 && price3 < price1)
//    {
//        totalPrice=price2 + price1;
//    }

//    return totalPrice;

//}
//Console.WriteLine(Sale(30,20,10));

//secondWay/////// =>
//static double SaleIn(double price1, double price2, double price3)
//{
//    double[] prices = { price1, price2, price3 };
//    double totalPrice;

//    //sorting array
//    Array.Sort(prices);

//    totalPrice = prices[1] + prices[2];

//    return totalPrice;

//}

//Console.WriteLine(SaleIn(50, 40, 10));
#endregion

