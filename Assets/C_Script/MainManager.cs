using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{

    public static MainManager Instance;
    public float TimerValue=0f;
    public bool isPaused=false; 
    public bool ResetTimer=false;
    public float BestTime;

    private void Awake()
    {
        
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        
        Instance = this;
        DontDestroyOnLoad(gameObject);
        BestTime=PlayerPrefs.GetFloat("TimerFinal");
    }

    public void UpdateTimer(float time)
    {
        TimerValue=time;
        ResetTimer=false; 
    }

    public void PauseTimer(float time)
    {
        isPaused=true;
        TimerValue=time;
    } 

    public void ContinueTimer()
    {
        isPaused=false;
    }

    public void RestartTimer()
    {
        isPaused=false;
        ResetTimer=true;
        TimerValue=0f; 
    }
 
    public void StoreBestTime(float time)
    {
        BestTime=time;
    }
}
