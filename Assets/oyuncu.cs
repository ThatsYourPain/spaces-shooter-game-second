using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncu : MonoBehaviour
{
    public GameObject patlama_efekt;
    public GameObject mermi;
    float mermi_hizi = 500.0f;
    
    private void ates();
    {   

        GameObject ikincilmermi = Instantiate(mermi, transform.poisiton, Quaternion.identity);
        ikincilmermi.GetComponent<Rigidbody2D>().AddForce(Vector2.up*mermi_hizi);
        Destroy(ikincilmermi, 2.0f);

    }
        void Update()
{
    float tus = Input.GetAxis("Horizontal");
    
    if (Input.GetKeyDown(KeyCode.Space))
    {
        ates();
    }
}
}
