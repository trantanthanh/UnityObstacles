using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    Color backupColor;
    MeshRenderer meshRenderer;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        backupColor = meshRenderer.material.color;
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player")
        {
            meshRenderer.material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }

    private void OnCollisionExit(Collision other) {
        // if (other.gameObject.tag == "Player")
        // {
        //     meshRenderer.material.color = backupColor;
        // }
    }
}
