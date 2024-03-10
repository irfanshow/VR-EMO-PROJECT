using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSway : MonoBehaviour
{
    [SerializeField]float smooth;
    [SerializeField]float swaySpeed;


    // Update is called once per frame
    void Update()
    {
        // Mouse INput 
        float mouseX = Input.GetAxisRaw("Mouse X") * swaySpeed;
        float mouseY = Input.GetAxisRaw("Mouse Y") * swaySpeed;

        // Menghitung Kalkulasi Rotasi Target

        Quaternion rotationX = Quaternion.AngleAxis(-mouseY,Vector3.right);
        Quaternion rotationY = Quaternion.AngleAxis(mouseX,Vector3.up);

        Quaternion targetRotation = rotationX * rotationY;

        //Rotasi Senjata
        transform.localRotation = Quaternion.Slerp(transform.localRotation , targetRotation ,smooth *Time.deltaTime);
        
    }
}
