using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{

    public float radiusToSearch = 300;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(RandomNavmeshLocation(radiusToSearch));
    }

    private Vector3 RandomNavmeshLocation(float radiusToSearch) {
         Vector3 randomDirection = Random.insideUnitSphere * radiusToSearch;
         randomDirection += transform.position;
         NavMeshHit hit;
         Vector3 finalPosition = Vector3.zero;
         if (NavMesh.SamplePosition(randomDirection, out hit, radiusToSearch, 1)) {
             finalPosition = hit.position;            
         }
         return finalPosition;
     }
    void Update()
    {
        if(agent.velocity.magnitude == 0) {
            agent.SetDestination(RandomNavmeshLocation(radiusToSearch));
        }
    }
}
