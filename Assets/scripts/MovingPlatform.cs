using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        float movement = Mathf.PingPong(
            Time.time * speed,
            distance
        );

        transform.position = startPosition +
                             Vector3.up * movement;
    }
}
