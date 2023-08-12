using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject currentTile;
    public List<GameObject> tileSet;

    //Christine's attempt. Please delete if necessary.
    public GameObject cornerTImage;
    public GameObject straightTImage;

    public bool cornerTile;
    public bool straightTile;

    void Start()
    {
        Cursor.visible = false;

        var resources = Resources.LoadAll("Tiles", typeof(GameObject));

        foreach (GameObject obj in resources)
        {
            tileSet.Add(obj);
        }

        //Christine's attempt. Please delete if necessary.
        cornerTImage.SetActive(false);
        straightTImage.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            //Christine's attempt. Please delete if necessary.
            cornerTImage.SetActive(true);
            straightTImage.SetActive(false);

            cornerTile = true;
            straightTile = false;
        }

        if (Input.GetKeyDown("2"))
        {
            //Christine's attempt. Please delete if necessary.
            cornerTImage.SetActive(false);
            straightTImage.SetActive(true);

            cornerTile = false;
            straightTile = true;
        }
    }
}
