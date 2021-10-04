using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //get left mouse click input
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); // camera's view => ray

            RaycastHit hit; //where the ray is hit on the level

            if (Physics.Raycast(ray, out hit))//shoot ray and gather info
            {
                //move the character
                agent.SetDestination(hit.point);
            }
        }
    }
}
