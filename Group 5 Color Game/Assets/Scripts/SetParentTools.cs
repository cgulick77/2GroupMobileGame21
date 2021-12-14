using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParentTools : MonoBehaviour
{
    public Transform toolParent;
    public GameObject tool;
    // Start is called before the first frame update
    void Start()
    {
        
        tool.transform.SetParent(toolParent, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
