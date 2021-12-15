using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageClick : MonoBehaviour
{
    private GameManager gameManagerScript;
    public string colliders;
    public bool scissors,harpoon,spray,cuffs,book;
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
                // Tool bar (Checks which items have the players found)
                switch (hit.collider.tag)
                {
                    case "Images":
                    Destroy(hit.transform.parent.gameObject);
                    gameManagerScript.ScoreUpdate();
                    break;

                    case "Scissors":
                    Destroy(hit.transform.parent.gameObject);
                     scissors = true;
                    break;

                    case "Harpoon":
                    Destroy(hit.transform.parent.gameObject);
                     harpoon = true;
                    break;

                    case "Spray":
                    Destroy(hit.transform.parent.gameObject);
                    spray = true;
                    break;

                    case "Cuffs":
                    Destroy(hit.transform.parent.gameObject);
                     cuffs = true;
                    break;

                    case "Book":
                    Destroy(hit.transform.parent.gameObject);
                    book = true;
                    break;

                    case "Vamp":
                    if (book == true)
                    {
                        Destroy(hit.transform.parent.gameObject);
                        gameManagerScript.ScoreUpdate();
                    }
                    break;

                    case "Demon":
                     if (book == true)
                    {
                        Destroy(hit.transform.parent.gameObject);
                        gameManagerScript.ScoreUpdate();
                    }
                    break;

                    case "Ghost":
                    if (scissors == true)
                    {
                        Destroy(hit.transform.parent.gameObject);
                        gameManagerScript.ScoreUpdate();
                    }
                    break;

                    case "Mk":
                      if (harpoon == true)
                    {
                        Destroy(hit.transform.parent.gameObject);
                        gameManagerScript.ScoreUpdate();
                    }
                    break;

                    case "Mummy":
                     if (scissors == true)
                    {
                        Destroy(hit.transform.parent.gameObject);
                        gameManagerScript.ScoreUpdate();
                    }
                    break;

                    case "Octo":
                    if (harpoon == true)
                    {
                        Destroy(hit.transform.parent.gameObject);
                        gameManagerScript.ScoreUpdate();
                    }
                    break;

                    case "Siren":
                    break;

                    case "WereWolf":
                    if (spray == true)
                    {
                        Destroy(hit.transform.parent.gameObject);
                        gameManagerScript.ScoreUpdate();
                    }
                    break;

                    case "Witch":
                     if (book == true)
                    {
                        Destroy(hit.transform.parent.gameObject);
                        gameManagerScript.ScoreUpdate();
                    }
                    break;

                    case "Spider":
                    if (spray == true)
                    {
                        Destroy(hit.transform.parent.gameObject);
                        gameManagerScript.ScoreUpdate();
                    }
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
