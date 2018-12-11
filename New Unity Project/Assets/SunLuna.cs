using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunLuna : MonoBehaviour {

        private float Speed=15.0f; //ОТНОШЕНИЕ 1 ГРАДУСА К ОДНОМУ TMIE = 1/4 БЛЯТЬ
    public Text TextTime;
    public GameObject Centre; 
public GameObject Stars;

int hours=0;
float minutes=0;
float tmie=360;

private const float CheckPeriod = 1f;
private float m_LastCheck = CheckPeriod;
private int m_speed = 100;

float a=0;

void Start()
{
	
}
    
	
void FixedUpdate () {
        
m_LastCheck = m_LastCheck -Time.deltaTime;
if (m_LastCheck<0)
{

Centre.transform.Rotate(-1*Vector3.right*Speed);
       tmie=tmie+60;
       if (tmie >= 1440)
	tmie = 0;
	
if (tmie>360 && tmie<1080)
	Stars.SetActive(false);
else Stars.SetActive(true);

m_LastCheck=CheckPeriod;
}

      minutes = tmie%60;
      hours = (int) Math.Truncate(tmie/60);

//TextTime.text = a.ToString();
TextTime.text = hours.ToString() + " часов " +minutes.ToString() + " минут ";

        }
        
}
