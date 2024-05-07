using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class PlayerController : MonoBehaviour
{

    public Camera cam;

    public NavMeshAgent agent;

    public TrailRenderer trail;

    public List<Transform> CustomDestinations;

    private int currentDestination;

    private float normalSpeed;
    private int timer;

    void Awake()
    {
        currentDestination = 0;
        agent.SetDestination(CustomDestinations[currentDestination].position);
        normalSpeed = agent.speed;
        timer = 500;
        trail.emitting = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (agent.speed > normalSpeed)
        {
            trail.emitting = true;
            timer--;
            if (timer == 0)
            {
                agent.speed = normalSpeed;
                timer = 500;
                trail.emitting = false;
            }
                
        }

        if (agent.remainingDistance < 2 )
        {
            if (currentDestination == CustomDestinations.Count - 1)
                currentDestination = 0;
            else
                currentDestination++;

            agent.SetDestination(CustomDestinations[currentDestination].position);
        }
            
    }
}
