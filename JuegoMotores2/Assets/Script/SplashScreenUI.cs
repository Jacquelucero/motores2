using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreenUI : MonoBehaviour
{
    private Image SplashLogo;
    
   

    private void Start()
    {
        
        SplashLogo = GetComponent<Image>();
        SplashLogo.CrossFadeAlpha(0, 2f,  false);
    }

    private void Update()
    {
       
    }
}
