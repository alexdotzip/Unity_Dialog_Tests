using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AtlasManager))]
[RequireComponent(typeof(AnimationManager))]
[RequireComponent(typeof(PanelManager))]


public class MasterManager : MonoBehaviour
{

    private List<IManager> managerList = new List<IManager>();

    public static AtlasManager atlasManager { get; private set; }
    public static AnimationManager animationManger { get; private set; }

    public static PanelManager panelManager { get; private set; }

    void Awake()
    {
        atlasManager = GetComponent<AtlasManager>();
        animationManger = GetComponent<AnimationManager>();
        panelManager = GetComponent<PanelManager>();


        managerList.Add(atlasManager);
        managerList.Add(animationManger);
        managerList.Add(panelManager);

        StartCoroutine(BootAllManagers());


    }

    private IEnumerator BootAllManagers()
    {
        foreach(IManager manager in managerList)
        {
            manager.BootSequence();
        }

        yield return null;
    }

}
