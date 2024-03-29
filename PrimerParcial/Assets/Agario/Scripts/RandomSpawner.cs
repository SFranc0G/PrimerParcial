using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [Header("Configuration")]
    public List<GameObject> Prefabs;
    public float TimeBetweenRounds = 3;
    public int SpawnArea = 5;

    [Header("Debug")]
    public Vector3 SpawnerPosition;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateRandomObject", 0f, TimeBetweenRounds);
    }

    public void InstantiateRandomObject()
    {
        //1. generar una posici�n aleatoria dentro del area
        Vector3 RandomPosition = Random.insideUnitCircle * SpawnArea;
        RandomPosition.z = 0;

        //2. Instanciar el objeto en la posici�n generada
        GameObject RandomObj = Prefabs[Random.Range(0, Prefabs.Count)];
        GameObject NewObject = Instantiate(RandomObj, SpawnerPosition + RandomPosition, Quaternion.identity);

        //3. Asignar un color aleatorio al material del sprite
        SpriteRenderer spriteRenderer = NewObject.GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }

        //4. Almacenamos o asignamos el padre del objeto instanciado
        NewObject.transform.parent = transform;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(SpawnerPosition, SpawnArea);
    }
}
