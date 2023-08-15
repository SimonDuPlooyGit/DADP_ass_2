using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletingTiles : MonoBehaviour
{
    [SerializeField]
    private GameManager _gameManager;

    [SerializeField]
    private PlaceSystem _placeSystem;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
            for (int i = 0; i < walls.Length; i++)
            {
                Destroy(walls[i]);
            }

            _gameManager.numTilesPlaced = 0;
            _placeSystem.cornerTiles = _placeSystem.cornerTilesTotal;
            _placeSystem.straightTiles = _placeSystem.straightTilesTotal;
            _placeSystem.cornerTilesUsed = 0;
            _placeSystem.straightTilesUsed = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    _gameManager.GetComponent<GameManager>().occupiedArray[i, j] = false;
                }
            }
            
            _gameManager.GetComponent<GameManager>().occupiedArray[5,0] = true;
            _gameManager.GetComponent<GameManager>().occupiedArray[4,2] = true;
            _gameManager.GetComponent<GameManager>().occupiedArray[5,4] = true;
            _gameManager.GetComponent<GameManager>().occupiedArray[5,5] = true;
            _gameManager.GetComponent<GameManager>().occupiedArray[2,2] = true;
            _gameManager.GetComponent<GameManager>().occupiedArray[2,3] = true;
            _gameManager.GetComponent<GameManager>().occupiedArray[2,4] = true;
            _gameManager.GetComponent<GameManager>().occupiedArray[0,5] = true;
        }        
    }
}
