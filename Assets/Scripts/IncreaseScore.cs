using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseScore : MonoBehaviour
{
    [SerializeField] Text _currentScoreTextView;
    int _currentScore;

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "First Person Player")
        {
            ScorIncrease(10);
            Debug.Log("You got 10 points");
            Destroy(gameObject);
        }
    }

     public void ScorIncrease(int scoreIncrease)
    {
        // increase score
        _currentScore += scoreIncrease;
        // update score display, so we can see the new score
        _currentScoreTextView.text =
            "Score: " + _currentScore.ToString();
    }

}