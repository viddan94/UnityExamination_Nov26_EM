using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public AudioClip pickUpSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("IT WORKS I THINK");
        AudioSource.PlayClipAtPoint(pickUpSound, transform.position);
        Destroy(gameObject);
    }
}