using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetEnemy : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;

    // 타겟을 매 프레임 쫒아가자.
    IEnumerator Start()
    {
        moveSpeed = agent.speed;
        while (true)
        {
            agent.destination = target.position;

            yield return null;
        }
        
    }
    public GameObject attackedDffect;
    public GameObject destroyEffect;

    // 총알에 맞으면 0.3 초 멈추기
    public int hp = 3;

    private float moveSpeed;

    internal void OnHit()
    {
        Debug.Log("OnHit;" + name, transform);
        hp--;

        if (hp>0)
        {
            StartCoroutine(ChangeSpeed(0.3f));
            // 총알 맞을때 이펙트 보여주기
            Instantiate(attackedDffect, transform.position, transform.rotation);
        }
        else
        {
            // HP를 추가해서 3대 맞으면 폭발.
            Instantiate(destroyEffect, transform.position, transform.rotation);

            Destroy(gameObject);
        }
        
    }

    private IEnumerator ChangeSpeed(float stopTime)
    {
        agent.speed = 0;
        yield return new WaitForSeconds(stopTime);
        agent.speed = moveSpeed;
    }

    void Update()
    {
        
    }
}
