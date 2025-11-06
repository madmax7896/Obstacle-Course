using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome To The Game");
        Debug.Log("Move Your Player With Arrow keys or WASD");
    }

    void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(x, 0f, z);
    }
}
