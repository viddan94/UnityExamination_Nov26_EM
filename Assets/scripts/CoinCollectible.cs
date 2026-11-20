using UnityEngine;

public class CoinCollectible : MonoBehaviour
{
    [SerializeField] private int coinValue = 1;
    [SerializeField] private GameObject particleEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (CoinManager.Instance == null)
            return;

        // Add coin
        CoinManager.Instance.AddCoin(coinValue);

        // Spawn particle effect
        if (particleEffect != null)
        {
            GameObject effect = Instantiate(
                particleEffect,
                transform.position,
                Quaternion.identity
            );

            effect.SetActive(true);

            ParticleSystem[] systems =
                effect.GetComponentsInChildren<ParticleSystem>();

            foreach (ParticleSystem ps in systems)
            {
                ps.Play();
            }
        }

        // Destroy coin
        Destroy(gameObject);
    }
}