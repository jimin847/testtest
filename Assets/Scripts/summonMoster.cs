using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonMoster : MonoBehaviour
{
//     public GameObject monster;
//     public Collider collision;

//     void OnTriggerEnter(Collider other) {
//         if (other.CompareTag("Player"))
//         {
//             monster.SetActive(true);

//             collision.enabled = false;
//         }
//     }

    public Animator monsterAnimator;   // 몬스터 애니메이터 참조
    public MonoBehaviour testMonsterMovement;    // 몬스터 AI 스크립트 참조
    public GameObject monster;         // 몬스터 객체 참조
    public Collider collision;         // 충돌체 참조

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 애니메이터 트리거 발동
            monsterAnimator.SetTrigger("chase");


            testMonsterMovement.enabled = true;
            
            collision.enabled = false;
        }
    }

    
}
