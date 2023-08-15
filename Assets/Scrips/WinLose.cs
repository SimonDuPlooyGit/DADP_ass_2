using UnityEngine;

public class WinLose : MonoBehaviour
{
    public GameObject enableWonGameObject;
    public GameObject enableLostGameObject;

    public GameObject gameObject1; // Reference to Game Object 1
    public GameObject gameObject2; // Reference to Game Object 2

    public PlaceSystem placeSystem_;
    public GameManager GamaManager_;

    private void Start()
    {
        CheckSum();
    }

    private void CheckSum()
    {
       
        Transform transform1 = gameObject1.transform;
        Transform transform2 = gameObject2.transform;

        
        float sum = transform1.position.x + transform2.position.x +
                    transform1.position.y + transform2.position.y +
                    transform1.position.z + transform2.position.z;

        if (placeSystem_.cornerTilesTotal == 10)
        {
            enableWonGameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else if (placeSystem_.cornerTilesTotal > 10)
        {
            enableLostGameObject.SetActive(true);
        }
    }
}