using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    
    void Start()
    {
        logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && birdIsAlive)
            //(Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.linearVelocity = Vector2.up*flapStrength;
        }

        if (transform.position.y > 17 || transform.position.y < -17)
        {
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
