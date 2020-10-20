using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack5Script : MonoBehaviour
{
    public Animator michelleAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Mouse0))
       {
           michelleAnimator.SetTrigger("Attack5");
       }
       /* if (Input.GetKey(KeyCode.Mouse1))
       {
           michelleAnimator.SetTrigger("Defense5");
       } */
    }
}
