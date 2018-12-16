using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleMovement : MonoBehaviour {

	public float speedMove;
	private Vector3 moveVector;
	
	private CharacterController chcon;
	private Animator animat;

	private void Start()
{
	chcon = GetComponent<CharacterController>();
	animat = GetComponent<Animator>();
	
}

private void Update()
{
	CharacterMove();
}

private void CharacterMove()
{
	moveVector = Vector3.zero;
	moveVector.x = Input.GetAxis("Horizontal")*speedMove;
	moveVector.z = Input.GetAxis("Vertical")*speedMove;


	if (moveVector.x!=0 || moveVector.z!=0) animat.SetBool("MoveBool",true);
else animat.SetBool("MoveBool",false);

	if (Vector3.Angle(Vector3.forward, moveVector)>1.0f || Vector3.Angle(Vector3.forward, moveVector) == 0)
{
	Vector3 direct = Vector3.RotateTowards(transform.forward,moveVector,speedMove,0.0f);
transform.rotation = Quaternion.LookRotation(direct);
}
 
chcon.Move(moveVector*Time.deltaTime);
}
}
