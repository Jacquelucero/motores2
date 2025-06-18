using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Key : MonoBehaviour
{
    [SerializeField] private GameObject openDoor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            openDoor.SetActive(true);
            Destroy(gameObject);
        }
    }
}
