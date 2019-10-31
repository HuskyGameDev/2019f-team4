using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public Transform player;
    public Transform head;
    public GameObject[] waypoints;
    int currentWP = 0;
    public float rotationSpeed = 0.5f;
    public float speed = 1.5f;
    public float accuracyWP = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - this.transform.position;
        direction.y = 0;
        float angle = Vector3.Angle(direction, head.up);

        if (waypoints.Length > 0) {
            if (Vector3.Distance(waypoints[currentWP].transform.position, transform.position) < accuracyWP) {
                currentWP++;
                if (currentWP >= waypoints.Length) {
                    currentWP = 0;
                }
            }

            //rotate to waypoint
            direction = waypoints[currentWP].transform.position - transform.position;
            this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);
            this.transform.Translate(0, 0, Time.deltaTime * speed);
        }
        
    }
}
