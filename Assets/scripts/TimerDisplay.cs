using UnityEngine;
using TMPro;

public class TimerDisplay : MonoBehaviour
{
    public TMP_Text timerText;

    private void Update()
    {
        if (GameTimer.Instance != null)
        {
            timerText.text = GameTimer.Instance.GetTime();
        }
    }
}
