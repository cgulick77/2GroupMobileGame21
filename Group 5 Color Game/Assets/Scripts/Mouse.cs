using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Camera mainCamera;
    Vector3 mouseWorldPosition;
    // Update is called once per frame
    void Update()
    {
        
        

         //Debug.Log(mainCamera.ScreenToWorldPoint(Input.mousePosition));
         mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
         mouseWorldPosition.z = 0f;
         transform.position = mouseWorldPosition;

         mouseWorldPosition.x = Mathf.Clamp(mouseWorldPosition.x, -46.1f, 101.2f);
         mouseWorldPosition.y = Mathf.Clamp(mouseWorldPosition.y, -19f, 68.7f);
         


    }
}
