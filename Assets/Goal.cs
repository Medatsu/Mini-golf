using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
   public UnityEvent OnBallGoalEnter = new UnityEvent();
   private void OntrigggerEnter(Collider other)
   {
      if(other.CompareTag("Ball"))
      {
         OnBallGoalEnter.Invoke();
      }
   }
}
