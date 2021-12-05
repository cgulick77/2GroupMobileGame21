using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBar : MonoBehaviour
{
    
    public GameObject inventoryBar, toolOne, toolTwo, toolThree, toolFour, onButton, offButton;
    public GameObject [] toolImages;

    void Start()
    {
        toolBarOff();
    }

    // Update is called once per frame
    void Update()
    {
        // Off Y-Height: -10.9
        // ON Y-Height: .4
    }
    
    private void toolBarOn()
    {
        onButton.SetActive(false);
        offButton.SetActive(true);
        inventoryBar.transform.position = new Vector3(0,.4f,0);

    }

    private void toolBarOff()
    {
        offButton.SetActive(false);
        onButton.SetActive(true);
        inventoryBar.transform.position = new Vector3(0,-10.9f,0);
    }
}
