using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  EspadaMadera : EspadaBase
{
    void Start()
    {
        Setup("Madera", 5, 3);
    }
}
public enum Rarity
{
    Base= 0,
    Wood = 1,
    STONE = 2,
    IRON = 3,
    GOLD = 4,
    DIAMOND = 5,
    NETHERITE = 6
}
public enum Enchantment
{
    None = 0,
    Fire = 1,
    Throw = 2
}
public class EspadaBase: MonoBehaviour
{
    public Sprite icon;
    public Rarity rarity;
    public Enchantment enchanment;
    public string Name;
    public int Damage;
    public int Durability;

    public void Start()
    {
        GetComponent<SpriteRenderer>().sprite = icon;
    }
    public virtual void Setup(string _name, int _damage, int _durability)
    {
        Name = _name;
        Damage = _damage;
        Durability = _durability;
        GetComponent<SpriteRenderer>().sprite = icon;
    }
    public virtual int GetAttack() { return 0; }
}
