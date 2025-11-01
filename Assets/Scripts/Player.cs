using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public bool lastIara;
    public bool lastCurupira;

    public int moveSpeed;
    public int jumpForce;
    private Rigidbody rb;
    private bool isGrounded;
    public Transform cam;

    public GameObject pauseMenu;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
        Jump();
        Interaction();
        PauseGame();
    }
    private void Move()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0f;
        camRight.y = 0f;

        camForward.Normalize();
        camRight.Normalize();

        Vector3 forwardRelative = moveVertical * camForward;
        Vector3 rightRelative = moveHorizontal * camRight;

        Vector3 moveDir = (forwardRelative + rightRelative).normalized * moveSpeed;

        // Usar Rigidbody para movimentação física
        Vector3 velocity = new Vector3(moveDir.x, rb.linearVelocity.y, moveDir.z);
        rb.linearVelocity = velocity;

        rb.AddForce(Physics.gravity, ForceMode.Acceleration);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed *= 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed /= 2;
        }
    }
    private void Jump()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.tag == "Letra")
            {
                collision.transform.position = collision.gameObject.GetComponent<Letra>().CollectedLocation.transform.position;
                collision.transform.localScale = new Vector3(10f, 10f, 10f);
                collision.transform.GetChild(0).gameObject.SetActive(false);
                Debug.Log("Pegou o objeto.");
            }
        }
        if (collision.gameObject.CompareTag("IaraTrigger"))
        {
            lastCurupira = false;
            lastIara = true;
        }
        if (collision.gameObject.CompareTag("CurupiraTrigger"))
        {
            lastIara = false;
            lastCurupira = true;
        }
    }

    public void Interaction()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, 15f))
            {
                if (hit.collider.CompareTag("ItemIara"))
                {
                    hit.collider.GetComponent<IaraItem>().GrabItem();
                }
                if (hit.collider.CompareTag("ItemCurupira"))
                {
                    hit.collider.GetComponent<CurupiraItem>().GrabItem();
                }
            }
        }
    }

    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            if (pauseMenu.activeSelf)
            {
                pauseMenu.SetActive(false);
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
            }
        }
    }
}
