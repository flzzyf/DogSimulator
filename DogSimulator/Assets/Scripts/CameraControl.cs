using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour 
{
    public Transform cam;
    public Transform target;
    public Vector3 offset;
    public float cameraSpeed = 1;
	void Start () 
	{
		
	}
	
	void Update () 
	{
        Vector3 targetPos = target.position + offset;

        cam.position = Vector3.Lerp(cam.position, targetPos, cameraSpeed * Time.deltaTime);

    }
}
