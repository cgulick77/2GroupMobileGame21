using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInBounds : MonoBehaviour
{
    public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(target.position.x, 82.8f, -27.8f),
            Mathf.Clamp(target.position.y, 14.8f, -5.4f),
            transform.position.z);


        

    }
}
