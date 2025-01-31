 using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void OnRecommencerButtonClicked()
    {
        MainManager.Instance.RestartTimer();
    }

    public void OnContinuerButtonClicked()
    {
        MainManager.Instance.ContinueTimer();
    }
}