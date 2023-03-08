using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RedPillCounter : MonoBehaviour
{
    int pillCount = 0;
    public TMP_Text redpillCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void  OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red Pill"))
            pillCount++;
        redpillCount.text = pillCount.ToString();
    }
}
