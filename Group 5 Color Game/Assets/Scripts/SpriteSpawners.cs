using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpawners : MonoBehaviour
{
    public GameObject [] spawnPoints;
    public List<GameObject>  images;
    public List<int> numbers;
    public int maxSpawnPoints, selectedSp, i, selectedImages, randomSpawnPoints, p;
    public bool cZero,cOne,cTwo,cThree,cFour,cFive, iZero,iOne,iTwo,iThree,iFour,iFive;
    private Vector3 pos, cZeroPos, cOnePos, cTwoPos, cThreePos, cFourPos, cFivePos;
    private GameObject sP, imagesP;
    private ImageSpawners imageSpawnersScript;
    
    // Start is called before the first frame update
    void Start()
    {
       SpawnPointGeneration();
       //SpriteSpawn(pos);
       //imageSpawnersScript = GameObject.Find("Image Sets").GetComponent<ImageSpawners>();


    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void SpawnPointGeneration()
    {
        maxSpawnPoints = 4; // Max number of current spawn points.
        
        while (i < maxSpawnPoints) // Chooses spawn points till it hits the max amount of spawns.
        {
            //selectedSp = 0;
            randomSpawnPoints  = Random.Range(0,spawnPoints.Length); // Randomizes which one gets picks
            sP = spawnPoints[randomSpawnPoints];  // Selects one of possible spawn points.

            switch (randomSpawnPoints) // If spawn point is selected it is then activated.
            {
                case 0:
                    if (cZero == false)
                    {
                        //Vector3 cZeroPos;
                        
                        //int CZeroVal = 0;
                        spawnPoints[0].SetActive(true);
                        cZeroPos = spawnPoints[0].transform.position;
                        cZero = true;
                        //imageSpawnersScript.SpriteSpawn(cZeroPos);

                        SpriteSpawn(cZeroPos);

                        ++i;
                        //++p;
                    }
                    break;
                    
                 case 1:
                     if (cOne == false)
                    {
                        //Vector3 cOnePos;
                        
                        //int cOneVal = 1;
                        spawnPoints[1].SetActive(true);
                        cOnePos = spawnPoints[1].transform.position;
                        cOne = true;
                        //imageSpawnersScript.SpriteSpawn(cOnePos);

                        SpriteSpawn(cOnePos);

                        ++i;
                        //++p;
                    }

                    break;
                 case 2:
                     if (cTwo == false)
                    {
                        //Vector3 cTwoPos;
                        
                        //int cTwoVal = 2;
                        spawnPoints[2].SetActive(true);
                        cTwoPos = spawnPoints[2].transform.position;
                        cTwo = true;
                        //imageSpawnersScript.SpriteSpawn(cTwoPos);

                        SpriteSpawn(cTwoPos);
  
                        ++i;
                        //++p;
                    }
                    
                    break;
                 case 3:
                     if (cThree == false)
                    {
                        //Vector3 cThreePos;
                        
                        //int cThreeVal = 3;
                        spawnPoints[3].SetActive(true);
                        cThreePos = spawnPoints[3].transform.position;
                        cThree = true;
                        //imageSpawnersScript.SpriteSpawn(cThreePos);
                        
                        SpriteSpawn(cThreePos);

                        ++i;
                        //++p;
                    }
                     
                    break;
                 case 4:
                     if (cFour == false)
                    {
                        //Vector3 cFourPos;
                        
                        //int cFourVal = 4;
                        spawnPoints[4].SetActive(true);
                        cFourPos = spawnPoints[4].transform.position;
                        cFour = true;
                        //imageSpawnersScript.SpriteSpawn(cFourPos);

                        SpriteSpawn(cFourPos);

                        ++i;
                        //++p;
                    }
                     
                    break;
                 case 5:
                     if (cFive == false)
                    {
                        //Vector3 cFivePos;
                        //int CFiveVal = 5;
                        spawnPoints[5].SetActive(true);
                        cFivePos = spawnPoints[5].transform.position;
                        //imageSpawnersScript.SpriteSpawn(cFivePos);
                        cFive = true;

                        SpriteSpawn(cFivePos);

                        ++i;
                        //++p;
                    }
                    break;
                  
            }
            
            
            
            //Debug.Log(i);
            Debug.Log(randomSpawnPoints);
        }
        
    }



       public void SpriteSpawn(Vector3 pos)
    {
            
            //while (p < maxSpawnPoints)
            {
                int randomImages = Random.Range(0,images.Count);
                imagesP = images[randomImages];
                
                switch (randomImages)
                {
                    case 0:
                    if (iZero == false)
                    {
                        Instantiate(images[0],pos, Quaternion.identity);
                        //images.RemoveAt(0);
                        
                        iZero = true;
                        ++p;
                
                    }
                    else 
                    {
                          SpriteSpawn(pos);
                    }
                        break;
                    case 1:
                    if (iOne == false)
                    {
                        Instantiate(images[1],pos, Quaternion.identity);
                        //images.RemoveAt(1);
                        iOne = true;
                        
                        ++p;
                    }
                    else 
                    {
                          SpriteSpawn(pos);
                    }
                        break;
                    case 2:
                    if (iTwo == false)
                    {
                        Instantiate(images[2],pos, Quaternion.identity);
                        //images.RemoveAt(2);
                        iTwo = true;
                        
                        ++p;
                    }
                    else 
                    {
                          SpriteSpawn(pos);
                    }
                        break;
                    case 3:
                    if (iThree == false)
                    {
                        Instantiate(images[3],pos, Quaternion.identity);
                        //images.RemoveAt(3);
                        iThree = true;
                        
                        ++p;
                    }
                    else 
                    {
                          SpriteSpawn(pos);
                    }
                        break;
                    case 4:
                    if(iFour == false)
                    {
                        Instantiate(images[4],pos, Quaternion.identity);
                        //images.RemoveAt(4);
                        iThree = true;
                        
                        ++p;
                    }
                    else 
                    {
                          SpriteSpawn(pos);
                    }
                        break;
                    case 5:
                    if (iFive == false)
                    {
                        Instantiate(images[5],pos, Quaternion.identity);
                        //images.RemoveAt(5);
                        iFive = true;
                        
                        ++p;
                    }
                    else 
                    {
                          SpriteSpawn(pos);
                    }
                        break;
               
                   
                }
            }
        //Debug.Log(randomSpawnPoints);
            
        }
}


