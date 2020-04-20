using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public Vector3 North;
    public Transform Player;
    public Quaternion GrandmasHouse;

    public RectTransform Northlayer;
    public RectTransform Missionlayer;

    public Transform Grannys;
    // Update is called once per frame
    void Update()
    {
        ChangeNorthDirection();
        ChangeMissionDirection();

    }

    public void ChangeNorthDirection()
    {
        North.z = Player.eulerAngles.y;
        Northlayer.localEulerAngles = North;

    }

    public void ChangeMissionDirection()
    {
        Vector3 direction = transform.position - Grannys.position;

        GrandmasHouse = Quaternion.LookRotation(direction);

        GrandmasHouse.z = GrandmasHouse.y;
        GrandmasHouse.x = 0;
        GrandmasHouse.y = 0;

        Missionlayer.localRotation = GrandmasHouse * Quaternion.Euler(North);

    }
}
