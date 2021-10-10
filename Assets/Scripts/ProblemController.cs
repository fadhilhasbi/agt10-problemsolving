using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProblemController : MonoBehaviour
{
    [SerializeField] private Button _problem1Button;
    [SerializeField] private Button _problem2Button;
    [SerializeField] private Button _problem3Button;
    [SerializeField] private Button _problem4Button;
    [SerializeField] private Button _problem5Button;
    [SerializeField] private Button _problem6Button;
    [SerializeField] private Button _problem7Button;
    [SerializeField] private Button _problem8Button;
    [SerializeField] private Button _problem9Button;

    private void Start()
    {
        _problem1Button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });
        _problem2Button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(2);
        });
        _problem3Button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(3);
        });
        _problem4Button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(4);
        });
        _problem5Button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(5);
        });
        _problem6Button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(6);
        });
        _problem7Button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(7);
        });
        _problem8Button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(8);
        });
        _problem9Button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(9);
        });
    }
}
