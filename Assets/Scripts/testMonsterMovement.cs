using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class testMonsterMovement : MonoBehaviour
{
    public NavMeshAgent agent;   // NavMeshAgent를 할당합니다.
    public Transform player;     // AI가 따라갈 대상을 할당합니다.
    Vector3 dest;         // AI의 목적지를 설정합니다.


    void Update()
    {
        dest = player.position;     // 목적지를 플레이어의 위치로 설정합니다.
        agent.destination = dest;   // AI의 목적지를 설정합니다.
    }
}
