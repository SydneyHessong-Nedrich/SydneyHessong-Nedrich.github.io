using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketScript : MonoBehaviour
{
    public int scoreValue;
    public DropperScript dropper;
    private void OnTriggerEnter(Collider other)
    {
        //give dropperScript the points to add to score
        dropper.AddScore(scoreValue);

        Destroy(other.gameObject);
    }
}