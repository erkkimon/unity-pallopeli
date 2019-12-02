using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelaajaKoodi : MonoBehaviour
{
    public float nopeus;
    Vector3 suunta;
    Rigidbody RB;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        suunta.x = Input.GetAxis("Horizontal");
        suunta.z = Input.GetAxis("Vertical");
        RB.AddForce(suunta * nopeus);
    }
}
