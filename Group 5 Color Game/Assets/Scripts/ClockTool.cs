using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClockTool : MonoBehaviour
{
    private GameManager gameManagerScript;

    public GameObject pastTime, futureTime, pastClock, futureClock;
    public Text timeText;
    public GameObject [] tools, monsters;
    private float imageOnZ, imageOffZ, startTime, currentTime, monsterOnZ, monsterOffZ, pausedTime;
    public Transform [] toolsChild;
    public int i;
    public bool future,past;


    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = FindObjectOfType<GameManager>();
        futureTimeLine();
        startTime = 120f;
        currentTime = startTime;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        tools = GameObject.FindGameObjectsWithTag("Tool");
        monsters = GameObject.FindGameObjectsWithTag("Monsters");

        if (past == true)
        {
            currentTime -= 1 *Time.deltaTime;
            timeText.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = 0;
                gameManagerScript.FailGame();
            }
        }

        if (past == false)
        {
            startTime = currentTime;
        }


    }

    public void pastTimeLine ()
    {
        pastTime.SetActive(true);
        futureTime.SetActive(false);
        pastClock.SetActive(false);
        futureClock.SetActive(true);
        ToolsToogle(false);
        MonstersToogle(true);

        //Checks what time line is currently active
        past = true;
        future = false;

    }

    public void futureTimeLine()
    {
        pastTime.SetActive(false);
        futureTime.SetActive(true);
        pastClock.SetActive(true);
        futureClock.SetActive(false);
        ToolsToogle(true);
        MonstersToogle(false);
        
        
        

        //Checks what time line is currently active
        past = false;
        future = true;
        
    }

    public void ToolsToogle (bool toogle) // Toggles tools On if past is laoded, toggles tools off if future is loaded
    {
        imageOnZ = -1.378036f; // Posiiton for tools visible on scene
        imageOffZ = 0.2f; // Posiiton for tools to be invisible on scene

        if (toogle == true)
        {
        //    int i = 0;
           
            for (i = 0; i <tools.Length; ++i)
            {
                
                Vector3 toolCurrentPos;
                toolCurrentPos = tools[i].transform.position;
                tools[i].transform.position = new Vector3(toolCurrentPos.x, toolCurrentPos.y, imageOffZ);
            }
            
        }

        if (toogle == false)
        {
            
            int m;
             for (m = 0; m <tools.Length; ++m)
            {
                Vector3 toolCurrentPos;
                toolCurrentPos = tools[m].transform.position;
                tools[m].transform.position = new Vector3(toolCurrentPos.x, toolCurrentPos.y, imageOnZ);
            }
        }
    }

    public void MonstersToogle (bool mToogle)
    {
        monsterOffZ = 1.5f;
        monsterOnZ = -0.6999969f;
        if (mToogle == true)
        {

            int k;
            for (k = 0; k <monsters.Length; ++k)
            {
                Vector3 monstersCurrentPos;
                monstersCurrentPos = monsters[k].transform.position;
                monsters[k].transform.position = new Vector3(monstersCurrentPos.x, monstersCurrentPos.y, monsterOffZ);
            }
        }

        if (mToogle == false)
        {
             int b;
            for (b = 0; b <monsters.Length; ++b)
            {
                Vector3 monstersCurrentPos;
                monstersCurrentPos = monsters[b].transform.position;
                monsters[b].transform.position = new Vector3(monstersCurrentPos.x, monstersCurrentPos.y, monsterOnZ);
            }
        }
    }
    

}
