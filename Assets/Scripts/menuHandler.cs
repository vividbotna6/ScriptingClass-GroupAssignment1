using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuHandler : MonoBehaviour
{
    public Button startButton;
    public Button endButton;
    public Button exitButton;
    public movement movement;
    public Canvas menu;
    public Camerafollow cam;
    void StartGame()
    {
        movement.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        cam.enabled = true;
        menu.enabled = false;
    }
    void EndGame()
    {
        SceneManager.LoadScene(0);
    }
    private void OnEnable()
    {
        startButton?.onClick.AddListener(StartGame);
        endButton?.onClick.AddListener(EndGame);
        exitButton?.onClick.AddListener(ExitGame);
    }

    private void ExitGame()
    {
      Application.Quit();
    }

    private void OnDisable()
    {
        startButton?.onClick.RemoveAllListeners();
        endButton?.onClick.RemoveAllListeners();
        exitButton?.onClick.RemoveAllListeners();   
    }
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex==0)
        {
            movement.enabled = false;
            cam.enabled = false;

        }
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
