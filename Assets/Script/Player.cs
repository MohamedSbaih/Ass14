using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ass14
{
    

public class Player : Character
{
    //? Constructor Player to fixed error
    public Player(string name, int health):base(name,health){}

//? Method to increase health
 public void Heal(int amount){
    healthEdit += amount;

 }

}
}