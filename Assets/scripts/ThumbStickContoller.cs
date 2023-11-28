using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class ThumbStickContoller : MonoBehaviour
{
    public float Speed = 2.0f;
    private NavMeshAgent player;
    public Animator animator;
    public float rotationspeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        Debug.Log(input);
        Vector3 input3d = new Vector3(0, 0, input.y);
        player.Move(transform.forward * input.y * Speed * Time.deltaTime);
        transform.Rotate(Vector3.up, input.x * rotationspeed * Time.deltaTime);
        animator.SetFloat("speed", player.velocity.magnitude);
    }
}
