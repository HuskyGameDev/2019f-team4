using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_to_game : MonoBehaviour
{

    public GameObject manager;
    public Immortal managerScript;

    private void Start()
    {
        managerScript = manager.GetComponent<Immortal>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            managerScript.updateMission();
            SceneManager.LoadScene(1);
        }
    }
}
