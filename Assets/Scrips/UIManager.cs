using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject betweenMenu;
    public TextMeshProUGUI PlayLevel;
    public GameObject Enter;
    public GameObject LevelComplete;

    public GameManager _gameManager;

    public GameObject One;
    public GameObject Two;
    public GameObject Three;
    public GameObject Four;
    public GameObject Five;
    public GameObject Six;
    public GameObject Seven;
    public GameObject Eight;

    private void Start()
    {
        One.SetActive(false);
        Two.SetActive(false);
        Three.SetActive(false);
        Four.SetActive(false);
        Five.SetActive(false);
        Six.SetActive(false);
        Seven.SetActive(false);
        Eight.SetActive(false);
    }

    private void Update()
    {
        PlayLevel.text = "Play Level: " + (_gameManager.Level + 1);
    }
}
