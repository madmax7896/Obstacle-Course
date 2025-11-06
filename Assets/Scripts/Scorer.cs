using UnityEngine;

public class Scorer : MonoBehaviour
{
    int count = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            count++;
            Debug.Log("You have bumped into the wall " + count + " times");
        }
    }
}
