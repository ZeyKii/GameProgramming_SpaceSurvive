using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting.Antlr3.Runtime;

public class AstCollider : MonoBehaviour
{
    private float score;
    public Collider2D Asteroide;
    public Collider2D Border;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Asteroide"), LayerMask.NameToLayer("Border"));

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
        }
        else if (collision.gameObject.CompareTag("Vaisseau"))
        {
            LoadScene();
        }
    }
    void LoadScene()
    {
        score = GameObject.Find("Chrono").GetComponent<Chrono>().TimeLeft;

        PlayerPrefs.SetFloat("FinalScore", score);

        SceneManager.LoadScene(2);
    }
}
