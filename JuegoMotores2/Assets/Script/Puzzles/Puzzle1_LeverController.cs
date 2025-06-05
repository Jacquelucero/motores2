using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1_LeverController : MonoBehaviour
{
    [SerializeField] private Puzzle1 Puzzle1;
    [SerializeField] private int thisLeverNumber;

    private bool isActive;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            if (!isActive)
            {
                Debug.Log("Activaste la palanca numero: " + thisLeverNumber);
                Puzzle1.isActive[thisLeverNumber] = true;
                isActive = true;
            }
            else
            {
                Debug.Log("Desactivaste la palanca numero: " + thisLeverNumber);
                Puzzle1.isActive[thisLeverNumber] = false;
            }
        }
    }
}
