using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MichelleCollisionScript : MonoBehaviour
{
    public Animator enemyAnimator;
    public Slider playerLife;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Wall"))
        {
            if (playerLife.value > 0)
            {
                playerLife.value --;

            } else {

                SceneManager.LoadScene("GameOver");
            }

        }
        
        /* if (collision.gameObject.tag.Equals("Enemy"))
        {
            Debug.Log("colidiu");           
            enemyAnimator.SetTrigger("Shoot");
            playerLife.value -= 50;

        } */

    }
}