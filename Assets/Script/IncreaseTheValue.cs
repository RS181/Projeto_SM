using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseTheValue : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text txtDisplayNumber;
    int counter = 0;
    void Start()
    {
        DisplayTheNumber();
    }

    public void IncreaseAndDisplay()
    {
        IncreaseTheValueBy1();
        DisplayTheNumber();
    }
    void IncreaseTheValueBy1()
    {
        counter++;
    }

    void DisplayTheNumber()
    {
        txtDisplayNumber.text = counter.ToString();
    }
}
