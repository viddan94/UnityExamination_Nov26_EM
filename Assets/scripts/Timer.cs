using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public static GameTimer Instance;

    private float _elapsedTime = 0f;
    private bool _timerRunning = true;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (_timerRunning)
        {
            _elapsedTime += Time.deltaTime;
        }
    }

    public string GetTime()
    {
        var minutes = Mathf.FloorToInt(_elapsedTime / 60);
        var seconds = Mathf.FloorToInt(_elapsedTime % 60);

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StopTimer()
    {
        _timerRunning = false;
    }
    public void ResetTimer()
    {
        _elapsedTime = 0f;
        _timerRunning = true;
    }
}