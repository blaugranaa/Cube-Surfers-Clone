using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public EnvironmentGenerator environmentSpawnManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            environmentSpawnManager.MoveEnvironment();
            StartCoroutine(DisableforoneSec(other.gameObject));
        }
    }

    IEnumerator DisableforoneSec(GameObject obj)
    {
        var col = obj.GetComponent<BoxCollider>();
        col.enabled = false;
        yield return new WaitForSeconds(1f);
        col.enabled = true;

    }
}
