using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{

    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        wall = this.gameObject;
    }

    void OnCollisionEnter(Collision coll){
        GameObject collidedWith=coll.gameObject;
        if(collidedWith.CompareTag("Projectile")){
            Destroy(wall);
        }
            
    }
}
