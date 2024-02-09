using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase base para las espadas
public class Sword : MonoBehaviour
{
    public string Name;
    public int Damage;

    public Sword(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public virtual void Attack()
    {
        Debug.Log($"Regular attack with {Name}. Damage: {Damage}");
    }
}

// Clases derivadas ordenadas por rareza
public class WoodenSword : Sword
{
    public WoodenSword() : base("Wooden Sword", 10) { }
}

public class StoneSword : Sword
{
    public StoneSword() : base("Stone Sword", 20) { }
}

public class IronSword : Sword
{
    public IronSword() : base("Iron Sword", 30) { }
}

public class DiamondSword : Sword
{
    public DiamondSword() : base("Diamond Sword", 40) { }
}

public class GoldenSword : Sword
{
    public GoldenSword() : base("Golden Sword", 50) { }
}
public class NetheriteSword : Sword
{
    public NetheriteSword() : base("Netherite Sword", 70) { }
}

// Clase derivada que hace daño de fuego
public class FireSword : Sword
{
    public FireSword() : base("Fire Sword", 35) { }

    public override void Attack()
    {
        Debug.Log($"Attacking with {Name}! Damage: {Damage}. Inflicts fire damage.");
    }
}

// Clase derivada que hace daño normal
public class NormalSword : Sword
{
    public NormalSword() : base("Normal Sword", 25) { }


}