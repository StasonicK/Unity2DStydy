using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearColorChanger : MonoBehaviour
{
    [HideInInspector] private SpriteRenderer target;
    [SerializeField] private float _duration;
    [SerializeField] private Color _targetColor;
    private float _runningTime;
    private Color _startColor;

    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<SpriteRenderer>();
        _startColor = target.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;
            Debug.Log(_runningTime);
            float normalizeRunningTime = _runningTime / _duration;
            Color newColor = new Color(_targetColor.r * normalizeRunningTime, _targetColor.g * normalizeRunningTime,
                _targetColor.b * normalizeRunningTime);
            target.color = Color.Lerp(_startColor, newColor, normalizeRunningTime);
            // target.color = newColor;
        }
    }
}