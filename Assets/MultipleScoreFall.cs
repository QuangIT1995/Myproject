using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleScoreFall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            ScoreManager.instance.MultipleScore(2);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Ground")) 
        {
            Destroy(gameObject);
        }
    }
}
