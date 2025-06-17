using UnityEngine;

public class Interactuable : MonoBehaviour
{
    public GameObject uiToShow; // Lo que se activa al interactuar (panel, llave, texto, etc.)

    private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (uiToShow != null)
            {
                uiToShow.SetActive(true); // Activa el objeto (puede ser un panel, texto, etc.)
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
