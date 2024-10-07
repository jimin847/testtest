using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterJumpscare : MonoBehaviour
{
    public Animator monsterAnim;
    public GameObject player;
    public float jumpscareTime;
    public string sceneName;

    void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            player.SetActive(false);
            monsterAnim.SetTrigger("jumpscare");
            StartCoroutine(jumpscare());

        }
    }
    IEnumerator jumpscare()
    {
        yield return new WaitForSeconds(jumpscareTime);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
