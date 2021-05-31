using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WolrdSceneManager : MarcsSceneManager
{
    public override void marcTapped(GameObject marc)
    {
        ;
    }

    public override void playerTapped(GameObject player)
    {
        SceneManager.LoadScene(MarcsConstants.SCENE_CAPTURE, LoadSceneMode.Additive);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
