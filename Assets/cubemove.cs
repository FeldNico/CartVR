using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class cubemove : MonoBehaviour
{
    public GameObject Anchor;
    
    public float speed = 1;
 
    void Update () {
        Vector3 pos = transform.position;
        var rot = transform.rotation;
        
        //pos = pos + transform.forward * speed * Time.deltaTime;
        
        if (Input.GetKey ("d"))
        {
            rot =Quaternion.AngleAxis(0.2f, Vector3.up) * rot;
        }
        if (Input.GetKey ("a")) {
            rot =Quaternion.AngleAxis(-0.2f, Vector3.up) * rot;
        }

        transform.rotation = rot;
        //transform.position = pos;

        //speed = speed * 0.999f;
        
        if (Input.GetKeyDown("w"))
        {
            GetComponent<Rigidbody>().velocity = transform.forward*10;

            return;
            if (speed < 0.1)
            {
                speed = 1;
            }

            
            if (speed < 8)
                speed = speed * 1.2f;
                
        }
    }
}
