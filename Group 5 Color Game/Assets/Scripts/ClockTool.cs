using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTool : MonoBehaviour
{
    public GameObject pastTime, futureTime, pastClock, futureClock;
    // Start is called before the first frame update
    void Start()
    {
        //pastTimeLine();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pastTimeLine ()
    {
        pastTime.SetActive(true);
        futureTime.SetActive(false);
        pastClock.SetActive(false);
        futureClock.SetActive(true);
    }

    public void futureTimeLine()
    {
        pastTime.SetActive(false);
        futureTime.SetActive(true);
        pastClock.SetActive(true);
        futureClock.SetActive(false);
        
    }
    
    public void test()
    {
        Debug.Log("WOWOW");
    }

}
