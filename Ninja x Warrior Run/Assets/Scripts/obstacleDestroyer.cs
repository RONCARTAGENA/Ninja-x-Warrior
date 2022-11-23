using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2d (Collider2D collision)
    {
        if(collision.tag == "Side Border")
        {
            Destroy(this.gameObject);
        }
    }
}
