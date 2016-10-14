using UnityEngine;
using System.Collections;

public class personaje : MonoBehaviour {

    public NavMeshAgent nav_mesh_agent;
    public Animator animator;
    
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (nav_mesh_agent.remainingDistance > nav_mesh_agent.radius)
        {
            animator.SetBool("mov", true);
        }
    }
}
