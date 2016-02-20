using UnityEngine;
using System.Collections;

public class NPCMovement : MonoBehaviour {

    public float multiplier;
    public float speed;

    Transform target;
    NavMeshAgent nav;


    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Finish").transform;
        nav = GetComponent<NavMeshAgent>();
        nav.SetDestination(target.position);
    }


    void Update()
    {
        nav.speed = speed * multiplier;
    }
}
