using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    Vector3 m_pos;

    public float walkSpeed = 2f;
    public float runSpeedMultiplier = 4f;

    public int maxLives = 3;
    private int currentLives;


    float horizontalInput;
    float verticalInput;
    bool isRunning;


    private Rigidbody2D rb;

    void Start()
    {
       
        currentLives = maxLives;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        
        


       

        LookRotation();
    }

    private void FixedUpdate()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(horizontalInput * walkSpeed * 100, verticalInput * walkSpeed * 100);

        rb.velocity = (movement * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            movement = movement * runSpeedMultiplier;
        }
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
        Debug.Log("Vidas restantes: " + currentLives);

        if (currentLives <= 0)
        {
            Debug.Log("Jugador muerto");
        }
    }
}
