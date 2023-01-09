using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            MoveToCursor();
        }
        
    }

    void MoveToCursor(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray,out hit);
        if(hasHit){
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
    }

    void UpdateAnimations(){
        Vector3 Velocity = GetComponent<NavMeshAgent>().velocity;
    }
}
