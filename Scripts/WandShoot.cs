using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandShoot : MonoBehaviour
{
    public Transform spellSpawnPoint;
    public GameObject spellPrefab;
    public float spellSpeed;

    private bool coolDown = false;

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !coolDown)
        {
            var spell = Instantiate(spellPrefab, spellSpawnPoint.position, spellSpawnPoint.rotation);

            spell.GetComponent<Rigidbody2D>().velocity = spellSpawnPoint.up * spellSpeed;

            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        coolDown = true;
        yield return new WaitForSeconds(0.3f);
        coolDown = false;
    }
}
