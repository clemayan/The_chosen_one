using UnityEngine;

public class LoadAndSaveData : MonoBehaviour
{
    
    public static LoadAndSaveData instance;
    public static MainManager Instance; 
    private float PrevTimer=0f;

    private void Awake ()
    {
        if (instance != null)
        {
            //Debug.LogWarming("probleme");
            return;
        }
        instance = this;
    }
    
    
    
    // Start is called before the first frame update
    void Update()
    {
       if(MainManager.Instance.ResetTimer)
       {
        ResetTimerData();
       }
    }   

    public void SaveData()
    {
        PrevTimer=PlayerPrefs.GetFloat("TimerCount");
        PlayerPrefs.SetFloat("TimerCount", PrevTimer + MainManager.Instance.TimerValue);

    }
    
    public void SaveFinalTime()
    {


        PrevTimer=PlayerPrefs.GetFloat("TimerCount");
        Debug.Log(PlayerPrefs.GetFloat("TimerFinal"));

        if (PlayerPrefs.GetFloat("TimerFinal")==0 || 
        PlayerPrefs.GetFloat("TimerFinal") >PrevTimer)

        {
          PlayerPrefs.SetFloat("TimerFinal", PrevTimer);
          MainManager.Instance.StoreBestTime(PrevTimer);
        }
        
    }

    public void ResetTimerData()
    {
        PlayerPrefs.SetFloat("TimerCount",0f);
    }
}
