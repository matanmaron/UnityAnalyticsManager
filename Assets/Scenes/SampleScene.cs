using MaronByteStudio.AnalyticsManager;
using UnityEngine;
using UnityEngine.UI;

public class SampleScene : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] AnalyticsManager analyticsManager;
    
    private void Start()
    {
        button.onClick.AddListener(SendAnalytics);
    }

    private void SendAnalytics()
    {
        analyticsManager.SendAnalyticsEvent("Button Clicked");
    }
}
