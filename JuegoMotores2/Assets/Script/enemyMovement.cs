using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    private GameObject Player;
    private bool isChasing = false;
    private float chaseDuration = 4f;
    private float chaseTimer = 0f;

    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        isChasing = true; 
    }

    void Update()
    {
        if (isChasing && Player != null)
        {
            
            chaseTimer += Time.deltaTime;

            
            Vector3 direction = (Player.transform.position - transform.position).normalized;
            transform.Translate(direction * Time.deltaTime);

     
            if (chaseTimer >= chaseDuration)
            {
                isChasing = false;
            }
        }
    }
}
