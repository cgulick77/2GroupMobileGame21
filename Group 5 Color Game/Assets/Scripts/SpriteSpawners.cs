using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpawners : MonoBehaviour
{
    public GameObject [] spawnPoints;
    
    public List<int> numbers;
    public int maxSpawnPoints, selectedSp, i, selectedImages, randomSpawnPoints, p;
    public bool cZero,cOne,cTwo,cThree,cFour,cFive;
    private GameObject sP, imagesP;
    private ImageSpawners imageSpawnersScript;
    // Start is called before the first frame update
    void Start()
    {
       SpawnPointGeneration();
       imageSpawnersScript = FindObjectOfType<ImageSpawners>();

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
                        Vector3 cZeroPos;
                        
                        cZeroPos = spawnPoints[0].transform.position;
                        spawnPoints[0].SetActive(true);
                        cZero = true;
                        //imageSpawnersScript.SpriteSpawn(cZeroPos);

                        //SpriteSpawn(cZeroPos);

                        ++i;
                    }
                    break;
                    
                 case 1:
                     if (cOne == false)
                    {
                        Vector3 cOnePos;
                        cOnePos = spawnPoints[1].transform.position;
                        spawnPoints[1].SetActive(true);
                        cOne = true;
                        //imageSpawnersScript.SpriteSpawn(cOnePos);

                        //SpriteSpawn(cOnePos);

                        ++i;
                    }

                    break;
                 case 2:
                     if (cTwo == false)
                    {
                        Vector3 cTwoPos;
                        
                        cTwoPos = spawnPoints[2].transform.position;
                        spawnPoints[2].SetActive(true);
                        cTwo = true;
                        //imageSpawnersScript.SpriteSpawn(cTwoPos);

                        //SpriteSpawn(cTwoPos);
  
                        ++i;
                    }
                    
                    break;
                 case 3:
                     if (cThree == false)
                    {
                        Vector3 cThreePos;
                        
                        cThreePos = spawnPoints[3].transform.position;
                        spawnPoints[3].SetActive(true);
                        cThree = true;
                        //imageSpawnersScript.SpriteSpawn(cThreePos);
                        
                        //SpriteSpawn(cThreePos);

                        ++i;
                    }
                     
                    break;
                 case 4:
                     if (cFour == false)
                    {
                        Vector3 cFourPos;
                        
                        cFourPos = spawnPoints[4].transform.position;
                        spawnPoints[4].SetActive(true);
                        cFour = true;
                        //imageSpawnersScript.SpriteSpawn(cFourPos);

                        //SpriteSpawn(cFourPos);

                        ++i;
                    }
                     
                    break;
                 case 5:
                     if (cFive == false)
                    {
                        Vector3 cFivePos;
                        cFivePos = spawnPoints[5].transform.position;
                        spawnPoints[5].SetActive(true);
                        //imageSpawnersScript.SpriteSpawn(cFivePos);
                        cFive = true;

                        //SpriteSpawn(cFivePos);

                        ++i;
                    }
                    break;
                  
            }
            
            
            
            Debug.Log(i);
            //Debug.Log(randomSpawnPoints);
        }
        
    }
}

    /*public void SpriteSpawn(Vector3 pos)
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
}*/
