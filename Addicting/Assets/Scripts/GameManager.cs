using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera cam;
    public GameObject player;
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
    }
}
