using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_detection : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            print("PLAYER ENTERED CONE");
        }
        else {
            print("NOT PLAYER");
        }
    }
}
