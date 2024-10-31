using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taskCSHARP : MonoBehaviour
{
   
    //دالة لكتابة جدول ضرب رقم 5
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    void Start()
    {

        int i;
        for (i = 1; i <= 10; i++)
        {
            int result = Multiply(5 , i);
            Debug.Log("5 *"+i+" ="+ result);
        }

}

}










    // دالة لفحص ما اذا كان الرقم بوزيتيف اور نيجتف
    //معناش وقت نكمل
    // public bool IsPositive(int number){
    //     return number>0;
    // }

// دالة لتربيع الرقم
    // public int Square(int number)
    // {
    //     return number * number;
    // }

//جدول رقم تلاتة
    // public int Add(int a, int b){
    //     return (a+b);
    // }

  //لطباعة تربيع الرقم
        // int i;
        // for(i=1; i<=10; i++){
        //     int result=Square(i);
        //     Debug.Log("The square of " + i + " is: " + result);
    
//جدول رقم تلاتة
    // int i;
    // for(i=1; i<=10; i++){
    //     int result =Add(3,i);
    //     Debug.Log("3 + "+i +"=" + result);
    // }



//دالة لطرح رقمين
// public int AddNumbers(int a, int b) //Q1
// {
//     int result = a + b;
//     return result;
// }
//=======================================
// public int SubtractNumbers(int a, int b)//Q2
// {
//     int result = a - b;
//     return result;
// }

//=======================================

//دالة للتحقق من عدد زوجي أو فردي


// public bool IsEven(int number)
// {
//     if (number % 2 == 0)
//     {
//         return true;
//     else
//         {
//             return false;
//         }
//     }
// }

//دالة لفحص ما اذا كان الرقم فردي ولا زوجي
// static void Start()
// {
//     int num = 5;
//     bool result = IsEven(num);
//     Debug.Log(result);
//     num = 10;
//     result = IsEven(num);
//     Debug.Log(result);

// int sum = AddNumbers(2, 5); //Q1
// Debug.Log(sum);

//=======================================
// int sub = SubtractNumbers(10, 4);
// Debug.Log(sub);//Q2

//بنقدر نكتب هيك
//static bool IsEven(int number)
// {
//     return number % 2 == 0;
// }




//=======================================
// int numbers = 10;
// if (numbers > 0)
// {
//     Debug.Log("Mojab");
//     if (numbers % 2 == 0)
//     {
//         Debug.Log("zawji");

//  } else
//         {
//             Debug.Log("fardi");
//         }


// }else{
//     Debug.Log("saleb");
// }


//     }

// }



