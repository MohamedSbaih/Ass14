using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ass14
{
    

public class Enemy : Character
{
    //? Constructor Player to fixed error
    public Enemy(string name,int health):base(name,health){}

//? Method to decrease health
    public void Attack(int amount){
        healthEdit -= amount;
    }
}
}