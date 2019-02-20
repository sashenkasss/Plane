using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
    
    public bool isPaused = false;//нажата пауза или нет
    public GameObject pause_menu, cube;
    public Text txtCoin, txtScore;
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            Debug.Log(5285);
            cube.SetActive(true);
            isPaused = false;
            pause_menu.SetActive(false);
            Time.timeScale = 1;
            return;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            cube.SetActive(false);
            isPaused = true;
            pause_menu.SetActive(true);
            Time.timeScale= 0;
            return;
        }

        
    }
    public void Pause_on()
    {
        cube.SetActive(false);
        isPaused = true;
        pause_menu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Pause_Off()
    {
        cube.SetActive(true);
        isPaused = false;
        pause_menu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Goto_menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScene");
    }

    public void Goto_start()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("PlayScene");
        ConstComponent.coinCurrent = 0;
        ConstComponent.score = 0;
        ConstComponent.Game = true;
        txtCoin.text = "0";
        txtScore.text = "0 m.";
    }

    public void RepeatGameAfterOver()
    {
    }

}

