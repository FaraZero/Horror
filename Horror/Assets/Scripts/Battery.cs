﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery :MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void UseBattery()
    {
        player.GetComponentInChildren<FlashLight>().AddEnergy();
        Destroy(gameObject);
    }

    void Update()
    {

    }
}