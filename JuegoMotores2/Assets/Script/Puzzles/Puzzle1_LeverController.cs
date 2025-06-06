using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1_LeverController : MonoBehaviour
{
    [SerializeField] private Puzzle1 Puzzle1;
    [SerializeField] private int thisLeverNumber;

    
    private float timeElapsed;
   
    private bool canPress = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canPress = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canPress = false;
        }
    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (canPress && Input.GetKey(KeyCode.E) && Puzzle1.leverState[thisLeverNumber] == false && timeElapsed >= Puzzle1.leverTimeCooldown)
        {

            Debug.Log("Activaste la palanca numero: " + thisLeverNumber);
            Puzzle1.leverState[thisLeverNumber] = true;
            timeElapsed = 0;
                             
        }

       if (canPress && Input.GetKey(KeyCode.E) && Puzzle1.leverState[thisLeverNumber] == true && timeElapsed >= Puzzle1.leverTimeCooldown)
        {

           Debug.Log("Destivaste la palanca numero: " + thisLeverNumber);
            Puzzle1.leverState[thisLeverNumber] = false;
            timeElapsed = 0;


        }
    }


}
