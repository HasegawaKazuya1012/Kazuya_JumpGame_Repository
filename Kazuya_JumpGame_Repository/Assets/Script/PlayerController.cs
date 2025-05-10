using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController3D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private Rigidbody rb;
    private bool isGrounded = false;
    private Vector3 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Vector3 velocity = rb.velocity;
        velocity.x = moveInput * moveSpeed;
        rb.velocity = new Vector3(velocity.x, rb.velocity.y, 0);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }

        // カメラ下（画面外）に落ちたら戻す
        Vector3 viewportPos = Camera.main.WorldToViewportPoint(transform.position);
        if (viewportPos.y < 0)
        {
            transform.position = startPosition;
            rb.velocity = Vector3.zero;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Goal"))
        {
            Debug.Log("クリア！");
            SceneManager.LoadScene("ClearScene");
        }
    }
}
