using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirCamera : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject coisaPraSeguir;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = coisaPraSeguir.transform.position + new Vector3(0, 0, -10);
    }
}
