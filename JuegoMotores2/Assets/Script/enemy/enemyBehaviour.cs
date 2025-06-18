using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            
            playerMove2 health = collision.gameObject.GetComponent<playerMove2>();
            if (health != null)
            {
                Debug.Log("daño");
                health.TakeDamage();
            }
        }
    }
}
