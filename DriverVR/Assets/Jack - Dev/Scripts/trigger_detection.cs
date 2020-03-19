using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_detection : MonoBehaviour
{
    int detectMeter = 0;

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            print("PLAYER ENTERED CONE");
            
            detectMeter += 25;
            print(detectMeter);
            if(detectMeter >= 100) {
                print("GAME OVER");
            }

        }
        else {
            print("NOT PLAYER");
        }
    }
}
