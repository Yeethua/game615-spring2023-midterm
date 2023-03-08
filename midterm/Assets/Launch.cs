using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public GameObject RedPill;
    public GameObject BluePill;
    public Renderer SphereRend;
    




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if  (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0;  i < 100;  i++) 
            {
                GameObject pill = Instantiate(RedPill, gameObject.transform.position, Quaternion.identity);
                float rotXAmount = Random.Range(-89, -10);
                float rotYAmount = Random.Range(0, 360);
                pill.transform.Rotate(rotXAmount, rotYAmount, 0);
                Rigidbody rb = pill.GetComponent<Rigidbody>();
                rb.AddForce(pill.transform.forward * 1000);
                



            }
        }
    }
}
