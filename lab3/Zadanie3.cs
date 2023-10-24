using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Zadanie 3
public class Zadanie3 : MonoBehaviour
{
    public float speed = 5f;
    Vector3 current_postition;

    private void Start()
    {
        current_postition = transform.position;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, current_postition) >= 10f)
        {
            transform.Rotate(0, 90, 0, Space.World);
            current_postition = transform.position;
        }

        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
