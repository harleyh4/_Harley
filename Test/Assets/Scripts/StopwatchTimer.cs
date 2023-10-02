using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class StopwatchTimer : MonoBehaviour
{ 
    //change to stopwatch time
    public float timeToDisplay;
    public TextMeshProUGUI stopwatchTimeText;
    float timeAmount;
    public bool timeOn = false;

    public GameObject goldStarText;
    public GameObject silverStarText;
    public GameObject bronzeStarText;
    // Start is called before the first frame update
    void Start()
    {
      timeAmount = 0;
      timeOn = true;
      goldStarText.SetActive(false);
      silverStarText.SetActive(false);
      bronzeStarText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(timeOn)
        {
            timeAmount +=  Time.deltaTime;
            TimeSpan time = TimeSpan.FromSeconds(timeAmount);
            stopwatchTimeText.text = time.ToString(@"mm\:ss\:fff");
        }
        
        else 
        {
            if(timeAmount <= 30)
            {
                goldStarText.SetActive(true);
            }
            else if(timeAmount <= 30 && timeAmount >=60)
            {
                silverStarText.SetActive(true);
            }
            else if(timeAmount <= 60 && timeAmount >= 90)
            {
                bronzeStarText.SetActive(true);
            }
        }
        
    }
}
