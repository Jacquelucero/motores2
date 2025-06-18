using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private static SceneController instance;
    public static SceneController Instance => instance;


    public Dictionary<string, int> Scenes = new Dictionary<string, int>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;


        }
        else { Destroy(gameObject); }
       

        //-------------


        Scenes.Add("Splash", 0);

        Scenes.Add("Menu", 1);

        Scenes.Add("Loading", 2);

        Scenes.Add("Level1", 3);

        Scenes.Add("GameOver", 4);

        Scenes.Add("Level2", 5);

        Scenes.Add("Victory", 6);


    }

    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "SplashScreen")
        {
            StartCoroutine(ToMenuScreen());
        }

        if (scene.name == "LoadingScreen")
        {
            StartCoroutine(ToLevelScreen());
        }
    }


    public void ToLoad()
    {
        SceneManager.LoadScene(Scenes["Loading"]);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(Scenes["Menu"]);
    }

    public void ToLevel1()
    {
        SceneManager.LoadScene(Scenes["Level1"]);
    }

    public void ToGameOver()
    {
        SceneManager.LoadScene(Scenes["GameOver"]);
    }

    public void ToLevel2()
    {
        SceneManager.LoadScene(Scenes["Level2"]);
    }

    public void ToEndScene()
    {
        SceneManager.LoadScene(Scenes["Victory"]);
    }


    IEnumerator ToMenuScreen()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(Scenes["Menu"]);
    }
    IEnumerator ToLevelScreen()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(Scenes["Level1"]);
    }
}

