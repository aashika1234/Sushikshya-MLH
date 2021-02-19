using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationbehav : MonoBehaviour
{
    Vector3 movement;
    public int x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(movement * Time.deltaTime);
    }
}
