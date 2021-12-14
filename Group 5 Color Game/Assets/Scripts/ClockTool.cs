using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClockTool : MonoBehaviour
{
    public GameObject pastTime, futureTime, pastClock, futureClock;
    public GameObject [] tools;
    private float imageOnZ, imageOffZ;
    public Transform [] toolsChild;
    public int i;
    private bool future,past;
    // Start is called before the first frame update
    void Start()
    {
        pastTimeLine();
    }

    // Update is called once per frame
    void Update()
    {
        tools = GameObject.FindGameObjectsWithTag("Tool");
    }

    public void pastTimeLine ()
    {
        pastTime.SetActive(true);
        futureTime.SetActive(false);
        pastClock.SetActive(false);
        futureClock.SetActive(true);
        ToolsToogle(true);

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
        ToolsToogle(false);
        

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
           Debug.Log("TRue");
            for (i = 0; i <tools.Length; ++i)
            {
                tools[i].SetActive(true);
                // tools[i].transform.position = new Vector3(transform.position.x, transform.position.y, imageOffZ);
                // toolsChild[i] = tools[i].gameObject.transform.GetChild(0);
                // toolsChild[i].gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;

            }
            
        }

        if (toogle == false)
        {
            Debug.Log("FAlse");
            int m;
             for (i = 0; i <toolsChild.Length; ++i)
            {
                tools[i].SetActive(false);
                // tools[i].transform.position = new Vector3(transform.position.x, transform.position.y, imageOnZ);
                // toolsChild[m] = tools[m].gameObject.transform.GetChild(0);
                // toolsChild[m].gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
                
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
