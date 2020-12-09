using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public int sceneCount;

    public void NextScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex + 1;
        if (index >= sceneCount)
            index = 0;

        SceneManager.LoadScene(index);
    }

    public void PreviousScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex - 1;
        if (index < 0)
            index = sceneCount - 1;

        SceneManager.LoadScene(index);
    }
}