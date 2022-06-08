using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawnManager : MonoBehaviour
{
    EnvironmentGenerator environmentGenerator;

    private void Start()
    {
        environmentGenerator = GetComponentInParent<EnvironmentGenerator>();
    }

    public void SpawnTriggered()
    {
        environmentGenerator.MoveEnvironment();
    }
}
