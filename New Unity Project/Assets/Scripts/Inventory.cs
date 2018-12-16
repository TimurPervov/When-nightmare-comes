using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Inventory : MonoBehaviour
{
public GameObject player;
	public Camera cam;
    public GameObject cellContainer;
    List<Item> item;
private float x,y,z;
    public KeyCode openInventory;

	// Use this for initialization
	void Start () {
        item = new List<Item>();
        for (int i=0;i<cellContainer.transform.childCount;i++)
        {
            item.Add(new Item());
        }
	}
	
	// Update is called once per frame
	void Update () {
OpenInventory();

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
                if (hit.collider.GetComponent<Item>())
                {
                    for (int i=0;i<item.Count;i++)
                    {
                        if (item[i].id==0)
                        {
		x=hit.collider.GetComponent<Item>().gameObject.transform.position.x - player.transform.position.x;
		y=hit.collider.GetComponent<Item>().gameObject.transform.position.y - player.transform.position.y;
		z=hit.collider.GetComponent<Item>().gameObject.transform.position.z - player.transform.position.z;
		
if (Math.Abs(x)<0.4 && Math.Abs(y)<0.4 && Math.Abs(z)<0.4)
{
                            item[i] = hit.collider.GetComponent<Item>();
                            Destroy(hit.collider.GetComponent<Item>().gameObject);
		DisplayItems();
                            break;
}

                        }
                    }
                }
            }
        }

		
	}

    void OpenInventory()
    {
        if (Input.GetKeyDown(openInventory))
            if (cellContainer.activeSelf)
            {
                cellContainer.SetActive(false);
            }
            else cellContainer.SetActive(true);

    }

	void DisplayItems()
{
	for (int i=0;i<item.Count;i++)
{
Transform cell = cellContainer.transform.GetChild(i);
		Transform icon = cell.GetChild(0);
		Image img = icon.GetComponent<Image>();
	if (item[i].id !=0 )
	{
		img.enabled = true;
		
		img.sprite = Resources.Load<Sprite>(item[i].pathIcon);
	}
	else { img.enabled = false; }
}
}

}
