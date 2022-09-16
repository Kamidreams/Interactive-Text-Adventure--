using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void Choice1()
    {
        SceneManager.LoadScene(3);
    }
    public void Choice5()
    {
        SceneManager.LoadScene(4);
    }

    public void Choice6()
    {
        SceneManager.LoadScene(5);
    }

    public void Choice2()
    {
        SceneManager.LoadScene(6);
    }

    public void Choice7()
    {
        SceneManager.LoadScene(7);
    }

    public void Choice15()
    {
        SceneManager.LoadScene(8);
    }

    public void Choice8()
    {
        SceneManager.LoadScene(9);
    }

    public void Choice9()
    {
        SceneManager.LoadScene(10);
    }

    public void Choice3()
    {
        SceneManager.LoadScene(11);
    }

    public void Choice10()
    {
        SceneManager.LoadScene(12);
    }

public void Choice11()
    {
        SceneManager.LoadScene(13);
    }

public void Choice12()
    {
        SceneManager.LoadScene(14);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
