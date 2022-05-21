using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaDesplazamiento : MonoBehaviour
{
    public float velocidadM;
    public float velocidadR;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        velocidadM = 5f;
        velocidadR = 200f;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        
        transform.Rotate(0, x*Time.deltaTime * velocidadR, 0);
        transform.Translate(0,0,y* Time.deltaTime * velocidadM);


            
    } 
}
