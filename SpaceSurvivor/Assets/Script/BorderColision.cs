using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderColision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("borderSide"))
        {
            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x,
                transform.eulerAngles.y + 180,
                transform.eulerAngles.z
            );          
        } else if (collision.gameObject.CompareTag("Border"))
        {
            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x + 180,
                transform.eulerAngles.y,
                transform.eulerAngles.z
            );
        }
    }
}
