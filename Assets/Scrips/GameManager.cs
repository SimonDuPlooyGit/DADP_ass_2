using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject currentTile;
    public List<GameObject> tileSet;

    void Start()
    {
        Cursor.visible = false;

        var resources = Resources.LoadAll("Tiles", typeof(GameObject));

        foreach (GameObject obj in resources)
        {
            tileSet.Add(obj);
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            
        }

        if (Input.GetKeyDown("2"))
        {
            
        }
    }
}
