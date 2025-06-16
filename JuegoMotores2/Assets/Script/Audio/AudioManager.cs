using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public static AudioManager Instance => instance;

    public AudioSource[] musicLoops;

    [SerializeField] private AudioSource chaseMusic;
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
        
            StartCoroutine(FadeOut(value));
        
    }

   IEnumerator FadeOut(int value)
    {
        while (musicLoops[value].volume > 0)
        {
            musicLoops[value].volume -= 1f * Time.deltaTime;
            yield return null;
        }
        musicLoops[value].Pause();

    }
     
  public void ChaseMusicLoop()
    {
        StartCoroutine(WaitFor());
        
    }
 IEnumerator WaitFor()
    {
        spotedSFX.Play();
        yield return new WaitForSeconds(0.74f);
        chaseMusic.Play();
    }
}
