using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootspawner : MonoBehaviour
{

    public GameObject _lootobject;
    public GameObject _theLoot;

    private bool _islooted;
    // Start is called before the first frame update
    void Start()
    {
        _islooted = false;
    }

    public void OnTriggerStay(Collider other)
    {
        if (!_islooted && other.tag == "player" && Input.GetKeyDown(KeyCode.F))
        {
            for (int i=0; i < 10; i++)
            {
                GameObject newCoin = Instantiate(_theLoot, transform.position, transform.rotation);
                Rigidbody rb = newCoin.GetComponent<Rigidbody>();
                rb.velocity = newCoin.transform.up * 3;
            }
        }
    }
}
