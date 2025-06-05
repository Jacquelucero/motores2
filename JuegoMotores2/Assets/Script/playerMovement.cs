using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Vector3 m_pos;

    public float walkSpeed = 2f;
    public float runSpeed = 4f;

    void Update()
    {
        // Verificamos si está presionando Shift
        bool isRunning = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        float currentSpeed = isRunning ? runSpeed : walkSpeed;

        // Movimiento
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0).normalized;

        transform.Translate(movement * currentSpeed * Time.deltaTime);

        // Rotación hacia el mouse
        LookRotation();
    }

    void LookRotation()
    {
        m_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        m_pos.z = 0;
        transform.up = (m_pos - transform.position);
    }
}
