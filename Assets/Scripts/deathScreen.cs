using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathScreen : MonoBehaviour
{
    public String sceneName;
    public float waitTime;

    void Start()
    {
        StartCoroutine(WaitForDeath());
    }
    IEnumerator WaitForDeath()
    {
        yield return new WaitForSeconds(waitTime);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
