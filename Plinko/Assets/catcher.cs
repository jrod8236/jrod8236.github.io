using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catcher : MonoBehaviour
{
    public int scoreValue;
    public top dropper;


    private void OnTriggerEnter(Collider other)
    {
        //give dropperScript the points to add to score
        dropper.AddScore(scoreValue); 

        Destroy(other.gameObject);

    }
}
