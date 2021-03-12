using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridFly : MonoBehaviour
{
    [SerializeField] float velocity = 1f;
    Rigidbody2D rb;

    private bool isAleadyTouched = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0) && isAleadyTouched == false)
        {
            isAleadyTouched = true;
            rb.isKinematic = false;
            FindObjectOfType<PipeSpawner>().StartSpawning();
            rb.velocity = Vector2.up  * velocity;
        }
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
}
