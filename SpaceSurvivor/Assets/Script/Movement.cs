using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2;
    public float rotaspeed = 200;
    // Update is called once per frame
    void Update()
    {
       
        float MoveX = Input.GetAxis("Horizontal");
        float MoveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(0, MoveY);
        transform.Translate(movement * Time.deltaTime * speed);
        transform.Rotate(Vector3.back * MoveX * Time.deltaTime * rotaspeed);


    }
}
