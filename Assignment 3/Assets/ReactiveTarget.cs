﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    // Start is called before the first frame update
   public void ReactToHit() {
       StartCoroutine(Die());
   }

   private IEnumerator Die() {
       this.transform.Rotate(-75, 0, 0);
       yield return new WaitForSeconds(0.3f);
       Destroy(this.gameObject);
   }
}
