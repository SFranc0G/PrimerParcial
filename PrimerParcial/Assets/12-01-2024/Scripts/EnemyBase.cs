using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField]
    public string Name = "Enemy";
    [SerializeField]
    protected int Health = 100;
    [SerializeField]
    protected List<string> Loot;
    /*
     * GAMELOOP/Order of Execution
     * 
     * Init(); - También conocido como "Start"
     * 
     * Update(); - Actualización lógica, combina render y lógica
     * 
     * Render(); - Presenta en pantalla todo lo que estemos programando
     * 
     * Destroy(); -  Eliminar recursos de la memoria
     * 
     */

    /// <summary>
    /// This method is in charge of initializing the members of the class;
    /// </summary>
    public virtual void Init()
    {
        Loot = new List<string>();

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Item"></param>
    public virtual void AddLoot(string Item)
    {
        Loot.Add(Item);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public virtual List<string> GetLoot()
    {
        return Loot;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public virtual int GetHealth()
    {
        return Health;
    }


}
