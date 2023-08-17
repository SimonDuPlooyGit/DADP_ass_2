using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chekpunt : MonoBehaviour
{
    public GameManager _gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _gameManager.checkpoint = true;
        }
    }
}
