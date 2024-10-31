
using System;
using UnityEngine;

public class Player 
{
    string name;
    int health;

    void PrintPlayer(){
        Debug.Log(name);

    }

    void AddHealth(int value){
        health += value;
    }

    void SubHealth (int value){
        health -= value;
    }

}
