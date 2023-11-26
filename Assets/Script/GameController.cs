using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    int maxPlatform = 0;
    bool isPaused = true;
    bool togglePauseCalled = false;
    private bool mouseUpCalled = false;

    public Component otherComponent;
    int clickCount = 0;



    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        {
            if (Input.GetMouseButtonDown(0) && !togglePauseCalled)
            {
                ToggleUnpause();
                togglePauseCalled = true;
            }
            else if (Input.GetMouseButtonUp(0) && !mouseUpCalled)
            {
                TogglePause();
                mouseUpCalled = true;

            }
        }
    }

    public void ToggleUnpause()
    {
        if (isPaused || mouseUpCalled)
        {
            Time.timeScale = 1;
            isPaused = false;
            mouseUpCalled = false;
            Debug.Log("UNPAUSE");
        }
    }

    public void TogglePause()
    {
        if (isPaused == false)
        {
            Time.timeScale = 0;
            isPaused = true;
            Debug.Log("PAUSE");
        }
    }    

    public void Lanjut()
    {
        Time.timeScale = 1;
        Debug.Log("TIMESCALEONE");
    }
    public void GameOver()
    {
        GameOverScreen.Setup(maxPlatform);

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void BackToMainMenu()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    }


    private void Awake()
    {
        
    } 
   
  
}
