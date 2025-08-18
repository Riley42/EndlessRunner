using UnityEngine;

public class Obstacle : MonoBehaviour
{
    /*************
     * VARIABLES *
     *************/
    public float Speed;
    public GameObject ExplosionFX;

    /*****************************
     * THIS METHOD RUNS ON EVERY *
     * FRAME OF THE GAME(FPS)    *
     ****************************/
    private void Update()
    {
        transform.Translate(Speed * Time.deltaTime * Vector2.left);
    }

    /************************************
     * THIS METHOD RUNS WHENEVER AN     *
     * OBJECT COLLIDES WITH THIS OBJECT *
     ************************************/
    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(ExplosionFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
