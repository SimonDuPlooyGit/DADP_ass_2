using UnityEngine;

public class CollisionQuit : MonoBehaviour
{
    public GameObject prefab1; 
    public GameObject prefab2; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == prefab1 || collision.gameObject == prefab2)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; 
#else
            Application.Quit(); // Quit the game in standalone build
#endif
        }
    }
}