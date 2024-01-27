using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class RotateSaw : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
  
    private void CustomUpdate()
    {
        transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
    }
}
