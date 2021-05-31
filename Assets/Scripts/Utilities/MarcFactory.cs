using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class MarcFactory : Singleton<MarcFactory>

{

    [SerializeField] private Marcs[] availableMarcs;
    [SerializeField] private Player player;
    [SerializeField] private float waitTime = 180.0f;
    [SerializeField] private float startingMarcs = 5;
    [SerializeField] private float minRange = 5.0f;
    [SerializeField] private float maxRange = 50.0f;

    private List<Marcs> liveMarcs = new List<Marcs>();
    private Marcs selectedMarcs;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < startingMarcs; i++)
        {
            InstantiateMarc();
        }

        StartCoroutine(GenerateMarc());

    }

    private void Awake()
    {
        Assert.IsNotNull(availableMarcs);
        Assert.IsNotNull(player);
    }

    public void MarcWasSelected(Marcs marc)
    {
        selectedMarcs = marc;
    }

    private IEnumerator GenerateMarc()
    {
        while (true)
        {
            InstantiateMarc();
            yield return new WaitForSeconds(waitTime);
        }
    }

    private void InstantiateMarc()
    {
        int index = Random.Range(0, availableMarcs.Length);
        float x = player.transform.position.x + GenerateRange();
        float y = player.transform.position.y;
        float z = player.transform.position.z + GenerateRange();

        liveMarcs.Add(Instantiate(availableMarcs[index], new Vector3(x, y, z), Quaternion.identity));
    }

    private float GenerateRange()
    {
        float randomNum = Random.Range(minRange, maxRange);
        bool isPositive = Random.Range(0, 10) < 5;
        return randomNum * (isPositive ? 1 : -1);
    }

}
