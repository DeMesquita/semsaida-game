using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichelleMovements : MonoBehaviour
{
    public Rigidbody michelleRigidbody;
    Vector3 movement;
    public float moveSpeed = 5.0f;
    public Animator michelleAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        float yAxis = Input.GetAxisRaw("Vertical");

        //movement = new Vector3(xAxis, 0, yAxis) * moveSpeed * Time.deltaTime;
       // michelleRigidbody.MovePosition(transform.position + movement);

        //animation
        if (xAxis != 0 || yAxis != 0)
        {
            michelleAnimator.SetBool("Run", true);
        }else{
            michelleAnimator.SetBool("Run", false);
        }

        //rotation
        if (xAxis == 1) //right
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * moveSpeed);
        }

        if (xAxis == -1) //left
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -90, 0), Time.deltaTime * moveSpeed);
        }

        if (yAxis == 1) //forward
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * moveSpeed);
        }

        if (yAxis == -1) //backward
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -180, 0), Time.deltaTime * moveSpeed);
        }

        

    }
}
