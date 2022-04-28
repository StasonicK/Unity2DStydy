using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    [SerializeField] private Image _image;

    private void Start()
    {
        var fadeInJob = StartCoroutine(FadeIn(1));

        // StopCoroutine(fadeInJob);
    }

    public IEnumerator FadeIn(float duration)
    {
        var color = _image.color;
        var waitForOneSeconds = new WaitForSeconds(1f);

        for (int i = 0; i < 255; i++)
        {
            color.a = 1f - (1f / 255f * i);
            _image.color = color;
            // yield return waitForOneSeconds;
            yield return null;
        }
    }
}