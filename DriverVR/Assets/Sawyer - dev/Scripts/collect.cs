﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{

    public GameObject player;
    public GameObject muffin;
    public GameObject compass;
    public GameObject home;
    Compass compassScript;
    detect detectScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player) {
            Destroy(gameObject);
            muffin.SetActive(true);
            compassScript.Grannys = home.transform;
            detectScript.collected = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        compassScript = compass.GetComponent<Compass>();
        detectScript = home.GetComponent<detect>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
