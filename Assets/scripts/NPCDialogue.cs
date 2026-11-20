
using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    public GameObject DialoguePanel;

    private void Start()
    {
        DialoguePanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Time!!!");
        if (other.CompareTag("Player"))
        {
            DialoguePanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DialoguePanel.SetActive(false);
        }
    }
}


