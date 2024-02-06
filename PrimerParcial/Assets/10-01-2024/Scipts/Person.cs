using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    protected string ssn = "44-55-6666";
    protected string Name = "John L. Malgraine";

    public virtual void GetInfo()
    {
        Debug.Log("Name: " + Name);
        Debug.Log("SSN: " +  ssn);

    }
}
