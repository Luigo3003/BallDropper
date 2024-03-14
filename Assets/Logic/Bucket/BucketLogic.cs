using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketLogic : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            collision.transform.position = PoolScript.PSInstance.GetRandomSpawnPoint().position;
            GameManager.instance.IncreaseScore();
        }
    }
}
