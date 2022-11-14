using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redplane : MonoBehaviour
{
    public int Speed = 20;
    private Rigidbody rb;
    void Start()
    {

    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
   
    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * Speed;
       
    }
}
