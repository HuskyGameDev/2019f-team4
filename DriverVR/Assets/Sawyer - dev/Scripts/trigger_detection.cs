using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_detection : MonoBehaviour
{
    public GameObject raycast;

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            raycast.SendMessage("PlayerEnter");
            print("PLAYER ENTERED CONE");
        }
        else {
            print("NOT PLAYER");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            raycast.SendMessage("PlayerExit");
            print("PLAYER EXITED CONE");
        }
    }
}
