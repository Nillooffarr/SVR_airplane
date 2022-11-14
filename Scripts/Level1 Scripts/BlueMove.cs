using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMove : MonoBehaviour
{
    public int Speed = 15;
    private Rigidbody rb;
    public float forceMult = 200;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
   

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * Speed;
    }
}
