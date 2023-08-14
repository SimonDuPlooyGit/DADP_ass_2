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

    private void Update()
    {
        Vector3 mousePosition = _inputManager.GetSelectedPos();
        Vector3Int gridPosition = grid.WorldToCell(mousePosition);
        gridHighlight.transform.position = grid.CellToWorld(gridPosition);
        mouseCursor.transform.position = mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            tileToSpawn = _gameManager.GetComponent<GameManager>().currentTile;
            Instantiate(tileToSpawn, grid.CellToWorld(gridPosition), quaternion.identity);
        }
    }
}
