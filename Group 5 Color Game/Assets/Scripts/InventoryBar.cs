using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBar : MonoBehaviour
{
    
    public GameObject inventoryBarOn, inventoryBarOff;
    public GameObject [] toolImagesOn, toolImagesOff;
    private ImageClick imageClickScript;

    void Start()
    {
        toolBarOff();
        ToolBarImagesOff();
        imageClickScript = FindObjectOfType<ImageClick>();
    }
    /* This script works by simplying setting things active or inactive. When the plyer presses a button it turns it active or inactive. Script works with the (ImageClick) script
    to check if the player clicks on which tool and sets the toool active on the tool bar. */

    // Update is called once per frame
    void Update()
    {
        ToolBarMenuImages();
    }
    
    public void toolBarOn()
    {
        inventoryBarOn.SetActive(true);
        inventoryBarOff.SetActive(false);
    }

    public void toolBarOff()
    {
        inventoryBarOn.SetActive(false);
        inventoryBarOff.SetActive(true); 
    }

    public void ToolBarMenuImages()
    {
        if (imageClickScript.scissors == true)
        {
            toolImagesOn[0].SetActive(true);
            toolImagesOff[0].SetActive(true);
        }

        if (imageClickScript.harpoon == true)
        {
             toolImagesOn[1].SetActive(true);
            toolImagesOff[1].SetActive(true);
        }

        if (imageClickScript.spray == true)
        {
             toolImagesOn[2].SetActive(true);
            toolImagesOff[2].SetActive(true);
        }

        if (imageClickScript.cuffs == true)
        {
             toolImagesOn[3].SetActive(true);
            toolImagesOff[3].SetActive(true);
        }

        if (imageClickScript.book == true)
        {
            toolImagesOn[4].SetActive(true);
            toolImagesOff[4].SetActive(true);
        }
    }

    private void ToolBarImagesOff()
    {
        toolImagesOn[0].SetActive(false);
        toolImagesOff[0].SetActive(false);
        toolImagesOn[1].SetActive(false);
        toolImagesOff[1].SetActive(false);
        toolImagesOn[2].SetActive(false);
        toolImagesOff[2].SetActive(false);
        toolImagesOn[3].SetActive(false);
        toolImagesOff[3].SetActive(false);
        toolImagesOn[4].SetActive(false);
        toolImagesOff[4].SetActive(false);
    }


}
