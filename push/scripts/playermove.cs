
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float moveSpeed;
    public float jumpforce;
    public GameOver GameOver;
    public Rigidbody2D rb;
    public bool isJumping;
    static int score = 0;
    static int die = 5;
    public bool isGrounded;
	private Vector3 velocity = Vector3.zero;

    public Transform groundCheckRight; 
    public Transform groundCheckLeft;
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position);
        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        if (Input.GetButtonDown("Jump") && isGrounded)
            isJumping = true;

		MovePlayer(horizontalMovement);
    }

	void MovePlayer(float _horizontalMovement)
	{
		Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
		rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, -01f);
        score++;
        if (isJumping == true)
        {
            ScoreManager.instance.Display(score);
            ScoreManager.instance.health();
            die--;
            rb.AddForce(new Vector2(0f, jumpforce));
            isJumping = false;
        }
        if (die == 0){
            GameOver.setup(score);
            score = 0;
            die = 5;
        }
	}
}
