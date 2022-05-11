using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text1;
    [SerializeField] private TextMeshProUGUI _text2;
    [SerializeField] private TextMeshProUGUI _text3;

    private void Start()
    {
        _text1.DOText("Я заменил этот текст.", 3);
        _text2.DOText("Это дополнение к тексту", 3).SetRelative();
        _text3.DOText("Я взломал этот текст", 3, true, ScrambleMode.All);
        _text3.DOColor(Color.red, 3);
    }
}