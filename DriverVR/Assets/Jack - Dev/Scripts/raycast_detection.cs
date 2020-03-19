using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast_detection : MonoBehaviour
{
    
    public LayerMask mask;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {

        Vector3 dronePos = transform.position;
        Vector3 playerPos = player.transform.position;
        Vector3 direction = playerPos - dronePos;       

        Ray ray = new Ray(dronePos, direction);
        RaycastHit hitInfo;

        if(Physics.Raycast(ray, out hitInfo, 100, mask)) {
            //print(hitInfo.collider.gameObject.name);
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);    
        }
        else {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 100, Color.green);
        }

        /*if(Physics.Raycast(transform.position, direction, out hitInfo)) {
            print("Hit Player");
            Debug.DrawLine(transform.position, hitInfo.point, Color.green);
        }*/


    }
}
