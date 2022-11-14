using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pink_plane : MonoBehaviour
{
    public int Speed = 20;
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
