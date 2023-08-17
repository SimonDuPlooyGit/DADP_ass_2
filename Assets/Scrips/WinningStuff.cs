using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningStuff : MonoBehaviour
{
    public GameManager _gameManager;
    public UIManager _uiManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && _gameManager.minLengthMet == true && _gameManager.Level < 8)
        {
            Debug.Log("You win");
            _uiManager.LevelComplete.SetActive(true);

            _gameManager.TutLevel1BO.SetActive(false);
            _gameManager.TutLevel2BO.SetActive(false);
            _gameManager.TutLevel3BO.SetActive(false);
            _gameManager.TutLevel4BO.SetActive(false);
            _gameManager.Level1BO.SetActive(false);
            _gameManager.Level2BO.SetActive(false);
            _gameManager.Level3BO.SetActive(false);

            _gameManager.TutLevel1GS.SetActive(false);
            _gameManager.TutLevel2GS.SetActive(false);
            _gameManager.TutLevel3GS.SetActive(false);
            _gameManager.TutLevel4GS.SetActive(false);
            _gameManager.Level1GS.SetActive(false);
            _gameManager.Level2GS.SetActive(false);
            _gameManager.Level3GS.SetActive(false);

            _uiManager.betweenMenu.SetActive(true);
            _gameManager.switchToBuilding();

            Cursor.visible = true;

            _uiManager.One.SetActive(false);
            _uiManager.Two.SetActive(false);
            _uiManager.Three.SetActive(false);
            _uiManager.Four.SetActive(false);
            _uiManager.Five.SetActive(false);
            _uiManager.Six.SetActive(false);
            _uiManager.Seven.SetActive(false);
            _uiManager.Eight.SetActive(false);
            
        } else if (collision.CompareTag("Player") && _gameManager.minLengthMet == true && _gameManager.checkpoint == true)
        {
            Debug.Log("You win");
            _uiManager.LevelComplete.SetActive(true);

            _gameManager.TutLevel1BO.SetActive(false);
            _gameManager.TutLevel2BO.SetActive(false);
            _gameManager.TutLevel3BO.SetActive(false);
            _gameManager.TutLevel4BO.SetActive(false);
            _gameManager.Level1BO.SetActive(false);
            _gameManager.Level2BO.SetActive(false);
            _gameManager.Level3BO.SetActive(false);

            _gameManager.TutLevel1GS.SetActive(false);
            _gameManager.TutLevel2GS.SetActive(false);
            _gameManager.TutLevel3GS.SetActive(false);
            _gameManager.TutLevel4GS.SetActive(false);
            _gameManager.Level1GS.SetActive(false);
            _gameManager.Level2GS.SetActive(false);
            _gameManager.Level3GS.SetActive(false);

            _uiManager.betweenMenu.SetActive(true);
            _gameManager.switchToBuilding();

            Cursor.visible = true;

            _uiManager.One.SetActive(false);
            _uiManager.Two.SetActive(false);
            _uiManager.Three.SetActive(false);
            _uiManager.Four.SetActive(false);
            _uiManager.Five.SetActive(false);
            _uiManager.Six.SetActive(false);
            _uiManager.Seven.SetActive(false);

            SceneManager.LoadScene(2);
        }
        else
        {
            _gameManager.switchToBuilding();
        }
    }
}
