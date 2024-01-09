using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chrono : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public Text Chronometer;

    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if(TimerOn)
        {
            TimeLeft += Time.deltaTime;
            UpdateTimer(TimeLeft);
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        Chronometer.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
