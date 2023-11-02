using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class timer : MonoBehaviour
{

    public float timeRemaining = 0;
    public bool timeIsRunnung = true;
    public TMP_Text timeText;
    
    // Start is called before the first frame update
    void Start()
    {
        timeIsRunnung=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeIsRunnung)
        {
            if (timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }
    }
    void DisplayTime (float timetoDisplay)
    {
        timetoDisplay += 1;
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        float miliseconds = Mathf.FloorToInt(timeRemaining % 60);
        timeText.text = string.Format ("{0:00} : {1:00}", minutes, seconds, miliseconds);
    
    
    }


}
