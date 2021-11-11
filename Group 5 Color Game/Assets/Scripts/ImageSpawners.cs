using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSpawners : MonoBehaviour
{
    public List<GameObject>  images;
    private GameObject imagesP;
    public bool iZero,iOne,iTwo,iThree,iFour,iFive,iSix;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SpriteSpawn(pos);
    }

    public void SpriteSpawn(Vector3 pos)
    {
        
            
                int randomImages = Random.Range(0,images.Count);
                imagesP = images[randomImages];
                
                switch (randomImages)
                {
                    case 0:
                    if (iZero == false)
                    {
                        Instantiate(images[0],pos, Quaternion.identity);
                        iZero = true;
                        //images.RemoveAt(0);
                        //++p;
  
                    }
                        break;
                    case 1:
                    if (iOne == false)
                    {
                        Instantiate(images[1],pos, Quaternion.identity);
                        //images.RemoveAt(1);
                        iOne = true;
                        
                        //++p;
                    }
                        break;
                    case 2:
                    if (iTwo == false)
                    {
                        Instantiate(images[2],pos, Quaternion.identity);
                        //images.RemoveAt(2);
                        iTwo = true;
                        
                        //++p;
                    }
                        break;
                    case 3:
                    if (iThree == false)
                    {
                        Instantiate(images[3],pos, Quaternion.identity);
                        //images.RemoveAt(3);
                        iThree = true;
                        
                        //++p;
                    }
                        break;
                    case 4:
                    if(iFour == false)
                    {
                        Instantiate(images[4],pos, Quaternion.identity);
                        //images.RemoveAt(4);
                        iThree = true;
                        
                        //++p;
                    }
                        break;
                    case 5:
                    if (iFive == false)
                    {
                        Instantiate(images[5],pos, Quaternion.identity);
                        //images.RemoveAt(5);
                        iFive = true;
                        
                        //++p;
                    }
                        break;
                   
                }

            
    }
}


