using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private PlayerMovement1 m_playerReference;
   
    [SerializeField] private TextMeshProUGUI m_playerLifes;

    private void Start()
    {
        m_playerReference = GameObject.FindWithTag("Player").GetComponent<PlayerMovement1>();
    }



    private void Update()
    {
       
        m_playerLifes.text = m_playerReference.currentLives.ToString();



    }

   
}
