using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Problem 9
public class TimeManager : MonoBehaviour
{
    public Text TextTimer;
    public float Times = 60;
    float s;

    public bool GameActive = true;
    public GameObject GameOverCanvas;

    void SetText()
    {
        int Minutes = Mathf.FloorToInt(Times / 60);
        int Seconds = Mathf.FloorToInt(Times % 60);

        TextTimer.text = Minutes.ToString("00") + ":" + Seconds.ToString("00");
    }

    private void Update()
    {        
        if (GameActive)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Times--;
                s = 0;
            }
        }
        
        if (GameActive && Times <= 0)
        {
            GameOverCanvas.SetActive(true);
            GameActive = false;
        }

        SetText();
    }
}
