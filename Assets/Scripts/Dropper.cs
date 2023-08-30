using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeWaitDrop = 3f;
    MeshRenderer meshRenderer;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeWaitDrop)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
