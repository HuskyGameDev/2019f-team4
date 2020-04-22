using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detect : MonoBehaviour
{
    public GameObject player;
    public int nextScene;
    public bool collected = false;
    public GameObject manager;
    public Immortal managerScript;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
        managerScript = manager.GetComponent<Immortal>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && collected == true) {
            managerScript.updateMission();
            SceneManager.LoadScene(managerScript.mission);
        }
    }
}
