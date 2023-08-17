using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject currentTile;
    public List<GameObject> tileSet;
    public TextMeshProUGUI pathText;
    public GameObject player;
    public GameObject highlight;
    public Canvas buildUI;
    public GameObject cursor;
    public PlaceSystem _placeSystem;
    
    public GameObject cornerTImage;
    public GameObject straightTImage;

    public GameObject Corner;
    public GameObject Straight;

    public bool cornerTile;
    public bool straightTile;
    public bool minLengthMet;

    public int numTilesPlaced = 0;
    public int minPathLength;

    public int Level = 1;

    public Camera mainCam;
    private bool building;
    private bool moving;

    public bool[,] occupiedArray = new bool[6,6];

    public Vector3 playerSpawn;

    public UIManager _uiManager;

    public GameObject TutLevel1BO;
    public GameObject TutLevel2BO;
    public GameObject TutLevel3BO;
    public GameObject TutLevel4BO;
    public GameObject Level1BO;
    public GameObject Level2BO;
    public GameObject Level3BO;

    public GameObject TutLevel1GS;
    public GameObject TutLevel2GS;
    public GameObject TutLevel3GS;
    public GameObject TutLevel4GS;
    public GameObject Level1GS;
    public GameObject Level2GS;
    public GameObject Level3GS;

    void Start()
    {
        Corner.SetActive(false);
        Straight.SetActive(false);

        building = true;
        moving = false;
        player.SetActive(false);

        cornerTImage.SetActive(false);
        straightTImage.SetActive(false);
        minLengthMet = false;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                occupiedArray[i,j] = false;
            }
        }        
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

    public void PlayLevel()
    {
        minLengthMet = false;
        _uiManager.Enter.SetActive(false);
        Cursor.visible = false;
        Level += 1;
        
        gameObject.GetComponent<DeletingTiles>().justDelete();
        
        if (Level == 1)
        {
            Straight.SetActive(true);

            var resources = Resources.LoadAll("TilesTut2And3", typeof(GameObject));
            tileSet.Clear();

            foreach (GameObject obj in resources)
            {
                tileSet.Add(obj);
            }

            _placeSystem.cornerTilesTotal = 0;
            _placeSystem.cornerTiles = _placeSystem.cornerTilesTotal;

            _placeSystem.straightTilesTotal = 6;
            _placeSystem.straightTiles = _placeSystem.straightTilesTotal;

            playerSpawn = new Vector3(-0.75f, -3.75f, -3f);
            player.transform.position = playerSpawn;
            _uiManager.One.SetActive(true);
            minPathLength = 6;
            TutLevel1BO.SetActive(true);
            TutLevel1GS.SetActive(true);
            _uiManager.betweenMenu.SetActive(false);

            //Pain
            occupiedArray[0, 5] = true;
            occupiedArray[0, 4] = true;
            occupiedArray[0, 3] = true;
            occupiedArray[0, 2] = true;
            occupiedArray[0, 1] = true;
            occupiedArray[0, 0] = true;
            occupiedArray[1, 5] = true;
            occupiedArray[1, 4] = true;
            occupiedArray[1, 3] = true;
            occupiedArray[1, 2] = true;
            occupiedArray[1, 1] = true;
            occupiedArray[1, 0] = true;
            occupiedArray[3, 5] = true;
            occupiedArray[3, 4] = true;
            occupiedArray[3, 3] = true;
            occupiedArray[3, 2] = true;
            occupiedArray[3, 1] = true;
            occupiedArray[3, 0] = true;
            occupiedArray[4, 5] = true;
            occupiedArray[4, 4] = true;
            occupiedArray[4, 3] = true;
            occupiedArray[4, 2] = true;
            occupiedArray[4, 1] = true;
            occupiedArray[4, 0] = true;
            occupiedArray[5, 5] = true;
            occupiedArray[5, 4] = true;
            occupiedArray[5, 3] = true;
            occupiedArray[5, 2] = true;
            occupiedArray[5, 1] = true;
            occupiedArray[5, 0] = true;
        }
        else if (Level == 2)
        {
            Corner.SetActive(true);
            Straight.SetActive(true);

            var resources = Resources.LoadAll("TilesTut2And3", typeof(GameObject));
            tileSet.Clear();

            foreach (GameObject obj in resources)
            {
                tileSet.Add(obj);
            }

            _placeSystem.cornerTilesTotal = 1;
            _placeSystem.cornerTiles = _placeSystem.cornerTilesTotal;

            _placeSystem.straightTilesTotal = 7;
            _placeSystem.straightTiles = _placeSystem.straightTilesTotal;

            playerSpawn = new Vector3(-2.25f, -3.75f, -3f);
            player.transform.position = playerSpawn;
            _uiManager.Two.SetActive(true);
            minPathLength = 8;
            TutLevel2BO.SetActive(true);
            TutLevel2GS.SetActive(true);
            _uiManager.betweenMenu.SetActive(false);

            //Pain
            occupiedArray[0, 5] = true;
            occupiedArray[0, 4] = true;
            occupiedArray[0, 3] = true;
            occupiedArray[0, 2] = true;
            occupiedArray[0, 1] = true;
            occupiedArray[0, 0] = true;
            occupiedArray[1, 5] = true;
            occupiedArray[1, 4] = true;
            occupiedArray[2, 5] = true;
            occupiedArray[2, 4] = true;
            occupiedArray[2, 2] = true;
            occupiedArray[2, 1] = true;
            occupiedArray[2, 0] = true;
            occupiedArray[3, 5] = true;
            occupiedArray[3, 4] = true;
            occupiedArray[3, 2] = true;
            occupiedArray[3, 1] = true;
            occupiedArray[3, 0] = true;
            occupiedArray[4, 5] = true;
            occupiedArray[4, 4] = true;
            occupiedArray[4, 2] = true;
            occupiedArray[4, 1] = true;
            occupiedArray[4, 0] = true;
            occupiedArray[5, 5] = true;
            occupiedArray[5, 4] = true;
            occupiedArray[5, 2] = true;
            occupiedArray[5, 1] = true;
            occupiedArray[5, 0] = true;
        }
        else if (Level == 3)
        {
            Corner.SetActive(true);
            Straight.SetActive(true);

            var resources = Resources.LoadAll("TilesTut2And3", typeof(GameObject));
            tileSet.Clear();

            foreach (GameObject obj in resources)
            {
                tileSet.Add(obj);
            }

            playerSpawn = new Vector3(-3.75f, -3.75f, -3f);
            player.transform.position = playerSpawn;
            _uiManager.Three.SetActive(true);
            minPathLength = 10;
            TutLevel3BO.SetActive(true);
            TutLevel3GS.SetActive(true);
            _uiManager.betweenMenu.SetActive(false);

            _placeSystem.cornerTilesTotal = 8;
            _placeSystem.cornerTiles = _placeSystem.cornerTilesTotal;

            _placeSystem.straightTilesTotal = 2;
            _placeSystem.straightTiles = _placeSystem.straightTilesTotal;

            //Pain
            occupiedArray[0, 5] = true;
            occupiedArray[0, 4] = true;
            occupiedArray[0, 3] = true;
            occupiedArray[0, 2] = true;
            occupiedArray[1, 5] = true;
            occupiedArray[1, 4] = true;
            occupiedArray[1, 3] = true;
            occupiedArray[1, 0] = true;
            occupiedArray[2, 5] = true;
            occupiedArray[2, 4] = true;
            occupiedArray[2, 1] = true;
            occupiedArray[2, 0] = true;
            occupiedArray[3, 5] = true;
            occupiedArray[3, 2] = true;
            occupiedArray[3, 1] = true;
            occupiedArray[3, 0] = true;
            occupiedArray[4, 3] = true;
            occupiedArray[4, 2] = true;
            occupiedArray[4, 1] = true;
            occupiedArray[4, 0] = true;
            occupiedArray[5, 5] = true;
            occupiedArray[5, 4] = true;
            occupiedArray[5, 3] = true;
            occupiedArray[5, 2] = true;
            occupiedArray[5, 1] = true;
            occupiedArray[5, 0] = true;
        }
        else if (Level == 4)
        {
            Corner.SetActive(true);
            Straight.SetActive(true);

            var resources = Resources.LoadAll("TilesTut2And3", typeof(GameObject));
            tileSet.Clear();

            foreach (GameObject obj in resources)
            {
                tileSet.Add(obj);
            }

            _placeSystem.cornerTilesTotal = 5;
            _placeSystem.cornerTiles = _placeSystem.cornerTilesTotal;

            _placeSystem.straightTilesTotal = 6;
            _placeSystem.straightTiles = _placeSystem.straightTilesTotal;

            playerSpawn = new Vector3(-2.25f, -3.75f, -3f);
            player.transform.position = playerSpawn;
            _uiManager.Four.SetActive(true);
            minPathLength = 9;
            TutLevel4BO.SetActive(true);
            TutLevel4GS.SetActive(true);
            _uiManager.betweenMenu.SetActive(false);

            //Pain
            occupiedArray[0, 5] = true;
            occupiedArray[0, 4] = true;
            occupiedArray[0, 3] = true;
            occupiedArray[0, 2] = true;
            occupiedArray[0, 1] = true;
            occupiedArray[0, 0] = true;
            occupiedArray[1, 5] = true;
            occupiedArray[1, 4] = true;
            occupiedArray[1, 3] = true;
            occupiedArray[2, 5] = true;
            occupiedArray[2, 4] = true;
            occupiedArray[2, 3] = true;
            occupiedArray[2, 1] = true;
            occupiedArray[2, 0] = true;
            occupiedArray[3, 5] = true;
            occupiedArray[3, 1] = true;
            occupiedArray[3, 0] = true;
            occupiedArray[4, 5] = true;
            occupiedArray[4, 3] = true;
            occupiedArray[4, 1] = true;
            occupiedArray[4, 0] = true;
            occupiedArray[5, 5] = true;
            occupiedArray[5, 1] = true;
            occupiedArray[5, 0] = true;
        }
        else if (Level == 5)
        {
            Corner.SetActive(true);
            Straight.SetActive(true);

            var resources = Resources.LoadAll("TilesTut2And3", typeof(GameObject));
            tileSet.Clear();

            foreach (GameObject obj in resources)
            {
                tileSet.Add(obj);
            }

            playerSpawn = new Vector3(-3.75f, -3.75f, -3f);
            player.transform.position = playerSpawn;
            _uiManager.Five.SetActive(true);
            minPathLength = 10;
            Level1BO.SetActive(true);
            Level1GS.SetActive(true);
            _uiManager.betweenMenu.SetActive(false);

            _placeSystem.cornerTilesTotal = 6;
            _placeSystem.cornerTiles = _placeSystem.cornerTilesTotal;

            _placeSystem.straightTilesTotal = 7;
            _placeSystem.straightTiles = _placeSystem.straightTilesTotal;

            //Pain
            occupiedArray[0, 5] = true;
            occupiedArray[2, 4] = true;
            occupiedArray[2, 3] = true;
            occupiedArray[2, 2] = true;
            occupiedArray[4, 2] = true;
            occupiedArray[5, 5] = true;
            occupiedArray[5, 4] = true;
            occupiedArray[5, 0] = true;
        }
        else if (Level == 6)
        {
            Corner.SetActive(true);
            Straight.SetActive(true);

            var resources = Resources.LoadAll("TilesTut2And3", typeof(GameObject));
            tileSet.Clear();

            foreach (GameObject obj in resources)
            {
                tileSet.Add(obj);
            }

            playerSpawn = new Vector3(-2.25f, -3.75f, -3f);
            player.transform.position = playerSpawn;
            _uiManager.Six.SetActive(true);
            minPathLength = 12;
            Level2BO.SetActive(true);
            Level2GS.SetActive(true);
            _uiManager.betweenMenu.SetActive(false);

            _placeSystem.cornerTilesTotal = 9;
            _placeSystem.cornerTiles = _placeSystem.cornerTilesTotal;

            _placeSystem.straightTilesTotal = 6;
            _placeSystem.straightTiles = _placeSystem.straightTilesTotal;

            //Pain
            occupiedArray[0, 5] = true;
            occupiedArray[0, 4] = true;
            occupiedArray[1, 5] = true;
            occupiedArray[1, 4] = true;
            occupiedArray[2, 2] = true;
            occupiedArray[3, 3] = true;
            occupiedArray[4, 1] = true;
            occupiedArray[4, 0] = true;
            occupiedArray[5, 1] = true;
            occupiedArray[5, 0] = true;
        }
        else if (Level == 7)
        {
            Corner.SetActive(true);
            Straight.SetActive(true);

            var resources = Resources.LoadAll("TilesTut2And3", typeof(GameObject));
            tileSet.Clear();

            foreach (GameObject obj in resources)
            {
                tileSet.Add(obj);
            }

            playerSpawn = new Vector3(-3.75f, -2.25f, -3f);
            player.transform.position = playerSpawn;
            _uiManager.Seven.SetActive(true);
            minPathLength = 15;
            Level3BO.SetActive(true);
            Level3GS.SetActive(true);
            _uiManager.betweenMenu.SetActive(false);

            _placeSystem.cornerTilesTotal = 9;
            _placeSystem.cornerTiles = _placeSystem.cornerTilesTotal;

            _placeSystem.straightTilesTotal = 9;
            _placeSystem.straightTiles = _placeSystem.straightTilesTotal;

            //Pain
            occupiedArray[2, 5] = true;
            occupiedArray[2, 4] = true;
            occupiedArray[2, 1] = true;
            occupiedArray[2, 0] = true;
            occupiedArray[5, 5] = true;
            occupiedArray[5, 0] = true;
        }
    }

    public void switchToMoving()
    {
        moving = true;
        building = false;
        mainCam.orthographicSize = 2f;
        player.SetActive(true);
        cursor.SetActive(false);
        buildUI.GameObject().SetActive(false);
        highlight.SetActive(false);
    }

    public void switchToBuilding()
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
