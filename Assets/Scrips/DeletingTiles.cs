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
        }        
    }
}
