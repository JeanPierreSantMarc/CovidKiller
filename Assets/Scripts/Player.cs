using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int xp = 0;
    private int requiredXp = 100;
    [SerializeField] private int levetBase = 100;
    [SerializeField] private List<GameObject> marcs = new List<GameObject>();

    private int lvl = 1;

    public int Xp
    {
        get { return xp; }
    }
    public int RequiredXp
    {
        get { return requiredXp; }
    }
    public int LevetBase
    {
        get { return levetBase; }
    }
    public int Lvl
    {
        get { return lvl; }
    }

    public List<GameObject> Marcs
    {
        get { return marcs; }
    }

    private void InitLevelData()
    {
        lvl = (xp / levetBase) + 1;
        requiredXp = levetBase * lvl;
    }

    public void AddXp(int xp)
    {
        this.xp += Mathf.Max(0, xp);
    }

    public void AddMarc(GameObject marc)
    {
        marcs.Add(marc);
    }

    // Start is called before the first frame update
    void Start()
    {
        InitLevelData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
