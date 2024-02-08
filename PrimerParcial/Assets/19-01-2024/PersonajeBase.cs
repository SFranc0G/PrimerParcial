using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1. Crear una clase personaje base
public class PersonajeBase : MonoBehaviour
{
    public bool isDead = false;
    protected float health = 100f;

    public float GetHealth()
    {
        return health;
    }

}
    //2. Crear una clase Heroe -z PersonajeBase

    public struct Quest
    {
        public int id;
        public string name;
        public string title;
        public string description;
    }

    public class Heroe : PersonajeBase
    {
        private Quest quest;

        public void setQuest(string _name, string _description, string _title)
        {
            quest.id = Random.Range(0, 10);
            quest.name = _name;
            quest.description = _description;
            quest.title = _title;
        }

        public Quest getQuest() 
        {
            return quest; 
        }

    }

    //3. Crear una clase Caballero -z PersdonajeBase
    public class EnemigoBase: PersonajeBase
    {
      protected float damage = 450;

      public float getDamage() { return damage; }
    }

    //4. Crear una calse Caballero -z EnemigoBase
    public class Caballero : EnemigoBase
    {
        private float powerUp = Random.Range(0, 450);

        public float getPowerUp()  { return damage + powerUp; }
     
    }

    //5. Crear una clase HeroeFuerte -z Heroe
    public class HeroeFuerte: Heroe
    {
        public float hability = 300f;

        public float getHability() { if (getQuest().id == 2) { return hability - 20.0f; } return hability;}
    }

    //6. Crear una clase ajena a los scripts de arriba llamada Accesos
    class Notes: MonoBehaviour
    {
        public HeroeFuerte heroeFuerte;
        public Caballero caballero;

        private void Start()
        {
            heroeFuerte = new HeroeFuerte();
            caballero = new Caballero();

            heroeFuerte.setQuest("Quest 1", "El uso de atributos en clases", "Clasificación de atributos, el gran desafío");

            if(!heroeFuerte.isDead && !caballero.isDead)
            {
                if (heroeFuerte.GetHealth() >=51)
                {
                    float combatResult = heroeFuerte.getHability() -caballero.getDamage();

                    Debug.Log("El resultado del combate es: " + combatResult);

                }
                else
                {
                    Debug.Log("El heroe tiene muy poca vida, regresa a la base. Vida: " + heroeFuerte.GetHealth());
                }
            }
        }
    }
