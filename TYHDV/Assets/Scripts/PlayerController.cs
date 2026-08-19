using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] CharacterController controller;
    [SerializeField] Vector3 playerVelocity;
    [SerializeField] bool groundedPlayer;
    [SerializeField] float playerSpeed = 4;
    [SerializeField] float gravityValue = -20;
    [SerializeField] float moveHorizontal;
    [SerializeField] float moveVertical;
    [SerializeField] float speed = 4;
    [SerializeField] float rotateSpeed = 4;
    [SerializeField] float jumpHeight = 1.2f;
    [SerializeField] bool isJumping;
    [SerializeField] bool isGrounded;

    private void Start()
    {
        playerSpeed = 4;
        gravityValue = -20;
    }

    void Update()
    {

        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);


        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            isJumping = true;
            playerVelocity.y += 10;
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            this.gameObject.GetComponent<CharacterController>().minMoveDistance = 0.001f;

        }
        else
        {
            this.gameObject.GetComponent<CharacterController>().minMoveDistance = 0.901f;
        }


    }





}


