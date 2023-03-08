using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BluePillCounter : MonoBehaviour
{
    int BluepillCount = 0;
    public TMP_Text bluepillCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blue Pill"))
            BluepillCount++;
        bluepillCount.text = BluepillCount.ToString();
    }
}
