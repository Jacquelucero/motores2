using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(horizontalInput * Time.deltaTime, 0, 0);

        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(0, verticalInput * Time.deltaTime, 0);
    }
}
