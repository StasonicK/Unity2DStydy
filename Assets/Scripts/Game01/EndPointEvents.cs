using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndPointEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent _reached = new UnityEvent();

    public event UnityAction Reached
    {
        add => _reached.AddListener(value);
        remove => _reached.RemoveListener(value);
    }

    public bool isReached { get; private set; }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (isReached)
        {
            return;
        }
        
        if (col.TryGetComponent<Player>(out Player player))
        {
            isReached = true;
            _reached.Invoke();
        }
    }
}