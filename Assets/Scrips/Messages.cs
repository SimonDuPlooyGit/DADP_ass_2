using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messages : MonoBehaviour
{
    [SerializeField]
    private GameObject messagePanel;

    [SerializeField]
    private GameObject straightMessage;

    [SerializeField]
    private GameObject cornerMessage;

    public float time;
    public float timeLimit = 0.5f;
    public bool message;
    private bool corner;
    private bool straight;

    public PlaceSystem _placeSystem;
    public GameManager _gameManager;

    private void Start()
    {
        messagePanel.SetActive(false);
        straightMessage.SetActive(false);
        cornerMessage.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_placeSystem.cornerTiles == 0 && _gameManager.cornerTile == true)
            {
                message = true;

                cornerMessage.SetActive(true);
                messagePanel.SetActive(true);
                corner = true;
            }

            if (_placeSystem.straightTiles == 0 && _gameManager.straightTile == true)
            {
                message = true;

                straightMessage.SetActive(true);
                messagePanel.SetActive(true);
                straight = true;
            }
        }

        if (message == true)
        {
            time += Time.deltaTime;
        }

        if (time >= timeLimit)
        {
            message = false;
            time = 0;

            messagePanel.SetActive(false);
            straightMessage.SetActive(false);
            cornerMessage.SetActive(false);
        }
    }
}
