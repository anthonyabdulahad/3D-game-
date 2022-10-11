using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vent : MonoBehaviour
{
    public Animator _VentAni;
    // Start is called before the first frame update
    void Start()
    {
        _VentAni = GetComponent<Animator>();

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _VentAni.SetBool("VentOpen", true);
        }
    }
}
