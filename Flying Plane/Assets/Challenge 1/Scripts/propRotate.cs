using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class propRotate : MonoBehaviour
{
    Vector3 rotate = new Vector3(0, 0, 180);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        transform.Rotate(0, 0, 1440 * Time.deltaTime);
    }
}
