using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject currentTile;
    public GameObject player;
    public List<GameObject> tileSet;
    public TextMeshProUGUI pathText;
    public GameObject highlight;
    public GameObject cursor;
    public Canvas buildUI;
    
    public GameObject cornerTImage;
    public GameObject straightTImage;

    public bool cornerTile;
    public bool straightTile;
    public bool minLengthMet;

    public int numTilesPlaced = 0;
    public int minPathLength = 10;

    public Camera mainCam;
    private bool building;
    private bool moving;

    public Vector3 playerSpawn = new Vector3(-3.75f, -3.75f, -1f);

    void Start()
    {
        Cursor.visible = false;
        building = true;
        moving = false;
        player.SetActive(false);

        var resources = Resources.LoadAll("Tiles", typeof(GameObject));

        foreach (GameObject obj in resources)
        {
            tileSet.Add(obj);
        }
        
        cornerTImage.SetActive(false);
        straightTImage.SetActive(false);
        minLengthMet = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            cornerTImage.SetActive(true);
            straightTImage.SetActive(false);

            cornerTile = true;
            straightTile = false;
            currentTile = tileSet[0];
        }

        if (Input.GetKeyDown("2"))
        {
            cornerTImage.SetActive(false);
            straightTImage.SetActive(true);

            cornerTile = false;
            straightTile = true;
            currentTile = tileSet[1];
        }

        String displayString = "Min Path Length: " + numTilesPlaced + "/" + minPathLength;
        pathText.text = displayString;

        if (numTilesPlaced >= minPathLength)
        {
            minLengthMet = true;
        }

        if (Input.GetKeyDown("return"))
        {
            if (building)
            {
                switchToMoving();

            } else if (moving)
            {
                switchToBuilding();
            }
        }

        if (moving)
        {
            mainCam.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
        }
        
    }

    private void switchToMoving()
    {
        moving = true;
        building = false;
        mainCam.orthographicSize = 2f;
        player.SetActive(true);
        cursor.SetActive(false);
        buildUI.GameObject().SetActive(false);
        highlight.SetActive(false);
        
    }

    private void switchToBuilding()
    {
        building = true;
        moving = false;
        mainCam.orthographicSize = 5f;
        mainCam.transform.position = new Vector3(0f, 0f, -10f);
        player.transform.position = playerSpawn;
        player.SetActive(false);
        cursor.SetActive(true);
        buildUI.GameObject().SetActive(true);
        highlight.SetActive(true);
    }
}
