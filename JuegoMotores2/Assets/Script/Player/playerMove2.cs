using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class playerMove2 : MonoBehaviour
{
    Vector3 m_pos;

    public float walkSpeed = 2f;
    public float runSpeed = 4f;
    private int maxLives = 3;
    public int currentLives => maxLives;
    public TextMeshProUGUI VidasTexto;

    private Rigidbody2D rb;
    public Transform respawnPoint;

    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        UpdateLivesUI();

        animator = GetComponent<Animator>();
    }
    void Update()
    {

        Move();







    }

    void Move()
    {        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        


        bool isRunning = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        float currentSpeed = isRunning ? runSpeed : walkSpeed;

        

        

        rb.velocity = movement * currentSpeed;

        animator.SetFloat("inputX", horizontalInput);
        animator.SetFloat("inputY", verticalInput);
        
        
        if (horizontalInput == 0 && verticalInput == 0)
        {
            animator.SetBool("isWalking", false);
            
        }
        else
        {
            animator.SetBool("isWalking", true);
            animator.SetFloat("lastInputX", horizontalInput);
            animator.SetFloat("lastInputY", verticalInput);
        }


    }

    
      
    public void TakeDamage()
    {
        maxLives--;
        UpdateLivesUI();

        Debug.Log("Vidas restantes: " + currentLives);

        // Teletransportar al jugador al punto de reaparición
        if (respawnPoint != null)
        {
            transform.position = respawnPoint.position;
            rb.velocity = Vector2.zero; // detener movimiento
        }

        if (maxLives <= 0)
        {
            SceneController.Instance.ToGameOver();
        }
    }

    void UpdateLivesUI()
    {
        if (VidasTexto != null)
        {
            VidasTexto.text = maxLives.ToString();
        }
    }
}
