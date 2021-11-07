using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpawners : MonoBehaviour
{
    //public GameObject [] spawnPoints, images;
    public List<GameObject> spawnPoints, images;
    public int maxSpawnPoints, selectedSp, i, selectedImages, randomSpawnPoints;
    // Start is called before the first frame update
    void Start()
    {
       SpawnPointGeneration();
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void SpawnPointGeneration()
    {
        maxSpawnPoints = 4; // Max number of current spawn points.
        
        for (i = 0; i < 2; i++) // Chooses spawn points till it hits the max amount of spawns.
        {
            randomSpawnPoints  = Random.Range(0,spawnPoints.Count); // Selects one of possible spawn points.
            spawnPoints[selectedSp] = spawnPoints[randomSpawnPoints];  
            //selectedSp = 4;                                                  // Checks what spawn points are selected
            switch (selectedSp) // If spawn point is selected it is then activated.
            {
                case 0:
                    spawnPoints[0].SetActive(true);
                    spawnPoints.Remove(spawnPoints[0]);
                    break;
                 case 1:
                    spawnPoints[1].SetActive(true);
                    spawnPoints.Remove(spawnPoints[1]);
                    break;
                 case 2:
                    spawnPoints[2].SetActive(true);
                    spawnPoints.Remove(spawnPoints[2]);
                    break;
                 case 3:
                    spawnPoints[3].SetActive(true);
                    spawnPoints.Remove(spawnPoints[3]);
                    break;
                 case 4:
                    spawnPoints[4].SetActive(true);
                    spawnPoints.Remove(spawnPoints[4]);
                    break;
                 case 5:
                    spawnPoints[5].SetActive(true);
                    spawnPoints.Remove(spawnPoints[5]);
                    break;
                 
            }
        }
        
    }

    public void SpriteSpawn()
    {
        int p;
        for (p = 0; p < maxSpawnPoints; p++)
            {
                int randomImages = Random.Range(0,images.Count);
                images[selectedImages] = images[selectedImages];
                switch (selectedImages)
                {
                    case 0:
                    Instantiate(images[1],spawnPoints[selectedSp].transform.position, spawnPoints[selectedSp].transform.rotation);
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }

            }
    }
}
