using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   // [Header("PlayerComponents")]

    //SerializedField Private Property
    [Header("Property")] [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private string Name;
    [SerializeField]private Rigidbody2D rb;
    private Vector2 Movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputMovement();
    }
    private void FixedUpdate()
    {
        movement();
    }

    private void inputMovement()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        if (Movement.x != 0)
            Movement.y = 0;
    }
    void movement()
    {
        if (rb != null)
        {
            rb.MovePosition(rb.position + Movement * moveSpeed * Time.fixedDeltaTime);
        }
        else
        {
            Debug.LogError("Komponen Rigidbody Belum DiTambahkan Ke Dalam Script");
        }
    }
}
