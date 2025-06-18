using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToLevel1 : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneController.Instance.ToLevel2();
        }
    }
}
