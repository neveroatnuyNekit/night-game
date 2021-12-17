using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tought_trees : MonoBehaviour
{
    public static GameObject another;
    public static bool neartree=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="tree")
        {
            another=other.gameObject;
            neartree=true;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if(other.tag=="tree")
        {
            another=other.gameObject;
            neartree=true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag=="tree")
        {
            another=null;
            neartree=false;
        }
    }
}
