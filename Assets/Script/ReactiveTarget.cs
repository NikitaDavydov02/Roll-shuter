using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        health = 1;
    }
    public int health;
    // Update is called once per frame
    void Update()
    {

    }

    public void ReactToHit()
    {
        WanderingAI behavior = GetComponent<WanderingAI>();
        if (behavior != null)
        {
            health--;
            if (health == 0)
            {
                behavior.SetAlive(false);
                StartCoroutine(Die());
            }
        }

    }

    private IEnumerator Die()
    {
        this.transform.Rotate(-75, 0, 0);
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }
}

