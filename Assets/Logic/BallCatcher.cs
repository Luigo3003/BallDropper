using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallCatcher : MonoBehaviour
{
    private int BallRemaining = 0;

    [SerializeField] private TextMeshProUGUI _BallRemainingText;
    void Start()
    {
        BallRemaining = PoolScript.PSInstance.StartingNumberofObjects;
        _BallRemainingText.text = BallRemaining.ToString("0");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            collision.gameObject.SetActive(false);
            BallRemaining--;
            _BallRemainingText.text = BallRemaining.ToString("0");
            PoolScript.PSInstance.TurnOffObjects(collision.gameObject);

            if (BallRemaining == 0)
            {
                GameManager.instance.EndGame();
                BallRemaining = PoolScript.PSInstance.StartingNumberofObjects;
                _BallRemainingText.text = BallRemaining.ToString("0");
            }
        }
    }
}
