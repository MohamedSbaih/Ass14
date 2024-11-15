using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ass14
{
    

public class Character : MonoBehaviour
{
//? Initial value
        private string name = "Mohamed";
        private int health = 100;

//? Constructor to set-up character
    public Character(string name, int health){
        this.name = name;
        this.health = conditionHealth(health);
    }
    

//? Getter & Setter
        public string nameEdit {
            get {return name;}
            set {name = value;}
            
        }
        
        public int healthEdit {
             get {return health;}
            set{health = conditionHealth(value) ;}

        }


        //? Method to get right value 
        public int conditionHealth(int value){
            if(value > 100){
                return 100;
            }else if(value < 0){
                return 0;
            }else{
                return value;
            }
        }
        

}
  
}
