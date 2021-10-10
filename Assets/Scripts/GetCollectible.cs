using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Problem 7
public class GetCollectible : MonoBehaviour
{
    private bool isCollected = false;

    public bool Collect()
    {
        if (isCollected)
            return false;
        isCollected = true;
        Destroy(gameObject);
        return true;
    }
}
