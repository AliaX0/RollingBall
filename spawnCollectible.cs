using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCollectible : MonoBehaviour
{
    private GameObject CollectibleBlock;
    private GameObject collectible;
    private float offset = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        CollectibleBlock = GameObject.Find("CollectibleBlock");
    }

    void OnTriggerEnter(Collider other){
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, (float)(transform.position.z + offset));
        Instantiate(CollectibleBlock, newPos,transform.rotation);
        Instantiate(collectible, newPos, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
