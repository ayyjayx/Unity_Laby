using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2 : MonoBehaviour
{
    public float speed = 5f;
    public bool movingRight = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 10 && movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >= 10)
            {
                movingRight = false;
            }
        }
        else if (transform.position.x > 0 && movingRight == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= 0)
            {
                movingRight = true;
            }
        }
    }
}