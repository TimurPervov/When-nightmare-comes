using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraScript : MonoBehaviour {

public GameObject Hero;
private Vector3 vec;
private float x,y,z;

	
	void Start () {
		
	}
	

	void Update () {
		MoveCamera();
	}

	void MoveCamera()
{
	vec=Hero.transform.position;
	/*x=vec.x;
	y=vec.y + 2.5f;
	z=vec.z-1.7f;*/
	transform.position = new Vector3(vec.x,vec.y+2.5f, vec.z-1.7f);
	
}
}
