using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat_trees : MonoBehaviour
{
    private bool neartree=tought_trees.neartree;
    private GameObject tree=tought_trees.another;
    public GameObject wood;
    //public static bool have_wood=false;
    private GameObject cub;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            neartree=tought_trees.neartree;
            if (neartree==true)
            {
                Destroy(tree);
                cub = Instantiate(wood);
                cub.transform.position=new Vector3(transform.position.x,transform.position.y,transform.position.z);
                    //transform.Translate(Vector3.back);
                    //cub.transform.rotation = Quaternion.Euler(transform.rotation.x,transform.rotation.y, transform.rotation.z);
                    //cub.transform.Translate(Vector3.forward);
                transform.Translate(Vector3.back);
                //have_wood=true;
                neartree=false;
                neartree=tought_trees.neartree;
                tought_trees.neartree=false;
            }
            
        }
        
        tree=tought_trees.another;
        neartree=tought_trees.neartree;
    }
}
