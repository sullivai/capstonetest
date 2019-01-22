using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meow : MonoBehaviour
{

     public SpriteRenderer sayMeow;
     public int delay = 100;
     int counter;
     bool toggle = false;

     // Start is called before the first frame update
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          Flash(sayMeow);
     }

     void Flash(SpriteRenderer sr) {
          if (counter >= delay)
          {
               counter = 0;
               toggle = !toggle;
               if (toggle)
               {
                    sr.enabled = true;
               }
               else {
                    sr.enabled = false;
               }
          }
          else {
               counter++;
          }
     }








}
