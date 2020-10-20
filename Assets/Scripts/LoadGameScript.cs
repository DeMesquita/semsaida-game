using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }

    public void LoadGame(){
        SceneManager.LoadScene("FirstLevel");
    }
    public void LoadControls(){
        SceneManager.LoadScene("Controls");
    }
    
    public void LoadMenu(){
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
