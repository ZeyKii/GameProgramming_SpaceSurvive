using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplay : MonoBehaviour
{
    public Text finalScoreText;

    void Start()
    {
        // Récupérez le score final depuis PlayerPrefs
        float finalScore = PlayerPrefs.GetFloat("FinalScore", 0.0f);

        // Affichez le score final dans le Text component
        finalScoreText.text = "Score Final : " + finalScore.ToString("F0");
    }
}
