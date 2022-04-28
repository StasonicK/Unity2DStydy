using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private UnityEvent _hit;
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.collider.gameObject.name);
        if (col.collider.gameObject.TryGetComponent(out Block block))
        {
            _hit?.Invoke();
        }
    }
}
