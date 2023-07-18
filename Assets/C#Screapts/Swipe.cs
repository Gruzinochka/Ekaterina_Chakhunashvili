using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{
    public Rigidbody PlRig;
    public bool Groud;
    public float timer=5;
    public GameObject Main;
    public float Speed;
    public GameObject Lose;
    public Text Money;
    public int JumpSpeed = 500;
    public float Tim;
    

    public void OnCollisionEnter(Collision other)
    {
        Groud = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Enemy")
        {
            Time.timeScale = 0;
            Lose.SetActive(true);
        }

        if (other.tag=="Coin")
        {
            Money.text = (Convert.ToInt32(Money.text)+1).ToString();
            Destroy(other.gameObject);
        }

        if (other.tag=="Buff")
        {
            Buff();
            Destroy(other.gameObject);
        }
    }

    public void Update()
    {
        Tim += Time.deltaTime;
        if (Tim>5)
        {
            JumpSpeed = 500;
        }
        
        if (timer<=1)
        {
            Main.transform.localScale = Vector3.Lerp(Main.transform.localScale, new Vector3(2, 0.5f, 1),Time.deltaTime*Speed);
        }
        
        if (timer>1)
        {
            Main.transform.localScale= Vector3.Lerp(Main.transform.localScale, new Vector3(1, 1, 1),Time.deltaTime*Speed);
        }
        timer += Time.deltaTime;
    }

    public void Jump()
    {
        if (Groud==true)
        {
            PlRig.AddForce(0,JumpSpeed,0);
            Groud = false;
        }
    }
    public void BuyBuff()
    {
        if (Convert.ToInt32(Money.text)>5)
        {
            Money.text = (Convert.ToInt32(Money.text) - 5).ToString();
            Tim = 0;
            JumpSpeed = 800;
        }
    }
    public void Buff()
    {
        Tim = 0;
        JumpSpeed = 800;
    }
    public void Down()
    {
        timer = 0;
    }
}
