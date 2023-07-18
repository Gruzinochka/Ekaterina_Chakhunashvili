using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoadGener : MonoBehaviour
{
    public GameObject RoadPref;
    private List<GameObject> RoadCount = new List<GameObject>();
    public float maxSpeed=10;
    public float Speed=0;
    public int count = 5;
    public List<GameObject> EnemyPrefs = new List<GameObject>();
    public float Timer;
    public float Timer1;


    private void Start()
    {
        RestartLvl();
        StartLevel();
    }

    public void StartLevel()
    {
        Speed = maxSpeed;
    }

    private void Update()
    {
        Timer += Time.deltaTime;
        if (Timer>30)
        {
            Timer1 += Time.deltaTime;
        }
        if (Timer1>5)
        {
            Speed = Speed + Timer / 20;
            Timer = 0;
        }
        if (Speed == 0) return;
        foreach (GameObject road in RoadCount)
        {
            road.transform.position -= new Vector3(0, 0, Speed * Time.deltaTime);
        }

        if (RoadCount[0].transform.position.z<-25)
        {
            Destroy(RoadCount[0]);
            RoadCount.RemoveAt(0);
            CreateEnemy();
            // CreateRoad();
        }
    }

    public void CreateEnemy()
    {
        Vector3 pos = Vector3.zero;
        if (RoadCount.Count>0)
        {
            pos = RoadCount[RoadCount.Count - 1].transform.position + new Vector3(0, 0, 15);
        }

        GameObject go = Instantiate(EnemyPrefs[Random.Range(0,4)], pos,Quaternion.identity);
        go.transform.SetParent(transform);
        RoadCount.Add(go);
    }
    
    public void CreateRoad()
    {
        Vector3 pos = Vector3.zero;
        if (RoadCount.Count>0)
        {
            pos = RoadCount[RoadCount.Count - 1].transform.position + new Vector3(0, 0, 15);
        }

        GameObject go = Instantiate(RoadPref, pos,Quaternion.identity);
        go.transform.SetParent(transform);
        RoadCount.Add(go);
    }

    public void RestartLvl()
    {
        Speed = 0;
        while (RoadCount.Count >0)
        {
            Destroy(RoadCount[0]);
            RoadCount.RemoveAt(0);
        }

        for (int i = 0; i < count; i++)
        {
            CreateRoad();
        }
    }
}
