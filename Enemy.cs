using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;
    int playerDamage = 2;
    
    void Update()
    {
     
       transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
       transform.LookAt(target.position);
    }
void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out var player))
        {
            player.TakeDamage(playerDamage);
        }
    }
}