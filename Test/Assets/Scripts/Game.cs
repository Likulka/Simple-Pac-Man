using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject restartPanel_;
    void Start()
    {
        restartPanel_.SetActive(false);
    }

    void Update()
    {
        if (GameObject.FindWithTag("Meal") == null)
        {
            restartPanel_.SetActive(true);
        }
    }
}
