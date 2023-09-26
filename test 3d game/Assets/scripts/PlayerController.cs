using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI Countext;
    public GameObject Wintext; 

    private int count; 
    
    private Rigidbody _playerRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
        _count = 0;
        Countext.text = "Count: " + _counts.ToString();
        Wintext.gameObject.SetActive();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput;
        float verticalInput;

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        _playerRigidbody.AddForce(movement);

    }}