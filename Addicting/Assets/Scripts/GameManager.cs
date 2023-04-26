using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Camera Stuff")]
        public Camera cam;

    [Header("Player Stuff")]
        public GameObject player;
        public string killerTag;

    [Header("Ground Stuff")]
        public GameObject[] grounds;
        public GameObject currentGround;
    
    
    public static GameManager instance;
    int index = 0;
    
    private void Start()
    {
        instance = this;
        currentGround = grounds[0];
    }


    private void Update()
    {
        //Ground Changing stuff
        if(cam.transform.position.x > currentGround.transform.position.x + 125)
        {
            currentGround.transform.position = currentGround.transform.position + new Vector3(500,0,0);
            if(index == 0)
            {
                currentGround = grounds[1];
                index = 1;
            }
            else if(index == 1)
            {
                currentGround = grounds[0];
                index = 0;
            }
        }
        //New thingy
    }

    public void KillPlayer()
    {
        Destroy(player);
        SceneManager.LoadSceneAsync("DeathScreen");
        SceneManager.UnloadSceneAsync("Game");
    }
}
