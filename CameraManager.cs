using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraManager : MonoBehaviour
{
    public Camera firstCamera;
    public Camera secondCamera;

    public void secondView()
    {
        firstCamera.enabled = false;
        secondCamera.enabled = true;
    }

    public void firstView()
    {
        firstCamera.enabled = true;
        secondCamera.enabled = false;
    }

    public void Update()
    {
        if(Input.GetKey("1"))
        {
            secondView();
        }

        if(Input.GetKey("2"))
        {
            firstView();
        }
    }
}
