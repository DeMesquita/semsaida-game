using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnteringCodeScript : MonoBehaviour
{
    public Animator michelleAnimator;

    void OnCollisionEnter(Collision coli) {
        if(coli.gameObject.tag == "Screen"){
           michelleAnimator.SetTrigger("Code");
           SceneManager.LoadScene("Victory");
       }
    }
}
