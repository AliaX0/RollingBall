using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBlock : MonoBehaviour
{
    private GameObject Block;
    private float offset = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        Block = GameObject.Find("Block");
        
    }

    void OnTriggerEnter(Collider other){
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, (float)(transform.position.z + offset));
        Instantiate(Block, newPos, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
