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
            delete();
        }        
    }

    public void delete()
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
                    _gameManager.occupiedArray[i, j] = false;
                }
            }

            if (_gameManager.Level == 1)
            {
                //Pain
                _gameManager.occupiedArray[0, 5] = true;
                _gameManager.occupiedArray[0, 4] = true;
                _gameManager.occupiedArray[0, 3] = true;
                _gameManager.occupiedArray[0, 2] = true;
                _gameManager.occupiedArray[0, 1] = true;
                _gameManager.occupiedArray[0, 0] = true;
                _gameManager.occupiedArray[1, 5] = true;
                _gameManager.occupiedArray[1, 4] = true;
                _gameManager.occupiedArray[1, 3] = true;
                _gameManager.occupiedArray[1, 2] = true;
                _gameManager.occupiedArray[1, 1] = true;
                _gameManager.occupiedArray[1, 0] = true;
                _gameManager.occupiedArray[3, 5] = true;
                _gameManager.occupiedArray[3, 4] = true;
                _gameManager.occupiedArray[3, 3] = true;
                _gameManager.occupiedArray[3, 2] = true;
                _gameManager.occupiedArray[3, 1] = true;
                _gameManager.occupiedArray[3, 0] = true;
                _gameManager.occupiedArray[4, 5] = true;
                _gameManager.occupiedArray[4, 4] = true;
                _gameManager.occupiedArray[4, 3] = true;
                _gameManager.occupiedArray[4, 2] = true;
                _gameManager.occupiedArray[4, 1] = true;
                _gameManager.occupiedArray[4, 0] = true;
                _gameManager.occupiedArray[5, 5] = true;
                _gameManager.occupiedArray[5, 4] = true;
                _gameManager.occupiedArray[5, 3] = true;
                _gameManager.occupiedArray[5, 2] = true;
                _gameManager.occupiedArray[5, 1] = true;
                _gameManager.occupiedArray[5, 0] = true;
            }
            else if (_gameManager.Level == 2)
            {
                //Pain
                _gameManager.occupiedArray[0, 5] = true;
                _gameManager.occupiedArray[0, 4] = true;
                _gameManager.occupiedArray[0, 3] = true;
                _gameManager.occupiedArray[0, 2] = true;
                _gameManager.occupiedArray[0, 1] = true;
                _gameManager.occupiedArray[0, 0] = true;
                _gameManager.occupiedArray[1, 5] = true;
                _gameManager.occupiedArray[1, 4] = true;
                _gameManager.occupiedArray[2, 5] = true;
                _gameManager.occupiedArray[2, 4] = true;
                _gameManager.occupiedArray[2, 2] = true;
                _gameManager.occupiedArray[2, 1] = true;
                _gameManager.occupiedArray[2, 0] = true;
                _gameManager.occupiedArray[3, 5] = true;
                _gameManager.occupiedArray[3, 4] = true;
                _gameManager.occupiedArray[3, 2] = true;
                _gameManager.occupiedArray[3, 1] = true;
                _gameManager.occupiedArray[3, 0] = true;
                _gameManager.occupiedArray[4, 5] = true;
                _gameManager.occupiedArray[4, 4] = true;
                _gameManager.occupiedArray[4, 2] = true;
                _gameManager.occupiedArray[4, 1] = true;
                _gameManager.occupiedArray[4, 0] = true;
                _gameManager.occupiedArray[5, 5] = true;
                _gameManager.occupiedArray[5, 4] = true;
                _gameManager.occupiedArray[5, 2] = true;
                _gameManager.occupiedArray[5, 1] = true;
                _gameManager.occupiedArray[5, 0] = true;
            }
            else if (_gameManager.Level == 3)
            {
                //Pain
                _gameManager.occupiedArray[0, 5] = true;
                _gameManager.occupiedArray[0, 4] = true;
                _gameManager.occupiedArray[0, 3] = true;
                _gameManager.occupiedArray[0, 2] = true;
                _gameManager.occupiedArray[1, 5] = true;
                _gameManager.occupiedArray[1, 4] = true;
                _gameManager.occupiedArray[1, 3] = true;
                _gameManager.occupiedArray[1, 0] = true;
                _gameManager.occupiedArray[2, 5] = true;
                _gameManager.occupiedArray[2, 4] = true;
                _gameManager.occupiedArray[2, 1] = true;
                _gameManager.occupiedArray[2, 0] = true;
                _gameManager.occupiedArray[3, 5] = true;
                _gameManager.occupiedArray[3, 2] = true;
                _gameManager.occupiedArray[3, 1] = true;
                _gameManager.occupiedArray[3, 0] = true;
                _gameManager.occupiedArray[4, 3] = true;
                _gameManager.occupiedArray[4, 2] = true;
                _gameManager.occupiedArray[4, 1] = true;
                _gameManager.occupiedArray[4, 0] = true;
                _gameManager.occupiedArray[5, 5] = true;
                _gameManager.occupiedArray[5, 4] = true;
                _gameManager.occupiedArray[5, 3] = true;
                _gameManager.occupiedArray[5, 2] = true;
                _gameManager.occupiedArray[5, 1] = true;
                _gameManager.occupiedArray[5, 0] = true;
            }
            else if (_gameManager.Level == 4)
            {
                //Pain
                _gameManager.occupiedArray[0, 5] = true;
                _gameManager.occupiedArray[0, 4] = true;
                _gameManager.occupiedArray[0, 3] = true;
                _gameManager.occupiedArray[0, 2] = true;
                _gameManager.occupiedArray[0, 1] = true;
                _gameManager.occupiedArray[0, 0] = true;
                _gameManager.occupiedArray[1, 5] = true;
                _gameManager.occupiedArray[1, 4] = true;
                _gameManager.occupiedArray[1, 3] = true;
                _gameManager.occupiedArray[2, 5] = true;
                _gameManager.occupiedArray[2, 4] = true;
                _gameManager.occupiedArray[2, 3] = true;
                _gameManager.occupiedArray[2, 1] = true;
                _gameManager.occupiedArray[2, 0] = true;
                _gameManager.occupiedArray[3, 5] = true;
                _gameManager.occupiedArray[3, 1] = true;
                _gameManager.occupiedArray[3, 0] = true;
                _gameManager.occupiedArray[4, 5] = true;
                _gameManager.occupiedArray[4, 3] = true;
                _gameManager.occupiedArray[4, 1] = true;
                _gameManager.occupiedArray[4, 0] = true;
                _gameManager.occupiedArray[5, 5] = true;
                _gameManager.occupiedArray[5, 1] = true;
                _gameManager.occupiedArray[5, 0] = true;
            }
            else if (_gameManager.Level == 5)
            {
                //Pain
                _gameManager.occupiedArray[0, 5] = true;
                _gameManager.occupiedArray[2, 4] = true;
                _gameManager.occupiedArray[2, 3] = true;
                _gameManager.occupiedArray[2, 2] = true;
                _gameManager.occupiedArray[4, 2] = true;
                _gameManager.occupiedArray[5, 5] = true;
                _gameManager.occupiedArray[5, 4] = true;
                _gameManager.occupiedArray[5, 0] = true;
            }
            else if (_gameManager.Level == 6)
            {
                //Pain
                _gameManager.occupiedArray[0, 5] = true;
                _gameManager.occupiedArray[0, 4] = true;
                _gameManager.occupiedArray[1, 5] = true;
                _gameManager.occupiedArray[1, 4] = true;
                _gameManager.occupiedArray[2, 2] = true;
                _gameManager.occupiedArray[3, 3] = true;
                _gameManager.occupiedArray[4, 1] = true;
                _gameManager.occupiedArray[4, 0] = true;
                _gameManager.occupiedArray[5, 1] = true;
                _gameManager.occupiedArray[5, 0] = true;
            }
            else if (_gameManager.Level == 7)
            {
                //Pain
                _gameManager.occupiedArray[2, 5] = true;
                _gameManager.occupiedArray[2, 4] = true;
                _gameManager.occupiedArray[2, 1] = true;
                _gameManager.occupiedArray[2, 0] = true;
                _gameManager.occupiedArray[5, 5] = true;
                _gameManager.occupiedArray[5, 0] = true;
            }
            else if (_gameManager.Level == 8)
            {
                //Pain
                _gameManager.occupiedArray[1, 2] = true;
                _gameManager.occupiedArray[1, 3] = true;
                _gameManager.occupiedArray[4, 2] = true;
                _gameManager.occupiedArray[4, 3] = true;
            }
    }

    public void justDelete()
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
                _gameManager.occupiedArray[i, j] = false;
            }
        }
    }
    
}
