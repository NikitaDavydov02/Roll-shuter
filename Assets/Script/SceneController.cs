using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    private GameObject _enemy;
    private int x;
    private int z;
    public int count = 5;
    public float baseSpeed = 3.0f;
    public float speed = 3.0f;
    // Use this for initialization
    void Start()
    {
        Spawn(count);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Awake()
    {
        //Messenger<float>.AddListener(GameEvent.SPEED_CHANGED, OnSpeedChanged);
    }
    void OnDestroy()
    {
        //Messenger<float>.RemoveListener(GameEvent.SPEED_CHANGED, OnSpeedChanged);
    }
    private void OnSpeedChanged(float value)
    {
        speed = baseSpeed * value;
    }
    public void Spawn(int add)
    {
        for (int i = 0; i < add; i++)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            int x = Random.Range(-1, 2) * 20;
            int z = Random.Range(-1, 2) * 20;
            _enemy.transform.position = new Vector3(x, 1, z);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
        }
    }
}
