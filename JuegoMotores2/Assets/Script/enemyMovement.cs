using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    private Transform currentTarget;

    public float patrolSpeed = 1.5f;
    public float chaseSpeed = 3f;
    public float stopChaseDistance = 8f;
    public float waitBeforeChase = 1.5f;

    private GameObject player;
    private bool isChasing = false;
    private bool isWaiting = false;

    private bool returningToPatrol = false;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        currentTarget = pointA;
    }

    void Update()
    {
        if (player == null) return;

        if (isWaiting) return; 

        if (returningToPatrol)
        {
            ReturnToPointA();
            return;
        }

        if (!isChasing)
        {
            Patrol();
        }
        else
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);

            if (distance > stopChaseDistance)
            {
                isChasing = false;

                returningToPatrol = true; // Comienza a regresar al punto A
            }

            else
            {
                ChasePlayer();
            }
        }
    }


    void Patrol()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, patrolSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentTarget.position) < 0.2f)
        {
            currentTarget = (currentTarget == pointA) ? pointB : pointA;
        }
    }

    void ChasePlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, chaseSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Comienza la persecución si no está ya persiguiendo o esperando
            if (!isChasing && !isWaiting)
            {
                StartCoroutine(WaitThenChase());
            }

            // Resta vidas al jugador si tiene el componente de salud
            playerMovement health = other.GetComponent<playerMovement>();
            if (health != null)
            {
                health.TakeDamage();
            }
        }
    }

    void ReturnToPointA()
    {
        transform.position = Vector3.MoveTowards(transform.position, pointA.position, patrolSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, pointA.position) < 0.2f)
        {
            returningToPatrol = false;
            currentTarget = pointB; // retoma patrulla hacia B
        }
    }

    IEnumerator WaitThenChase()
    {
        isWaiting = true;
        yield return new WaitForSeconds(waitBeforeChase);
        isWaiting = false;
        isChasing = true;
    }

}
