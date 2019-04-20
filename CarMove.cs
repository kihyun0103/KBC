using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    int speed = 10;

    void Start()
    {
        
    }

    
    void Update()
    {
        moveObject();
    }

    void moveObject()

    {

        float keyHorizontal = Input.GetAxis("Horizontal");

        float keyVertical = Input.GetAxis("Vertical");


        transform.Translate(Vector3.right * speed * Time.smoothDeltaTime * keyHorizontal, Space.World);

        transform.Translate(Vector3.forward * speed * Time.smoothDeltaTime * keyVertical, Space.World);

    }

    
}
