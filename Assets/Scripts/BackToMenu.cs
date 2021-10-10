using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    [SerializeField] private Button _backHomeButton;

    private void Start()
    {
        _backHomeButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(0);
        });
    }
}
