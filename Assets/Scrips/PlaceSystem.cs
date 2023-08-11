using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSystem : MonoBehaviour
{
    [SerializeField] private Grid grid;
    
    [SerializeField] private GameObject gridHighlight;
    
    [SerializeField] private GameObject mouseCursor;
    
    [SerializeField] private InputManager _inputManager;

    private void Update()
    {
        Vector3 mousePosition = _inputManager.GetSelectedPos();
        Vector3Int gridPosition = grid.WorldToCell(mousePosition);
        Debug.Log("MousePos");
        Debug.Log(mousePosition);
        Debug.Log("GridPos");
        Debug.Log(gridPosition);
        gridHighlight.transform.position = grid.CellToWorld(gridPosition);
        mouseCursor.transform.position = mousePosition;
    }
}
