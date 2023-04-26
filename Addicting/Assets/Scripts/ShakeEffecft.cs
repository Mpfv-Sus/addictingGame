using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeEffecft : MonoBehaviour
{
    Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
        StartCoroutine(Shake());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Shake()
    {
        while (true)
        {
            transform.position = startPos + new Vector3(Random.Range(0f, 1.5f), Random.Range(0f, 1.5f), Random.Range(0f, 1.5f));
            
            yield return new WaitForSeconds((float)1/15);
        }
    }
}
