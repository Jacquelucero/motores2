using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerMovement : MonoBehaviour
{
    Vector3 m_pos;

    public float walkSpeed = 2f;
    public float runSpeed = 4f;
    public int maxLives = 3;
    private int currentLives;
    public TextMeshProUGUI VidasTexto;
    public TextMeshProUGUI gameOverText;
    private Rigidbody2D rb;
    public Transform respawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentLives = maxLives;
        UpdateLivesUI();
    }
    void Update()
    {
       
        bool isRunning = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        float currentSpeed = isRunning ? runSpeed : walkSpeed;

     
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;

        rb.velocity = movement * currentSpeed;



        LookRotation();
    }

    void LookRotation()
    {
        m_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        m_pos.z = 0;
        transform.up = (m_pos - transform.position);
    }
    public void TakeDamage()
    {
        currentLives--;
        UpdateLivesUI();

        Debug.Log("Vidas restantes: " + currentLives);

        // Teletransportar al jugador al punto de reaparición
        if (respawnPoint != null)
        {
            transform.position = respawnPoint.position;
            rb.velocity = Vector2.zero; // detener movimiento
        }

        if (currentLives <= 0)
        {
            Debug.Log("Jugador muerto");
            if (gameOverText != null)
            {
                gameOverText.gameObject.SetActive(true);
            }
            enabled = false;
        }
    }

    void UpdateLivesUI()
    {
        if (VidasTexto != null)
        {
            VidasTexto.text = "Vidas: " + currentLives;
        }
    }

}
