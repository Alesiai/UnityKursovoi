using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replacer1 : MonoBehaviour
{
    public GameObject Face;
    public GameObject Scales;
    public GameObject Device;
    public GameObject Bridge;
    public GameObject Play;

    bool move = false;
    Vector3 startPosition;
    Vector3 needPosition;
    float speed = 0.04f;
    float offset = 0;
    Quaternion startRotation;
    Quaternion needRotaton;


    public void PlayMove()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = Play.transform.position;
            needRotaton = Play.transform.rotation;
        }

    }

    public void Move()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = Device.transform.position;
            needRotaton =  Device.transform.rotation;
        }

    }

    public void Move1()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = Face.transform.position;
            needRotaton = Face.transform.rotation;

        }

    }
    public void MoveToBridge()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = Bridge.transform.position;
            needRotaton = Bridge.transform.rotation;

        }

    }
    public void Move0()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = Scales.transform.position;
            needRotaton = Scales.transform.rotation;

        }

    }


    void FixedUpdate()
    {

        if (move)
        {
            offset += speed;
            transform.position = Vector3.Lerp(startPosition, needPosition, offset);
            transform.rotation = Quaternion.Lerp(startRotation, needRotaton, offset);

            if (offset >= 1)
            {
                move = false;
                offset = 0;
            }
        }
    }
}


