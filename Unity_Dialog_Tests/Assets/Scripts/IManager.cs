using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ManagerState
{
    offline,
    initializing,
    completed
}

public interface IManager 
{
    

    ManagerState currentState { get; }

    void BootSequence();

}
