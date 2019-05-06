using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour {

	
	void Update () {
        transform.LookAt(FindObjectOfType<Camera>().transform);    //LookAt 어떤 위치를 주면 그 방향을 계속 보고있음
                                                                   //현재 활성화되고있는 카메라
    }
}
