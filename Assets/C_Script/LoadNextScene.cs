using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{

    // Nom de la scène à charger
    public string sceneName;
    public LoadAndSaveData LoadAndSaveData;
   
    // Assurez-vous que ce GameObject a un Collider 2D avec Is Trigger activé
    private void OnTriggerStay2D(Collider2D other)
    {
        // Vérifiez si le collider a le tag "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log(PlayerPrefs.GetFloat("TimerFinal"));
            LoadAndSaveData.SaveData();
            SceneManager.LoadScene(sceneName);
            
        }
    }

}
