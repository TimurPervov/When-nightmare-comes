using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunLuna : MonoBehaviour {

    float hours = 5;
    float minutes = 45;
    public float Speed;

    public Text TextHours;
    public Text TextMinutes;
    public GameObject Centre;
    
	void FixedUpdate () {
        Centre.transform.Rotate(Vector3.right * Speed * Time.deltaTime);
        minutes = minutes + Speed + Time.deltaTime;
        if(minutes>=60)
        {
            hours = hours + 1;
            if(hours>=24)
                            hours=0;
            minutes = 0;
        }
        TextHours.text = hours.ToString();
        TextMinutes.text = minutes.ToString();
	}
}
