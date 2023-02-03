using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour{

    public static bool GameIsPaused = false;
    public GameObject settingMenuCanvas;
    
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume(){
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause(){
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ToSettingMenu(){
        settingMenuCanvas.SetActive(true);
    }

    public void ToMain(){
        Debug.Log("아직 미구현입니다...");
    }

    public void QuitGame(){
        Debug.Log("Quiting...");
        Application.Quit();
    }
}