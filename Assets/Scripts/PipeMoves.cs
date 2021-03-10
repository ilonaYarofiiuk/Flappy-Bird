using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoves : MonoBehaviour
{

    [SerializeField] float moveSpead = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpead * Time.deltaTime;
    }
}
