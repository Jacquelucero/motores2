using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerAudioController : MonoBehaviour
{

    private int previousRoom = 0;

    bool beingChased = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SafeRoom"))
        {
            
            AudioManager.Instance.StopMusic(previousRoom);
            AudioManager.Instance.PlayMusic(1);
            previousRoom = 1;

        }
        if (collision.gameObject.CompareTag("EnemyRoom"))
        {
           
            AudioManager.Instance.StopMusic(previousRoom);
            AudioManager.Instance.PlayMusic(2);
            previousRoom = 2;

        }
        if (collision.gameObject.CompareTag("PuzzleRoom"))
        {

            AudioManager.Instance.StopMusic(previousRoom);
            AudioManager.Instance.PlayMusic(3);
            previousRoom = 3;

        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            if (beingChased == false)
            {


                AudioManager.Instance.StopMusic(previousRoom);
                AudioManager.Instance.ChaseMusicLoop();
                beingChased = true;
            }
        }

    }

    
}
