using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KalahLatto : MonoBehaviour
{
    public GameController othererer;
    public BoxCollider2D Collider1;
    public CircleCollider2D Collider2;
    public CircleCollider2D Collider3;

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider == Collider1)
        {
            Debug.Log("1");
        }
        if (other.collider == Collider2)
        {
            othererer.GameOver();
            Debug.Log(222222222);
        }
        if (other.collider == Collider3)
        {
            othererer.GameOver();
            Debug.Log(22223);
        }
    }
}
