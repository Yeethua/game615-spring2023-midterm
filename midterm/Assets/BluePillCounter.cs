using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BluePillCounter : MonoBehaviour
{
    int pillCount = 0;
    public TMP_Text bluepillCount;
    private Vector3 BlueScaleUp;
    void Start()
    {
        BlueScaleUp = new Vector3(0.05f, 0.05f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blue Pill"))
            pillCount++;
            bluepillCount.text = pillCount.ToString();
            gameObject.transform.localScale += BlueScaleUp;
    }
}
