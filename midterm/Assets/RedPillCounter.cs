using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RedPillCounter : MonoBehaviour
{
    int pillCount = 0;
    public TMP_Text redpillCount;
    private Vector3 scaleup;
    void Start()
    {
        scaleup = new Vector3(0.05f, 0.05f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red Pill"))
            pillCount++;
            redpillCount.text = pillCount.ToString();
            gameObject.transform.localScale += scaleup;
    }
}
