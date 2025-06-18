using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public static AudioManager Instance => instance;

    public AudioSource[] musicLoops;

    public AudioClip[] leverSFX;

    public AudioSource leverSFXSource;

    int previousMusic;



    [SerializeField] private AudioSource spotedSFX;

    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else { Destroy(this); }

        
        
    }

  
    public void PlayMusic(int value)
    {
        
            musicLoops[value].Play();
        musicLoops[value].volume = 10;






    }

    public void StopMusic(int value)
    {

        musicLoops[value].Pause();

        
        
        
    }

  
     
  public void ChaseMusicLoop()
    {
        spotedSFX.Play();
        musicLoops[4].PlayDelayed(0.74f);

        //StartCoroutine(WaitFor());
        
    }
    //IEnumerator WaitFor()
    //{
       
    //    yield return new WaitForSeconds(0.74f);

        
        
           
    //        musicLoops[4].volume = 10;
    //    if (previousMusic != 4)
    //    {
    //        musicLoops[4].Stop();
    //    }
        
        
    //}
   public void PlayLeverSFX(int state)
    {
        leverSFXSource.PlayOneShot(leverSFX[state]);
    }
   
}
