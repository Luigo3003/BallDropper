using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    public GameObject BuckMovRef;
    public void RestartGame()
    {
        PoolScript.PSInstance.TurnOnObjects();
        BuckMovRef.transform.position = BuckMovRef.GetComponent<BucketMovement>().OriginTransform.position;
    }
}
