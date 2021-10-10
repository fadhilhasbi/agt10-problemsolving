using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDestroyTimes : MonoBehaviour
{
    // Untuk script ini time digunakan secara instan tanpa menunggu object prefab didestroy
    [SerializeField]
    private float time = 3f; //Menentukan waktu spawn

    public GameObject[] Collectibles; //Menyimpan banyak/size prefab gameobject

    float randVert, randHoriz, randTotal; //Menentukan variable random vertical, horizontal, dan total untuk posisi spawn

    private void Start()
    {
        StartCoroutine(SpawnCollectible()); //Menjalankan function Coroutine untuk spawn collectibles
    }

    IEnumerator SpawnCollectible()
    {
        randTotal = Random.Range(4, 16);
        for (int i = 0; i < randTotal; i++)
        {
            randVert = Random.Range(3.48f, -3.48f);
            randHoriz = Random.Range(6.26f, -6.26f);

            //Create spawn collectibles berdasarkan waktu yang sudah ditentukan dan posisi random yang didapatkan
            Instantiate(Collectibles[Random.Range(0, Collectibles.Length)], new Vector2(randHoriz, randVert), Quaternion.identity);
            yield return new WaitForSeconds(time);
            StartCoroutine(SpawnCollectible());
        }

    }
}
