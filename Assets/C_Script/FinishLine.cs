using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    // Nom de la scène à charger
    public LoadAndSaveData LoadAndSaveData;
    public string sceneName;
   
    // Assurez-vous que ce GameObject a un Collider 2D avec Is Trigger activé
    private void OnTriggerStay2D(Collider2D other)
    {
        // Vérifiez si le collider a le tag "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("oui");
            LoadAndSaveData.SaveData();
            LoadAndSaveData.SaveFinalTime();
            Debug.Log(PlayerPrefs.GetFloat("TimerFinal"));
            SceneManager.LoadScene(sceneName);
        }
    }

}
