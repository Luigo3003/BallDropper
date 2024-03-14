using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryLogic : MonoBehaviour
{
    public GameObject BuckMovRef;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject ColGO = collision.gameObject;
        if (ColGO.CompareTag("Bucket"))
        {
            ColGO.transform.position = BuckMovRef.gameObject.transform.position;
            PoolScript.PSInstance.TurnOffObjects(ColGO);
        }
    }
}
