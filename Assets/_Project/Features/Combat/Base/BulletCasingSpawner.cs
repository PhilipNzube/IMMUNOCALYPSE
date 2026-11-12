using UnityEngine;

public class BulletCasingSpawner : MonoBehaviour, ICasingSpawner
{
    public GameObject casingSpawnPoint;
    public GameObject casingPrefab;
    public ParticleSystem Flash;

    public virtual void play()
    {
        Play();
    }

    public virtual void stop()
    {
        Stop();
    }

    public virtual void Play()
    {
        if (Flash != null) Flash.Play();
        if (casingPrefab != null && casingSpawnPoint != null)
        {
            Instantiate(casingPrefab, casingSpawnPoint.transform.position, casingSpawnPoint.transform.rotation);
        }
    }

    public virtual void Stop()
    {
        if (Flash != null) Flash.Stop();
    }
}
