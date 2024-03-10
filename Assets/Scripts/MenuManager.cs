using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    public Transform head;
    [SerializeField]float spawnDistance;
    public GameObject menu;
    public InputActionProperty showButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            // Mengakrifkan/menonaktifkan menu
            menu.SetActive(!menu.activeSelf);
            // Set lokasi dimana menu akan muncul bila menekan tombol menu pada controller kiri
            menu.transform.position = head.transform.position + new Vector3(head.forward.x,0,head.forward.z).normalized * spawnDistance;
        }

        //Menu Selalu melihat ke arah player
        menu.transform.LookAt(head.transform.position);
        //Agar Menu tidak berbalik/inverted
        menu.transform.forward *= -1;
    }
}
