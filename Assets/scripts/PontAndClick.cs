using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.AI;


public class PontAndClick : MonoBehaviour
{
    public NavMeshAgent player;
    public Animator animator;
    [SerializeField]
    private Vector3 target;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                target = hit.point;
                player.SetDestination(target);
            }
            
        }
        if (animator != null)
        {
            animator.SetFloat("speed", player.velocity.magnitude);
        }
    }
}
