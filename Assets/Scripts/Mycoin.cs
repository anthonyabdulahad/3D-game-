using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mycoin : MonoBehaviour
{

    private Collider _theCollider;
    // Start is called before the first frame update
    void Start()
    {
        _theCollider = GetComponent<Collider>(); 
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
