using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    /*************
     * VARIABLES *
     *************/
    public int Score;
    public TextMeshProUGUI ScoreText;

    /************************************
    * THIS METHOD RUNS WHENEVER AN     *
    * OBJECT COLLIDES WITH THIS OBJECT *
    ************************************/
    private void OnTriggerEnter2D(Collider2D other)
    {
        Score++;
        ScoreText.text = "Score: " + Score;
    }
}
