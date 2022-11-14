using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinkplane3 : MonoBehaviour
{
    public int Speed = 15;
    private Rigidbody rb;
    public float forceMult = 200;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }


    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * Speed;
    }
}
