using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : EnemyBase
{
    // Start is called before the first frame update
    void Start()
    {
        Init();
        AddLoot("Casco");
        AddLoot("Pala");
        AddLoot("Zanahoria");
        AddLoot("Lingote de hierro");

        for (int i = 0; i < GetLoot().Count; i++)
        {
            Debug.Log(GetLoot()[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
