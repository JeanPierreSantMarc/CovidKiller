using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marcs : MonoBehaviour
{
    [SerializeField] private float spawnRate = 0.10f;
    [SerializeField] private float catchRate = 0.10f;
    [SerializeField] private int attack = 0;
    [SerializeField] private int defence = 0;
    [SerializeField] private int hp = 10;

    public float SpawnRate
    {
        get { return spawnRate; }
    }

    public float CatchRate
    {
        get { return catchRate; }
    }

    public float Attack
    {
        get { return attack; }
    }

    public float Defence
    {
        get { return defence; }
    }

    public float Hp
    {
        get { return hp; }
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    private void OnMouseDown()
    {
        MarcsSceneManager[] managers = FindObjectsOfType<MarcsSceneManager>();
        foreach (MarcsSceneManager marcsSceneManager in managers)
        {
            marcsSceneManager.marcTapped(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
