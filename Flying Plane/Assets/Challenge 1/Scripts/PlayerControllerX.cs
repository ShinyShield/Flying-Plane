using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject wall;
    public GameObject player;
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {  

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        

        // tilt the plane up/down based on up/down arrow 
        float rotation = transform.rotation.x - verticalInput;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(rotation - rotationSpeed * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(rotation + rotationSpeed * Time.deltaTime, 0, 0));
        }
        else if (transform.rotation.x > 0)
        {
            transform.Rotate(new Vector3(transform.rotation.x + rotationSpeed * Time.deltaTime, 0, 0));
        }
        else if (transform.rotation.x < 0)
        {
            transform.Rotate(new Vector3(transform.rotation.x - rotationSpeed * Time.deltaTime, 0, 0));
        }


        //float currentRotation = transform.rotation.eulerAngles.y;
        //float clampedRotation = Mathf.Clamp(currentRotation, -45, 45);
        //transform.Rotate(Vector3.right * -verticalInput * rotationSpeed * Time.deltaTime);
        //  if(transform.rotation.x < 45 || transform.rotation.x > -45)
        //  {
        // 
        // }

        /*if (transform.rotation.x >= 45.0f || transform.rotation.x <= -45.0f)
        {
            
        }
        else
        {
            transform.Rotate(new Vector3(0,0,0) );
        }*/
        // get the user's vertical input


        // float currentY = Mathf.Lerp(0, 7000f, Time.deltaTime / 0.5f);
        // transform.position = new Vector3(transform.position.x,
        //                              transform.position.y + currentY * Time.deltaTime,
        //                            transform.position.z);

        //transform.Translate(new Vector3(0, -0.2f, 0));


    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Time.timeScale = 0;
            //game over
        }
    }
}
