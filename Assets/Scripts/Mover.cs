using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDelta = new Vector3(Input.GetAxis("Horizontal"), 0 , Input.GetAxis("Vertical")) * moveSpeed * Time.deltaTime;
        transform.Translate(moveDelta);
    }
}
