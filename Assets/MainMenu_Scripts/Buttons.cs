using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField]
    private GameObject tutorialMenu;

    private void Start()
    {
        tutorialMenu.SetActive(false);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void TutorialButton()
    {
        tutorialMenu.SetActive(true);
    }

    public void TutorialBackButton()
    {
        tutorialMenu.SetActive(false);
    }
}
