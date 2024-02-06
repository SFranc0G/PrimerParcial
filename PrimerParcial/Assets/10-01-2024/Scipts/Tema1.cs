using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema1 : MonoBehaviour
{
    //VARIABLES GLOBALES
    //Variable: Es un contenedor de información
    public int edad = 25;

    
    void Start()
    {
        //VARIABLES LOCALES 
        int resultado = suma(5, 5);

        Debug.Log("El resultado es: " + resultado);

    }

    
    void Update()
    {
        
    }
    public void walk(/*Parametros*/)
    {

    }
    int suma (int x, int y)
    {
        return x + y;
    }
}
