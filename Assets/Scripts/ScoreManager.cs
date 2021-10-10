using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Problem 7
public class ScoreManager : MonoBehaviour
{
    public Text scoreCounter;

    private int score;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            Collect(other.GetComponent<GetCollectible>());
        }
    }

    private void Collect(GetCollectible collectible)
    {
        if (collectible.Collect())
        {
            if(collectible is GetCollectible)
            {
                score+=10;
            }
            UpdateGUI();
        }
    }

    private void UpdateGUI()
    {
        scoreCounter.text = ("Score: ") + score.ToString();
    }
}
