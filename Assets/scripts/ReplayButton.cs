using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public void RestartGame()
    {
        GameTimer.Instance.ResetTimer();
        SceneManager.LoadScene("Hell level");
    }
}
