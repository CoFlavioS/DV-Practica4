using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour
{
    private AudioSource m_AudioSource;
    private ParticleSystem m_ParticleSystem;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_ParticleSystem = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Start();
        Debug.Log(transform.parent.parent.name);
        m_AudioSource.Play();
        m_ParticleSystem.Play();

    }
}
