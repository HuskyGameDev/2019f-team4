using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Chase : MonoBehaviour
{
    public Transform player;
    public float RSpeed = 3.0f;
    public float MSpeed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        /*turn to face player*/
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position),RSpeed * Time.deltaTime);

        /* Move to Player*/
        transform.position += transform.forward * MSpeed * Time.deltaTime;
    }
}
