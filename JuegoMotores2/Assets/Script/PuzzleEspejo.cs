using UnityEngine;
using TMPro;

public class PuzzleEspejo : MonoBehaviour
{
    public GameObject puzzleUI;           // Panel del Canvas
    public TMP_InputField input1;         // "¿Cuántas personas vivían en esta casa?"
    public TMP_InputField input2;         // "¿Cuántos monstruos rondan por aquí?"
    public TMP_InputField input3;         // "¿Cuántas puertas hay bloqueadas?"
    public TMP_Text resultText;           // Mensaje de resultado
    public GameObject keyObject;          // Llave que aparece

    private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            puzzleUI.SetActive(true);
        }
    }

    public void CheckAnswers()
    {
        string r1 = input1.text;
        string r2 = input2.text;
        string r3 = input3.text;

        if (r1 == "3" && r2 == "7" && (r3 == "1" || r3 == "2"))
        {
            resultText.text = "¡Una llave aparece en la bañera de atrás!";
            keyObject.SetActive(true);
            puzzleUI.SetActive(false);
        }
        else
        {
            resultText.text = "Dibujas tus respuestas en el espejo... Pero parece que son incorrectas...";
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
            puzzleUI.SetActive(false);
        }
    }
}
