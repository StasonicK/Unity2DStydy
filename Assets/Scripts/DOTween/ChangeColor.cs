using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        // _spriteRenderer.DOFade(0, 2);
        // _spriteRenderer.DOFade(0, 2).SetLoops(-1, LoopType.Yoyo);
        _spriteRenderer.DOColor(Color.red, 2).SetLoops(-1, LoopType.Yoyo);
        _spriteRenderer.DOFade(0, 0.5f).SetLoops(-1, LoopType.Yoyo);
    }
}