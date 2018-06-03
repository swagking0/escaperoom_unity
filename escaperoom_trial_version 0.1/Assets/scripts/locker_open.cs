using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locker_open : MonoBehaviour {

    private Animator _animo;

    private void Start()
    {
        _animo = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "lifesaver")
        {
            _animo.SetBool("expand", true);
        }
    }
}
