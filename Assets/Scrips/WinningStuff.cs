using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningStuff : MonoBehaviour
{
    public GameManager _gameManager;
    public UIManager _uiManager;
    public DeletingTiles _deletingTiles;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && _gameManager.GetComponent<GameManager>().minLengthMet == true)
        {
            Debug.Log("You win");
            _gameManager.GetComponent<GameManager>().minLengthMet = false;
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

            _uiManager.One.SetActive(false);
            _uiManager.Two.SetActive(false);
            _uiManager.Three.SetActive(false);
            _uiManager.Four.SetActive(false);
            _uiManager.Five.SetActive(false);
            _uiManager.Six.SetActive(false);
            _uiManager.Seven.SetActive(false);

            if (_gameManager.Level == 7)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
