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

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        currentTarget = pointB;
    }

    void Update()
    {
        if (player == null) return;

        if (!isChasing && !isWaiting)
        {
            Patrol();
        }

        if (isChasing)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);

            if (distance > stopChaseDistance)
            {
                isChasing = false;
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
        if (other.CompareTag("Player") && !isChasing && !isWaiting)
        {
            StartCoroutine(WaitThenChase());
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
