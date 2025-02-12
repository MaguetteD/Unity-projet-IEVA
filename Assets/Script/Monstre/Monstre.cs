using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class Monstre : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Joueur;
    Vector3 position;
    private NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = this.GetComponent<NavMeshAgent>();	
    }

    // Update is called once per frame
    void Update()
    {
        position = Joueur.transform.position;
        navMeshAgent.SetDestination(position);
    }
}
