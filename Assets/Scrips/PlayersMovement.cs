using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
    [SerializeField] private Grid grid;
    public GameManager _gameManager;
    
    public float speed = 1f;
    void Update()
    {
        Vector3 movePos = transform.position;

        if (Input.GetKey("w"))
        {
            movePos.y += speed * Time.deltaTime;
        }
        
        if (Input.GetKey("s"))
        {
            movePos.y -= speed * Time.deltaTime;
        }
        
        if (Input.GetKey("a"))
        {
            movePos.x -= speed * Time.deltaTime;
        }
        
        if (Input.GetKey("d"))
        {
            movePos.x += speed * Time.deltaTime;
        }

        transform.position = movePos;
        
        Vector3Int gridPosition = grid.WorldToCell(transform.position);

        if (_gameManager.occupiedArray[gridPosition.x, gridPosition.y] == false)
        {
            _gameManager.switchToBuilding();
        }
        
    }
}
