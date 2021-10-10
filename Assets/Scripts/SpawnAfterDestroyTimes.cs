using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnAfterDestroyTimes : MonoBehaviour
{

    public GameObject[] Collectibles; //Menyimpan banyak/size prefab gameobject
    public Text scoreCounter;

    private readonly float time = 3f; //Menentukan waktu spawn
    private int score;

    void Start()
    {
        StartCoroutine(SpawnCollectible());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            Collect(other.GetComponent<GetCollectible>());

            StartCoroutine(SpawnCollectible());
        }
    }

    private void Collect(GetCollectible collectible)
    {
        if (collectible.Collect())
        {
            if (collectible is GetCollectible)
            {
                score += 10;
            }
            UpdateGUI();
        }
    }

    private void UpdateGUI()
    {
        scoreCounter.text = ("Score: ") + score.ToString();
    }

    IEnumerator SpawnCollectible()
    {
        yield return new WaitForSeconds(time);
        Instantiate(Collectibles[Random.Range(0, Collectibles.Length)], new Vector2(Random.Range(6.26f, -6.26f), Random.Range(3.48f, -3.48f)), Quaternion.identity);
    }
}
