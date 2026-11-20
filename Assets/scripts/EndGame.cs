using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameTimer.Instance.StopTimer();
            SceneManager.LoadScene("endscreen");
        }
    }
}
    

