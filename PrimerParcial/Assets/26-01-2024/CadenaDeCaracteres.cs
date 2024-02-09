using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadenaDeCaracteres : MonoBehaviour
{
    public GameObject Spawn;
    public string data = "x:2, y:5, z:8";
    public Vector3 position;

    private void Start()
    {
        // 1. Recorrer todo nuestro string =  "x:2, y:5, z:8"
        for (int i = 0; i < data.Length; i++)
        {
            // 2. Revosaremos si el valod en el índice (data[i]), es igual a "x"
            if (data[i] == 'x')
            {
                // 'x' es para caracteres " eaafbe afg" es para enunciados de texto

                // 3. Si, si es el valor, transformaremos el caracter (data[i+2]) a entero

                int x = (int)char.GetNumericValue(data[i + 2]);

                //4. Almacenamos la información de x en nuestro vector posición

                position = new Vector3(x, position.y, position.z);

            }
            if (data[i] == 'y')
            {


                int y = (int)char.GetNumericValue(data[i + 2]);

                // Almacenamos la información de y en nuestro vector posición

                position = new Vector3(position.x, y, position.z);

            }
            if (data[i] == 'z')
            {



                int z = (int)char.GetNumericValue(data[i + 2]);

                //Almacenamos la información de z en nuestro vector posición

                position = new Vector3(position.x, position.y, z);

            }
        }
        FileSystem.Instance.CreateFile("Posiciones", ".save", position);
        Instantiate(Spawn, position, Quaternion.identity);
    }
}
