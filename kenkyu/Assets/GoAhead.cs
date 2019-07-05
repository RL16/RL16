using UnityEngine;

public class GoAhead : MonoBehaviour
{
    public CharacterController eCon;
    public int targetX;
    public int targetY;
    public int targetZ;
    private Vector3 destination;    //目的地
    private float speed;    //スピード値
    private Vector3 velocity;        //速度×方向
    private Vector3 direction;       //移動方向
    // Use this for initialization
    void Start()
    {
        destination = new Vector3(targetX, targetY, targetZ);
        speed = 10.0f;
        velocity = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {
        if (eCon.isGrounded)
        {
            velocity = Vector3.zero;
            direction = (destination - transform.position).normalized;
            transform.LookAt(new Vector3(destination.x, transform.position.y, destination.z));
            velocity = direction * speed;
        }
        velocity.y += Physics.gravity.y * Time.deltaTime;
        eCon.Move(velocity * Time.deltaTime);
    }
}