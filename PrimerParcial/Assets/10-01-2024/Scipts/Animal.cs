using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [Header("Clase Base")]
    public string Name = "Animal";
    public float Speed = 5f;
    Vector3 posicionMouse;
    public virtual void move()
    {
        if (Input.GetMouseButtonDown(0)) 
        { 

        //Posicion del mouse 
        posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionMouse.z = 0f;

        }

        //Calcular la direccion y normalizarla
        Vector3 direccion = (posicionMouse - transform.position).normalized;
        if (direccion == transform.position) 
        {
            return;
        }

        //Mover al objeto en la dirección calculada
        transform.Translate(direccion * Speed * Time.deltaTime);
    }

   public virtual void Display()
    {
        Debug.Log("El animal se llama: " + Name);
    }

}
