using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ass14
{
public class NewBehaviourScript : MonoBehaviour
{
   void Start()
    {
        //? Create 2 object Player & Enemy
        Player player = new Player("Mohamed",90);
        Enemy enemy = new Enemy("Villain",100);

        //? Print name and health like object
        Debug.Log($"The name of player is {player.nameEdit} and the health is {player.healthEdit}");
        Debug.Log($"The name of player is {enemy.nameEdit} and the health is {enemy.healthEdit}");
        
        //? invite attack method & print new value
        enemy.Attack(5);
        Debug.Log($"The name of player is {enemy.nameEdit} and the health is {enemy.healthEdit}");

        //? invite heal method & print new value
        player.Heal(5);
        Debug.Log($"The name of player is {player.nameEdit} and the health is {player.healthEdit}");
        
    }
}
}