using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class positionCheck : MonoBehaviour
{
    public Transform Player;
    public Vector3 positionEnd;
    public Vector3 playerPosition;
    public float DistancetoPoint;
    private bool FinishedGame = false;
    public Canvas menu;
    // Start is called before the first frame update
    void Start()
    {
        positionEnd = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = Player.position;
        if (FinishedGame) return;

        if (Vector3.Distance(Player.position, positionEnd) < DistancetoPoint)
        {
            int nextIndex = (SceneManager.GetActiveScene().buildIndex + 1);
            if (SceneManager.GetAllScenes().Length - 1 >= nextIndex)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                FinishedGame = true;
            }
            else
            {
                menu.enabled = true;
                Debug.Log("Menu");
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,DistancetoPoint);
    }
}
