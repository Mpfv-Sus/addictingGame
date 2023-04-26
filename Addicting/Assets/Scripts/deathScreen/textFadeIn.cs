using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class textFadeIn : MonoBehaviour
{
    public TextMeshProUGUI text;
    private void Start()
    {
        StartCoroutine(FadeInEfect());
    }


    public IEnumerator FadeInEfect()
    {
        float timeToFade = 1;
        float timeElapsed = 0;
        float x = timeElapsed / timeToFade;
        x = x* x *(3.0f - 2.0f * x);

        while (timeElapsed < timeToFade)
        {
            x = timeElapsed / timeToFade;
            x = x * x * (3.0f - 2.0f * x);
            text.color = new Color(text.color.r, text.color.g, text.color.b, x);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }

}
