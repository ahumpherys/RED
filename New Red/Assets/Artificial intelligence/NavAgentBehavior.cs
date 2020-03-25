using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player;
    //vector3 location
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.destination = player.position;
            //location (for location instead of player)
    }
}
