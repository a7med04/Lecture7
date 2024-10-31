using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oop : MonoBehaviour
{
    void Start()
    {
        Fun();
        int t = TTime();
        Debug.Log(t);
    //    int s = AddNumbers(1,2);
        Debug.Log(AddNumbers(1,2));
    }

    void Fun(){
        Debug.Log("a77777");
        Debug.Log("a77777");
    }

    int TTime(){ // no input only output
        return 5;
    }

    int AddNumbers(int num1, int num2){
        int sum = num1 + num2;
        return sum;
    }


}
