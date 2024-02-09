using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileSystem : MonoBehaviour
{
    public static FileSystem Instance;
    public void Awake()
    {
        if (Instance != null)
        {
            return;
        }
        else
        {
            Instance = this;
        }
    }
    public void CreateFile(string _name, string _extension)
    {
        // 1. Definir el path de la aplicaci�n/archivo
        string path = Application.dataPath + "/" + _name + _extension;
        // 2. Revisamos si el archivo en el path no existe
        if (!File.Exists(path))
        {
            //  3. Crear el contenido
            string content = "Login Date: " + System.DateTime.Now + "\n";
            // 4. Almacenar la informaci�n
            File.AppendAllText(path, content);

        }
        else
        {
            Debug.LogWarning("Atenci�n: Estas tratando de crear un archivo con el mismo nombre[" + _name + _extension + "]verifica tu informaci�n");


        }
    }

    public void CreateFile(string _name, string _extension, Vector3 _vec)
    {

        string path = Application.dataPath + "/" + _name + _extension;

        // 2. Revisamos si el archivo en el path no existe
        if (!File.Exists(path))
        {

            string content = _vec.ToString() + "\n";
            Debug.Log("Se almacen� la informaci�n:" + content);

            File.AppendAllText(path, content);

        }
        else
        {
            Debug.LogWarning("Atenci�n: Estas tratando de crear un archivo con el mismo nombre[" + _name + _extension + "]verifica tu informaci�n");


        }
    }
    private void Start()
    {
        CreateFile("26Ene2024", ".save");
    }

}
