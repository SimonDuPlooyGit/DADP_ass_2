using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject mouseCursor;
    
    [SerializeField]
    private InputManager _inputManager;

    private void Update()
    {
        Vector3 mousePosition = _inputManager.GetSelectedPos();
        mouseCursor.transform.position = mousePosition;
    }
}
