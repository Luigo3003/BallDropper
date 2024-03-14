using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestBucket : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PoolScript.PSInstance.RequestObject();
    }
}
