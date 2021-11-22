using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpawners : MonoBehaviour
{
    public GameObject [] spawnPoints, menuSpawnPoints, waterPoints;
    public List<GameObject>  images, waterImages;
    public List<int> numbers;
    public int maxSpawnPoints, waterMaxSp, selectedSp, i, w, selectedImages, randomSpawnPoints, randomWaterSpawnPoints, menuBox;
    public bool cZero,cOne,cTwo,cThree,cFour,cFive, cSix, cSeven, cEight, cNine, cTen, iZero,iOne,iTwo,iThree,iFour,iFive, wZero, wOne, wTwo, wThree, wFour, wFive, wSix, wSeven, wIZero, wIOne, wITwo, wIThree, wIFour;
    private Vector3 pos, waterPos, cZeroPos, cOnePos, cTwoPos, cThreePos, cFourPos, cFivePos, cSixPos, cSevenPos, cEightPos, cNinePos, cTenPos,wZeroPos, wOnePos, wTwoPos, wThreePos, wFourPos, wFivePos, wSixPos, wSevenPos, iconOne, iconeTwo, iconeThree, iconeFour, iconeFive, iconeSix, activatedPos;
    private GameObject sP, wSp, imagesP, imagesW;
    private ImageSpawners imageSpawnersScript;

    // Start is called before the first frame update
    void Start()
    {
       SpawnPointGeneration();
       //MenuBar();
       WaterSpawnGeneration();
       //SpriteSpawn(pos);
       //imageSpawnersScript = GameObject.Find("Image Sets").GetComponent<ImageSpawners>();
        //activatedPos = iconOne;

    }
    /* This scripts works by using 3 arrays.
    1 - The first part of the script activates 4 random points of the possible 6 possible spawn points,
    2- It then choses which of the possible 4 images in the second array of 6 possible to spawn in those 4 spawn points  */
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
                    case 6:
                     if (cSix == false)
                    {
                        spawnPoints[6].SetActive(true);
                        cSixPos = spawnPoints[6].transform.position;
                        //imageSpawnersScript.SpriteSpawn(cFivePos);
                        cSix = true;

                        SpriteSpawn(cSixPos);

                        ++i;
                        //++p;
                    }
                    break;
                     case 7:
                     if (cSeven == false)
                    {
                        spawnPoints[7].SetActive(true);
                        cSevenPos = spawnPoints[7].transform.position;
                        //imageSpawnersScript.SpriteSpawn(cFivePos);
                        cSeven = true;

                        SpriteSpawn(cSevenPos);

                        ++i;
                        //++p;
                    }
                    break;
                     case 8:
                     if (cEight == false)
                    {

                        spawnPoints[8].SetActive(true);
                        cEightPos = spawnPoints[8].transform.position;
                        //imageSpawnersScript.SpriteSpawn(cFivePos);
                        cEight = true;

                        SpriteSpawn(cEightPos);

                        ++i;
                        //++p;
                    }
                    break;
                     case 9:
                     if (cNine == false)
                    {

                        spawnPoints[9].SetActive(true);
                        cNinePos = spawnPoints[9].transform.position;
                        //imageSpawnersScript.SpriteSpawn(cFivePos);
                        cNine = true;

                        SpriteSpawn(cNinePos);

                        ++i;
                        //++p;
                    }
                    break;
                    //  case 10:
                    //  if (cTen == false)
                    // {
                    //     //Vector3 cFivePos;
                    //     //int CFiveVal = 5;
                    //     spawnPoints[10].SetActive(true);
                    //     cSixPos = spawnPoints[10].transform.position;
                    //     //imageSpawnersScript.SpriteSpawn(cFivePos);
                    //     cTen = true;

                    //     SpriteSpawn(cTenPos);

                    //     ++i;
                    //     //++p;
                    // }
                    // break;

            }
            //Debug.Log(i);
            Debug.Log(randomSpawnPoints);
        }

    }

    public void WaterSpawnGeneration()
    {
        //Debug.Log("Bruh");
        waterMaxSp = 3;

        while (w < waterMaxSp)
        {
             randomWaterSpawnPoints = Random.Range(0,waterPoints.Length);
             wSp = waterPoints[randomWaterSpawnPoints];

             switch (randomWaterSpawnPoints)
             {
                 case 0:
                 if (wZero == false)
                 {
                     waterPoints[0].SetActive(true);
                     wZeroPos = waterPoints[0].transform.position;
                     wZero = true;
                     WaterSpriteSpawn(wZeroPos);
                     ++w;

                 }

                 break;
                 case 1:
                  if (wOne == false)
                 {
                     waterPoints[1].SetActive(true);
                     wOnePos = waterPoints[1].transform.position;
                     wOne = true;
                     WaterSpriteSpawn(wOnePos);
                     ++w;

                 }

                 break;
                 case 2:
                  if (wTwo == false)
                 {
                     waterPoints[2].SetActive(true);
                     wTwoPos = waterPoints[2].transform.position;
                     wTwo = true;
                     WaterSpriteSpawn(wTwoPos);
                     ++w;
                 }

                 break;
                 case 3:
                  if (wThree == false)
                 {
                     waterPoints[3].SetActive(true);
                     wThreePos = waterPoints[3].transform.position;
                     wThree = true;
                     WaterSpriteSpawn(wThreePos);
                     ++w;

                 }

                 break;
                 case 4:
                  if (wFour == false)
                 {
                     waterPoints[4].SetActive(true);
                     wFourPos = waterPoints[4].transform.position;
                     wFour = true;
                     WaterSpriteSpawn(wFourPos);
                     ++w;
                 }

                 break;
                 case 5:
                  if (wFive == false)
                 {
                     waterPoints[5].SetActive(true);
                     wFivePos = waterPoints[5].transform.position;
                     wFive = true;
                     WaterSpriteSpawn(wFivePos);
                     ++w;
                 }

                 break;
                 case 6:
                  if (wSix == false)
                 {
                     waterPoints[6].SetActive(true);
                     wSixPos = waterPoints[6].transform.position;
                     wSix = true;
                     WaterSpriteSpawn(wSixPos);
                     ++w;
                 }

                 break;
                 case 7:
                  if (wSeven == false)
                 {
                     waterPoints[7].SetActive(true);
                     wSevenPos = waterPoints[7].transform.position;
                     wSeven = true;
                     WaterSpriteSpawn(wSevenPos);
                     ++w;
                 }

                 break;
             }

        }

    }

    public void WaterSpriteSpawn(Vector3 waterPos)
    {
        int randomWaterImages = Random.Range(0, waterImages.Count);
        imagesW = waterImages[randomWaterImages];

        switch (randomWaterImages)
        {
            case 0:
            if (wIZero == false)
            {
                Instantiate(waterImages[0],waterPos, Quaternion.identity);
                wIZero = true;
            }
            else
            {
                WaterSpriteSpawn(waterPos);
            }
            break;
            case 1:
            if (wIOne == false)
            {
                Instantiate(waterImages[1],waterPos, Quaternion.identity);
                wIOne = true;
            }
             else
            {
                WaterSpriteSpawn(waterPos);
            }
            break;
            case 2:
            if (wITwo == false)
            {
                Instantiate(waterImages[2],waterPos, Quaternion.identity);
                wITwo = true;
            }
             else
            {
                WaterSpriteSpawn(waterPos);
            }
            break;
            case 3:
            if (wIThree == false)
            {
                Instantiate(waterImages[3],waterPos, Quaternion.identity);
                wIThree = true;
            }
             else
            {
                WaterSpriteSpawn(waterPos);
            }
            break;
            case 4:
            if (wIFour == false)
            {
                Instantiate(waterImages[4],waterPos, Quaternion.identity);
                wIFour = true;
            }
             else
            {
                WaterSpriteSpawn(waterPos);
            }
            break;
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
                        //GameObject zeroBox = Instantiate(images[0],activatedPos,Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                        //zeroBox.transform.position = activatedPos;
                        //images.RemoveAt(0);

                        iZero = true;
                        //++p;

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
                        //GameObject oneBox = Instantiate(images[1],activatedPos,Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                        //images.RemoveAt(1);
                        iOne = true;

                        //++p;
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
                        //GameObject twoBox = Instantiate(images[2],activatedPos,Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                        //images.RemoveAt(2);
                        iTwo = true;

                        //++p;
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
                        //GameObject threeBox = Instantiate(images[3],activatedPos,Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                        //images.RemoveAt(3);
                        iThree = true;

                        //++p;
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
                        //GameObject fourBox = Instantiate(images[4],activatedPos,Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                        //images.RemoveAt(4);
                        iThree = true;

                        //++p;
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
                        //GameObject fiveBox = Instantiate(images[5],activatedPos,Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                        //images.RemoveAt(5);
                        iFive = true;

                        //++p;
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

        // public void MenuBar ()
        // {
        //     // Have one of the 6 be enabled
        //     // Ounce a image has intantited, instantiate another on the one thats enabled.
        //     // ounce the point has an image disable then set the other one enabled
        //     // use int and switch statement
        //     menuBox = 0;

        //     iconOne = menuSpawnPoints[0].transform.position;
        //     iconeTwo = menuSpawnPoints[1].transform.position;
        //     iconeThree = menuSpawnPoints[2].transform.position;
        //     iconeFour = menuSpawnPoints[3].transform.position;
        //     iconeFive = menuSpawnPoints[4].transform.position;
        //     iconeSix = menuSpawnPoints[5].transform.position;

        //     switch (menuBox)
        //     {
        //         case 0:
        //         activatedPos = iconOne;
        //         menuBox = 1;
        //         break;

        //         case 1:
        //         activatedPos = iconeTwo;
        //         menuBox = 2;
        //         break;

        //         case 2:
        //         activatedPos = iconeThree;
        //         menuBox = 3;
        //         break;

        //         case 3:
        //         activatedPos = iconeFour;
        //         menuBox = 4;
        //         break;

        //         case 4:
        //         activatedPos = iconeFive;
        //         menuBox = 5;
        //         break;

        //         case 5:
        //         activatedPos = iconeSix;
        //         menuBox = 6;
        //         break;
        //     }
        // }
}


