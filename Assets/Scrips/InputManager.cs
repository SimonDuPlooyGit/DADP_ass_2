using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private Camera camera;
    
    private Vector3 lastSelected;
    
    [SerializeField]
    private LayerMask placePlane;

    public Vector3 GetSelectedPos()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = camera.nearClipPlane;
        Ray ray = camera.ScreenPointToRay(mousePos);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, 100, placePlane))
        {
            lastSelected = hit.point;
        }

        return lastSelected;
    }
}
