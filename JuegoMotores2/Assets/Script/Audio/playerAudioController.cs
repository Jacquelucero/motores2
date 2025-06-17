using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerAudioController : MonoBehaviour
{

    private int previousMusic = 0;

    bool beingChased = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SafeRoom") && previousMusic != 1)
        {
           
            StopChaseMusic();
            AudioManager.Instance.StopMusic(previousMusic);
            AudioManager.Instance.PlayMusic(1);
            
            previousMusic = 1;

        }
        if (collision.gameObject.CompareTag("EnemyRoom") && previousMusic != 2)
        {
            StopChaseMusic();

            AudioManager.Instance.StopMusic(previousMusic);
            AudioManager.Instance.PlayMusic(2);
            
            previousMusic = 2;

        }
        if (collision.gameObject.CompareTag("PuzzleRoom") && previousMusic != 3)
        {
            StopChaseMusic();
            AudioManager.Instance.StopMusic(previousMusic);
            AudioManager.Instance.PlayMusic(3);
            
            previousMusic = 3;

        }
        if (collision.gameObject.CompareTag("Enemy") && previousMusic != 4)
        {
            
            


                AudioManager.Instance.StopMusic(previousMusic);
            previousMusic = 4;
            AudioManager.Instance.ChaseMusicLoop();
            



        }

    }

   void StopChaseMusic()
    {
        AudioManager.Instance.musicLoops[4].Stop();
    }
}
