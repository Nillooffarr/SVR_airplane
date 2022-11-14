using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMove: MonoBehaviour
{
    // Start is called before the first frame update
    public int Speed = 15;
    private Rigidbody rb;
    void Start()
    {

    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
  
    
    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime*Speed;
        //rb.velocity = transform.forward * Time.deltaTime;
    }
}
