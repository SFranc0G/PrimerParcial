using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
   [Header("Clase Derivada")]
   public string Raza;
    void Start()
    {
       // Name = "Aragaza";
        Display();

    }

    
    void Update()
    {
        move();
    }

    /// <summary>
    /// Brief: This class is in charge of overriding the move method from
    ///the base class "Animal"
    ///Use:
    /// </summary>
   /* void override void move()
    {
        base.move();
    }
   */

}
