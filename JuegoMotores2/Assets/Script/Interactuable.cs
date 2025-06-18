using UnityEngine;

public class Interactuable : MonoBehaviour
{
    public GameObject uiToShow; // Lo que se activa al interactuar (panel, llave, texto, etc.)
    public PaperText clueReference;

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
        if (collision.gameObject.CompareTag("Player"))
        {
            clueReference.SetText(clueReference.clueNumber);
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
            uiToShow.SetActive(false);
        }
    }
}
