using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hit = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            ++hit;
        }
    }
}
