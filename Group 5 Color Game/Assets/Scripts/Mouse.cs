using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, 53.3f, -54.8f),
            Mathf.Clamp(transform.position.y, 0.5f, -14.6f),
            transform.position.z);
    }
}
