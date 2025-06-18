using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Keys : MonoBehaviour
{
    [SerializeField] private int keyNumber;
    private playerKeyHold playerKeyHold;

    private void Start()
    {
        playerKeyHold = GameObject.FindWithTag("Player").GetComponent<playerKeyHold>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerKeyHold.hasKey[keyNumber] = true;
        }
        Destroy(gameObject);
    }

}
