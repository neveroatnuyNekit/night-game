using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody rb;
    public static bool isGrounded = false;
    public int jump;
    public int speed;
    public float mouseSensivity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveby = x * speed;
        transform.Translate(Vector3.right*x*speed/100);
        //rb.velocity = new Vector3(moveby, rb.velocity.y,0);
        float y = Input.GetAxisRaw("Vertical");
        float movebyy = y * speed;
        transform.Translate(Vector3.forward*y*speed/100);
        if(Input.GetAxis("Jump")>0 && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jump, rb.velocity.z);
            isGrounded=false;
        }

        float MouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        transform.rotation *= Quaternion.Euler(transform.rotation.x, MouseX, transform.rotation.z);
        //transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y+Input.GetAxis("Mouse X") * mouseSensivity,transform.rotation.z);

        //CheckIfGrounded();
    }
    void OnTriggerEnter(Collider other) { 
        if(other.gameObject.layer==4)
        {
            isGrounded=true;
        }
    }
    void OnTriggerStay(Collider other) { 
        if(other.gameObject.layer==4)
        {
            isGrounded=true;
        }
    }
    void OnTriggerExit(Collider other) { 
        if(other.gameObject.layer==4)
        {
            isGrounded=false;
        }
    }


    
}
