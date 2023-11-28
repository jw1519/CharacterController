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

    [SerializeField]
    Vector2 inputvalue;

    

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = inputvalue.x;
        float vertical = inputvalue.y;

        Vector3 direction = new Vector3(0, 0, vertical).normalized;

        //rotate character
        if (horizontal != 0)
        {
            transform.Rotate(Vector3.up, horizontal * rotationspeed * Time.deltaTime);
            player.ResetPath();
        }

        //move character
        if (direction.magnitude >= 0.1f)
        {
            if (vertical >= 0)
            {
                player.Move(transform.forward * vertical * Speed * Time.deltaTime);
                player.ResetPath();

            }
            else
            {
                player.Move(-transform.forward * -vertical * Speed * Time.deltaTime);
                player.ResetPath();
            }
            if (animator != null)
            {
                animator.SetFloat("speed", Mathf.Abs(vertical));
                animator.SetFloat("direction", horizontal);
            }

        }
       
    }

    void OnMove(InputValue value)
    {

        inputvalue = value.Get<Vector2>();
        Debug.Log(inputvalue);
        //Vector3 input3d = new Vector3(0, 0, input.y);
        //player.Move(transform.forward * input.y * Speed * Time.deltaTime);
        //transform.Rotate(Vector3.up, input.x * rotationspeed * Time.deltaTime);
        //animator.SetFloat("speed", player.velocity.magnitude);
    }
}
