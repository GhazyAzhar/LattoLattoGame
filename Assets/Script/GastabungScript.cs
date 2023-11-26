
using UnityEngine;

public class GastabungScript : MonoBehaviour
{
    public Clickcount otherer;
    public BoxCollider2D Collider1;
    public CapsuleCollider2D Collider2;
    public CircleCollider2D Collider3;
    public SkinSoundManager Other;

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider == Collider1)
        {
            Debug.Log("1");
        }
        if (other.collider == Collider2)
        {
            otherer.AddScore();
            Debug.Log(2);
            SkinSoundManager.sondman.PlayBasketSound();
        }
        if (other.collider == Collider3)
        {
            Debug.Log(3);
            SoundManager.sondman.PlayPopSound();
        }
    }
}
