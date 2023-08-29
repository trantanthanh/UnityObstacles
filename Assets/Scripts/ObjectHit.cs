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
        meshRenderer.material.color = Color.red;
    }

    private void OnCollisionExit(Collision other) {
        meshRenderer.material.color = backupColor;
    }
}
