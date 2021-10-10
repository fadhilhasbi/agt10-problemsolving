using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{    
    [SerializeField]
    private float time = 2f; //Menentukan waktu spawn

    public GameObject[] Collectibles; //Menyimpan banyak/size prefab gameobject

    public Vector3 center; //Menentukan posisi center spawn
    public Vector3 size; // Menentukan ukuran vector3 untuk posisi spawn

    private void Start()
    {
        StartCoroutine(SpawnCollectible()); //Menjalankan Function Coroutine untuk spawn collectibles
    }

    IEnumerator SpawnCollectible()
    {
        //Menetapkan posisi berdasarkan variabel yang diinisiasi
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), 0);

        //Create spawn collectibles berdasarkan waktu yang sudah ditentukan dan posisi random yang didapatkan
        Instantiate(Collectibles[Random.Range(0, Collectibles.Length)], pos, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnCollectible());
    }
}
