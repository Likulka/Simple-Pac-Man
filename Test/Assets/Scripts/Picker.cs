using UnityEngine;
using UnityEngine.UI;

public class Picker : MonoBehaviour
{
    public int meal_ = 0;
    [SerializeField] private Text mealText_;
  
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Meal")
        {
            meal_++;
            mealText_.text = meal_.ToString();
            Destroy(col.gameObject);
        }
    }
}
