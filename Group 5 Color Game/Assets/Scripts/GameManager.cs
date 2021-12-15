using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;





public class GameManager : MonoBehaviour
{
    
    public GameObject mainMenu, landCreaturesTab, landCreatureTabClose, winScreen, waterCreatureTab, waterCreatureTabClosed, miniMenu, inGameMenu, monstersTab, pauseMenu, failMenu;
    private bool landTabOpen, waterTabOpen;
    public int monsters;
     public TextMeshProUGUI monsterText;
    
    // Start is called before the first frame update
    void Start()
    {
        CloseLandCreatureTab();
        monsters = 4;
        mainMenuScreen();
        ScoreStart();

    }

    // Update is called once per frame
    void Update()
    {
        if (monsters == 0)
        {
            winGameScreen();
        }
    }

    public void PlayButton()
    {
        //SceneManager.LoadScene("Christian");
        Time.timeScale = 1;
        mainMenu.gameObject.SetActive(false);
        miniMenu.gameObject.SetActive(false);
        winScreen.gameObject.SetActive(false);
        inGameMenu.SetActive(true);
    }

    public void mainMenuScreen()
    {
        mainMenu.gameObject.SetActive(true);
        winScreen.gameObject.SetActive(false);
        miniMenu.gameObject.SetActive(false);
        inGameMenu.SetActive(false);
        failMenu.SetActive(false);
        Time.timeScale = 0;
    }

    public void InGameUi()
    {
        inGameMenu.SetActive(true);
        winScreen.gameObject.SetActive(false);
        miniMenu.gameObject.SetActive(false);
        failMenu.SetActive(false);
        //CloseLandCreatureTab();
    }

    public void winGameScreen()
    {
        winScreen.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(false);
        miniMenu.gameObject.SetActive(false);
        inGameMenu.SetActive(false);
        failMenu.SetActive(false);
        Time.timeScale = 0;
    }
    public void FailGame ()
    {
        winScreen.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
        inGameMenu.SetActive(false);
        failMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void pauseScreen()
    {
        Time.timeScale = 0;
        miniMenu.gameObject.SetActive(true);
        winScreen.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
        inGameMenu.SetActive(false);
        pauseMenu.SetActive(true);
        
    }


    public void LandCreatureTab()
    {
        //landTabOpen = false;
        if (landTabOpen == false) // if the tab is close
        {
            OpenLandCreatureTab();
            
        }
        else
        {
            CloseLandCreatureTab();
        }
    }
    public void OpenLandCreatureTab()
    {
        landCreatureTabClose.SetActive(true);
        landCreaturesTab.SetActive(false);
        // waterCreatureTabClosed.SetActive(false);
        // waterCreatureTab.SetActive(false);
        // landCreatureTabClose.transform.position = new Vector3(813, 0, 0);
        // landCreaturesTab.transform.position = new Vector3(992, 0, 0);
        //landTabOpen = true;
    }
    public void CloseLandCreatureTab()
    {
        landCreatureTabClose.SetActive(false);
        landCreaturesTab.SetActive(true);
        // landCreaturesTab.transform.position = new Vector3(768, 0, 0);
        // landCreatureTabClose.transform.position = new Vector3(1077,0,0);
        //landTabOpen = false;
    }
    public void ScoreUpdate()
    {
        monsters = monsters - 1;
        monsterText.text = "Monster: " + monsters;
        
    }
    public void ScoreStart()
    {
        monsterText.text = "Monster: " + monsters;
    }
    // public void OpenWaterCreatureTab()
    // {
    //     waterCreatureTabClosed.SetActive(true);
    //     waterCreatureTab.SetActive(false);
    //     landCreatureTabClose.SetActive(false);
    //     landCreaturesTab.SetActive(false);
    // }
    // public void CloseWaterCreatureTab()
    // {
    //     waterCreatureTabClosed.SetActive(false);
    //     waterCreatureTab.SetActive(true);
    //     // landCreatureTabClose.SetActive(false);
    //     // landCreaturesTab.SetActive(true);
    // }
}
