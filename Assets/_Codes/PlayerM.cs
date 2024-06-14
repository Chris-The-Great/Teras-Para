using UnityEngine;

public class PlayerM : MonoBehaviour
{
    public float InputH;
    public float InputV;
    public Animator Move;
    public Rigidbody RB;

    private void Awake()
    {
        RB = GetComponent<Rigidbody>();
        Move = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InputH = Input.GetAxis("Horizontal");
        InputV = Input.GetAxis("Vertical");

        float moveX = InputH * 200f * Time.deltaTime;
        float moveZ = InputV * 500f * Time.deltaTime;
        if (moveZ <= 0f)
        {
            moveX = 0;
        }
        Move.SetFloat("InputH", InputH);
        Move.SetFloat("InputV", InputV);
        RB.velocity = new Vector3(moveX, 0f, moveZ);
    }
}
