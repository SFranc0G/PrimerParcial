using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    public string Name = "Name";
    public float speed = 5f;
    public float AreaDetection = 2f;
    public Vector3 MousePosition;

    //public void Update()
    //{
    //    move();
    //}
    public virtual void move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Acedemos a la posicion del mouse
            MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            MousePosition.z = 0;
        }
        //Calculamos la direccion
        Vector3 direction = (MousePosition - transform.position).normalized;    

        //Mover al objeto en la direccion calculada
        transform.Translate(direction*speed*Time.deltaTime);
    }
}
