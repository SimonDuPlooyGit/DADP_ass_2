using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using TMPro;

public class PlaceSystem : MonoBehaviour
{
    [SerializeField] private Grid grid;
    
    [SerializeField] private GameObject gridHighlight;
    
    [SerializeField] private GameObject mouseCursor;
    
    [SerializeField] private InputManager _inputManager;

    public GameManager _gameManager;

    public TextMeshProUGUI CornerLeftTXT;
    public TextMeshProUGUI StraightLeftTXT;

    public int cornerTiles;
    public int straightTiles;

    public int cornerTilesUsed;
    public int straightTilesUsed;

    public int cornerTilesTotal;
    public int straightTilesTotal;

    public GameObject tileToSpawn;
    public GameObject tileSpawned;

    private float betweenRotation = 0.2f;
    private float time;
    public bool rotateAble = true;

    private void Start()
    {
        cornerTiles = cornerTilesTotal;
        straightTiles = straightTilesTotal;
    }

    private void Update()
    {
        CornerLeftTXT.text = "# Left: " + cornerTiles;
        StraightLeftTXT.text = "# Left: " + straightTiles;

        Vector3 mousePosition = _inputManager.GetSelectedPos();
        Vector3Int gridPosition = grid.WorldToCell(mousePosition);
        gridHighlight.transform.position = grid.CellToWorld(gridPosition);
        mouseCursor.transform.position = mousePosition;

        if (Input.GetKey(KeyCode.R) && rotateAble == true)
        {
            rotateAble = false;

            if (_gameManager.cornerTile == true)
            {
                _gameManager.cornerTImage.transform.Rotate(0, 0, 90);
            }
            else if (_gameManager.straightTile == true)
            {
                _gameManager.straightTImage.transform.Rotate(0, 0, 90);
            }
        }

        if (rotateAble == false)
        {
            time += Time.deltaTime;

            if (time > betweenRotation)
            {
                rotateAble = true;
                time = 0;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (_gameManager.cornerTile == true && cornerTilesUsed < cornerTilesTotal && _gameManager.occupiedArray[gridPosition.x, gridPosition.y] != true)
            {
                _gameManager.occupiedArray[gridPosition.x, gridPosition.y] = true;
                tileToSpawn = _gameManager.currentTile;
                _gameManager.numTilesPlaced++;
                tileSpawned = Instantiate(tileToSpawn, grid.CellToWorld(gridPosition), quaternion.identity);

                tileSpawned.transform.GetChild(0).transform.rotation = _gameManager.cornerTImage.transform.rotation;

                cornerTilesUsed += 1;
                cornerTiles -= 1;
            }
            else if (_gameManager.straightTile == true && straightTilesUsed < straightTilesTotal && _gameManager.occupiedArray[gridPosition.x,gridPosition.y]!= true)
            {
                _gameManager.occupiedArray[gridPosition.x, gridPosition.y] = true;
                tileToSpawn = _gameManager.currentTile;
                _gameManager.numTilesPlaced++;
                tileSpawned = Instantiate(tileToSpawn, grid.CellToWorld(gridPosition), quaternion.identity);

                tileSpawned.transform.GetChild(0).transform.rotation = _gameManager.straightTImage.transform.rotation;

                straightTilesUsed += 1;
                straightTiles -= 1;
            } else if (_gameManager.occupiedArray[gridPosition.x,gridPosition.y] != false)
            {
                Debug.Log("Spot already occupied");
            }
        }
    }
}
