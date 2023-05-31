using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCollectible : MonoBehaviour
{
    private GameObject collectibleBlock;
    private GameObject collectible;
    private float offset = 10.0f;


    void Start()
    {
        collectibleBlock = GameObject.Find("collectibleBlock");
        collectible = GameObject.Find("collectible");
    }

    void OnTriggerEnter(Collider other){
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, (float)(transform.position.z + offset));
        Instantiate(collectibleBlock, newPos,transform.rotation);
        Instantiate(collectible, newPos, transform.rotation);
        collectible.SetActive(true);
        
    }
}
