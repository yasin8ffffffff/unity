using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public ParticleSystem bulletParticles;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ParticleSystem shot = Instantiate(bulletParticles, transform.position + transform.right * 1f, Quaternion.identity);
            shot.Play();
        }
    }
}
