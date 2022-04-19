using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);

        Debug.DrawRay(transform.position, transform.up * 10, Color.red);

        if (hit)
        {
            Destroy(hit.collider.gameObject);
        }
    }
}