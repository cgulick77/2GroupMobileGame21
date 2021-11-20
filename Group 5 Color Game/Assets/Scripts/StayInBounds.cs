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
            Mathf.Clamp(target.position.x, 49.2f, -59),
            Mathf.Clamp(target.position.y, 8f, -6.4f),
            transform.position.z);


        

    }
}
