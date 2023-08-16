using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningStuff : MonoBehaviour
{
    public GameManager _gameManager;
    public UIManager _uiManager;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("You win");
            _uiManager.LevelComplete.SetActive(true);
            _gameManager.GetComponent<GameManager>().TutLevel1BO.SetActive(false);
            _gameManager.GetComponent<GameManager>().TutLevel2BO.SetActive(false);
            _gameManager.GetComponent<GameManager>().TutLevel3BO.SetActive(false);
            _gameManager.GetComponent<GameManager>().TutLevel4BO.SetActive(false);
            _gameManager.GetComponent<GameManager>().Level1BO.SetActive(false);
            _gameManager.GetComponent<GameManager>().Level2BO.SetActive(false);
            _gameManager.GetComponent<GameManager>().Level3BO.SetActive(false);

            _gameManager.GetComponent<GameManager>().TutLevel1GS.SetActive(false);
            _gameManager.GetComponent<GameManager>().TutLevel2GS.SetActive(false);
            _gameManager.GetComponent<GameManager>().TutLevel3GS.SetActive(false);
            _gameManager.GetComponent<GameManager>().TutLevel4GS.SetActive(false);
            _gameManager.GetComponent<GameManager>().Level1GS.SetActive(false);
            _gameManager.GetComponent<GameManager>().Level2GS.SetActive(false);
            _gameManager.GetComponent<GameManager>().Level3GS.SetActive(false);

            _uiManager.betweenMenu.SetActive(true);
            _gameManager.GetComponent<GameManager>().switchToBuilding();

            Cursor.visible = true;
        }
    }
}
