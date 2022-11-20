using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int speed = 1;
    public float health = 6;
    public int level = 1;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Çהמנמגüו :" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
