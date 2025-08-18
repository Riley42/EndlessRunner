using UnityEngine;

public class Ghost : MonoBehaviour
{
    /*************
     * VARIABLES *
     *************/
    public float Speed;
    public float Change;
    public float MinY;
    public float MaxY;

    private Vector2 targetPos;

    /*****************************
     * THIS METHOD RUNS ONLY ONE *
     * TIME WHEN THE GAME STARTS *
     ****************************/
    private void Start()
    {
        
    }

    /*****************************
     * THIS METHOD RUNS ON EVERY *
     * FRAME OF THE GAME(FPS)    *
     ****************************/
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < MaxY)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Change);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > MinY)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Change);
        }
    }
}
