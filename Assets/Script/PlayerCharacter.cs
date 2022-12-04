using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public int health = 3;
    private int _health;
    public int x;
    public int z;
    // Use this for initialization
    void Start()
    {
        _health = health;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Hurt(int damage)
    {
        Managers.Player.ChangeHealth(-damage);
        //_health -= damage;
        //Debug.Log("Health: " + _health);
        //if (_health == 0)
        //{
        //        x = Random.Range(-1, 1) * 20;
        //        z = Random.Range(-1, 1) * 20;
        //        transform.position = new Vector3(x, 2, z);
        //        _health = health;
        //}
    }
}