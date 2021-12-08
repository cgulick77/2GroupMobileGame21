﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageClick : MonoBehaviour
{
    private GameManager gameManagerScript;
    public string colliders;
    public bool hammer,screw,magni,wrench;
    public bool [] tools;
    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                switch (hit.collider.tag)
                {
                    case "Images":
                    Destroy(hit.transform.parent.gameObject);
                    gameManagerScript.ScoreUpdate();
                    break;

                    case "Hammer":
                    Destroy(hit.transform.parent.gameObject);
                     hammer = true;
                    break;

                    case "Screw":
                    Destroy(hit.transform.parent.gameObject);
                     screw = true;
                    break;

                    case "Magnifiying":
                    Destroy(hit.transform.parent.gameObject);
                    magni = true;
                    break;

                    case "Wrench":
                    Destroy(hit.transform.parent.gameObject);
                     wrench = true;
                    break;
                    
                }


            }
            
        }
    }

    // if (hit.collider.CompareTag("Images"))
                // {
                //      //Debug.Log(hit.transform.gameObject);
                //      Destroy(hit.transform.parent.gameObject);
                //      gameManagerScript.ScoreUpdate();
                // }

                // if (hit.collider.CompareTag("Hammer"))
                // {
                //     Destroy(hit.transform.parent.gameObject);
                //     hammer = true;
                // }

                // if (hit.collider.CompareTag("Screw"))
                // {
                //     Destroy(hit.transform.parent.gameObject);
                //     screw = true;
                // }

                // if (hit.collider.CompareTag("Magnifiying"))
                // {
                //     Destroy(hit.transform.parent.gameObject);
                //     magni = true;
                // }

                // if (hit.collider.CompareTag("Wrench"))
                // {
                //     Destroy(hit.transform.parent.gameObject);
                //     wrench = true;
                // }

}
