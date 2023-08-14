using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlaceSystem : MonoBehaviour
{
    [SerializeField] private Grid grid;
    
    [SerializeField] private GameObject gridHighlight;
    
    [SerializeField] private GameObject mouseCursor;
    
    [SerializeField] private InputManager _inputManager;

    public GameManager _gameManager;

    public GameObject tileToSpawn;
    public GameObject tileSpawned;

    private float betweenRotation = 0.2f;
    private float time;
    public bool rotateAble = true;

    private void Update()
    {
        Vector3 mousePosition = _inputManager.GetSelectedPos();
        Vector3Int gridPosition = grid.WorldToCell(mousePosition);
        Debug.Log(gridPosition);
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
            tileToSpawn = _gameManager.GetComponent<GameManager>().currentTile;
            _gameManager.GetComponent<GameManager>().numTilesPlaced++;
            tileSpawned = Instantiate(tileToSpawn, grid.CellToWorld(gridPosition), quaternion.identity);

            if (_gameManager.cornerTile == true)
            {
                tileSpawned.transform.GetChild(0).transform.rotation = _gameManager.cornerTImage.transform.rotation;
            }
            else if (_gameManager.straightTile == true)
            {
                tileSpawned.transform.GetChild(0).transform.rotation = _gameManager.straightTImage.transform.rotation;
            }
        }
    }

    /*private bool CanPlaceTile(Vector3Int gridPosition)
    {
        // Convert grid position to world position
        Vector3 worldPosition = grid.CellToWorld(gridPosition);

        // Check if there is an existing tile at the given position
        Collider2D coll = Physics2D.OverlapPoint(worldPosition);

        return coll == null;
    }*/
}
