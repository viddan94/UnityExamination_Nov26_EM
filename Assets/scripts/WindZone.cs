using UnityEngine;

public class WindZone : MonoBehaviour
{
    public float windForce = 10f;

    private void OnTriggerStay2D(Collider2D other)
    {
        Rigidbody2D rb = other.attachedRigidbody;

        if (rb != null)
        {
            rb.AddForce(Vector2.up * windForce);
            Debug.Log("Wind affecting: " + other.name);
        }
    }
}
