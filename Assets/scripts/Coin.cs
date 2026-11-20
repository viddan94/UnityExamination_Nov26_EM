using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotateSpeed = 180f;

    private void Update()
    {
        transform.Rotate(0, 1, 0);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("Unity Event Trigger (enter) activated on " + gameObject);
        }
    }
}
