using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public float speed = 5f;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;   
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {

            Vector2 direction = (player.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position,player.position,speed*Time.deltaTime );
        }
    }
}
