using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClockTool : MonoBehaviour
{
    public GameObject pastTime, futureTime, pastClock, futureClock;
    public Text timeText;
    public GameObject [] tools;
    private float imageOnZ, imageOffZ, startTime = 150f, currentTime = 0f;
    public Transform [] toolsChild;
    public int i;
    private bool future,past;


    // Start is called before the first frame update
    void Start()
    {
        futureTimeLine();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        tools = GameObject.FindGameObjectsWithTag("Tool");

        if (past == true)
        {
            currentTime -= 1 *Time.deltaTime;
            timeText.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = 0;
            }
        }
    }

    public void pastTimeLine ()
    {
        pastTime.SetActive(true);
        futureTime.SetActive(false);
        pastClock.SetActive(false);
        futureClock.SetActive(true);

        //Checks what time line is currently active
        past = true;
        future = false;

        currentTime = startTime;
    }

    public void futureTimeLine()
    {
        pastTime.SetActive(false);
        futureTime.SetActive(true);
        pastClock.SetActive(true);
        futureClock.SetActive(false);
        
        

        //Checks what time line is currently active
        past = false;
        future = true;
        
    }

    public void ToolsToogle (bool toogle)
    {
        imageOnZ = -1.378036f;
        imageOffZ = 0.0f;

        if (toogle == true)
        {
        //    int i = 0;
           
            for (i = 0; i <tools.Length; ++i)
            {
                tools[i].SetActive(true);
                // tools[i].transform.position = new Vector3(transform.position.x, transform.position.y, imageOffZ);
                // toolsChild[i] = tools[i].gameObject.transform.GetChild(0);
                // toolsChild[i].gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
                Debug.Log("ADQEWD");
            }
            
        }

        if (toogle == false)
        {
            
            int m;
             for (m = 0; m <tools.Length; ++m)
            {
                tools[m].SetActive(false);
                // tools[i].transform.position = new Vector3(transform.position.x, transform.position.y, imageOnZ);
                // toolsChild[m] = tools[m].gameObject.transform.GetChild(0);
                // toolsChild[m].gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
                Debug.Log("FAFAF");
            }

            // int m;
            // for (m = 0; m <tools.Length; ++m)
            // {
            //    toolsChild[m] = tools[m].gameObject.transform.GetChild(0);
            //     toolsChild[m].gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
            // }
        }
    }

        public void test()
    {
        Debug.Log("WOWOW");
    }

}
