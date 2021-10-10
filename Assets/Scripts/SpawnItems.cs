using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject[] Collectibles; //Menyimpan banyak/size prefab gameobject

    float randVert, randHoriz, randTotal;
    void Start()
    {
        randTotal = Random.Range(4, 16);
        for (int i = 0; i < randTotal; i++)
        {
            randVert = Random.Range(3.37f, -3.37f);
            randHoriz = Random.Range(6.32f, -6.32f);
            Instantiate(Collectibles[Random.Range(0, Collectibles.Length)], new Vector2(randHoriz, randVert), Quaternion.identity);
        }
    }
}
