using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lol : MonoBehaviour
{
	public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	if(Input.GetMouseButtonDown(0))
{
        Ray ray = cam.ScreenPointToRay(new Vector3(Input.mousePosition.x,Input.mousePosition.y,1));
	RaycastHit hit;
	if (Physics.Raycast(ray,out hit, Mathf.Infinity));
	{
		Destroy(hit.transform.gameObject);
	}
}
    }
}
