using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{
   public float interval;
   private float timer = 0;
   public GameObject ExplosionModel;


    void Update()
    {
        timer += Time.deltaTime; 
        if (timer > interval)
        {
            Instantiate(ExplosionModel, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
