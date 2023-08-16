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

    private void Update()
    {
        PlayLevel.text = "Play Level: " + (_gameManager.Level + 1);
    }
}
