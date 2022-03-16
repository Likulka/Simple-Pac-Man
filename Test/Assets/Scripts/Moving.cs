using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    // Start is called before the first frame update
   public void SetPosition()
    {
        transform.position = Input.mousePosition;
    }
}
