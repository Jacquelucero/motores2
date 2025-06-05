using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private GameObject Player;
    private bool isChasing = false;
    private float chaseTimer = 0f;

    [Header("Configuración")]
    public float chaseDuration = 4f;       
    public float chaseRange = 4f;          
    public float stopChaseRange = 8f;       
    public float moveSpeed = 2f;            

    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        if (Player != null)
        {
            isChasing = true;
        }
    }

    void Update()
    {
        if (Player == null) return;

        float distance = Vector3.Distance(Player.transform.position, transform.position);

        if (distance < chaseRange)
        {
            
            isChasing = true;
            chaseTimer = 0f; 
        }

        if (isChasing)
        {
            if (distance < stopChaseRange)
            {
               
                chaseTimer += Time.deltaTime;
                Vector3 direction = (Player.transform.position - transform.position).normalized;
                transform.Translate(direction * moveSpeed * Time.deltaTime);

                if (chaseTimer >= chaseDuration)
                {
                    isChasing = false; 
                }
            }
            else
            {
                
                isChasing = false;
            }
        }
    }
}
