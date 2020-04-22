using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player_detect : MonoBehaviour
{
    public GameObject player;
    public float counter = 5f;
    private float counterMax;
    public bool detected;

    private void Start()
    {
        counterMax = counter;
    }

    private void OnTriggerEnter(Collider detect)
    {
        if (detect.gameObject == player)
        {
            Debug.Log("Player Detected");
            detected = true;
        }
    }

    private void OnTriggerExit(Collider detect)
    {
        if (detect.gameObject == player)
        {
            Debug.Log("Player gone");
            detected = false;
        }
    }

    private void Update()
    {
        if (detected == true)
        {
            counter -= Time.deltaTime;
        }
        if (detected == true && counter <= 0f)
        {
            Debug.Log("Player Found");
            SceneManager.LoadScene(5);
        }
        if (detected == false)
        {
            counter = counterMax;
        }
    }
}