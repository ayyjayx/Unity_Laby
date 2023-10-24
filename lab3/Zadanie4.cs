using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie4 : MonoBehaviour
{

    public float moveSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}