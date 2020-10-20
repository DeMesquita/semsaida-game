using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class SecurityRobotColisionScript : MonoBehaviour
{
    public Animator enemyAnimator;
    public Slider playerLife;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            enemyAnimator.SetTrigger("Shoot");
            if (playerLife.value > 0)
            {
                playerLife.value -= 5;

            } else {

                SceneManager.LoadScene("GameOver");
            }

        }

    }
}
