using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerKiller : MonoBehaviour
{
    public GameManager gm = GameManager.instance;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == gm.killerTag)
        {
            gm.KillPlayer();
        }
    }
}
