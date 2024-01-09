using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstCollider : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Asteroide"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        } else
        {
           LoadScene();
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(2);
    }
}
