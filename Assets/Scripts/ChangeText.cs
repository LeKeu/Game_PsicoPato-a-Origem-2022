using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI textElement;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int qntd = GameObject.FindGameObjectsWithTag("Pessoa").Length;
        textElement.text = " Pessoas no mapa: " + qntd;
    }
}
