using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //On appel le Text//


public class Timer : MonoBehaviour
{
    public static Timer instance;
    public Text timerText;
    float time;
    

    void Awake() // un void qui est lancé avant même la création de la scène est qui permet d'initialiser certaine chose//
    {
        time = (int)MainManager.Instance.TimerValue;
    }

    void Update()
    {
        if (!MainManager.Instance.isPaused)
        {
            time += Time.deltaTime;
            UpdateTimerText();
            MainManager.Instance.UpdateTimer(time);
        }
    }

    void UpdateTimerText()
    {
        if (timerText == null)
        {
            Debug.LogError("Timer Text is not assigned in the Inspector");
            return;
        }

        int minutes = Mathf.FloorToInt(time / 60F);
        int seconds = Mathf.FloorToInt(time % 60F);
        int milliseconds = Mathf.FloorToInt((time * 100F) % 100F);
        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }

    public void Pause()
    {
        MainManager.Instance.PauseTimer(time);
    }

}
