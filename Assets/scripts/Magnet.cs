using UnityEngine;
public class MagneticField2D : MonoBehaviour
{
    public float forceStrength = 500f;
    void OnTriggerStay2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Vector2 direction = (Vector2)transform.position - rb.position;
            rb.AddForce(direction.normalized * forceStrength * Time.fixedDeltaTime);
        }
    }
}