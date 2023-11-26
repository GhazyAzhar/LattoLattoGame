using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class SceneManagerScript : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public void StartGame()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void BackToMenu()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex -1));
        Debug.Log("BACKTOMENU");

    }

    public void BackToMainMenu()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 2));

    }

    public void ExitGame()
    {
        Application.Quit();
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
