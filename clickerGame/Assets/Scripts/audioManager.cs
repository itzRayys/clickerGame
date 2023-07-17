using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static audioManager;

public class audioManager : MonoBehaviour
{
    [System.Serializable]
    public class sound
    {
        public string clipName;
        public AudioClip clip;

        [Range(0f, 1f)]
        public float volume = 0.75f;

        [Range(0.1f, 3f)]
        public float pitch = 1f;
        public bool loop = false;

        [HideInInspector]
        public AudioSource source;
    }


    public List<sound> soundEffects;

    public static audioManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (sound s in soundEffects)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string soundName)
    {
        sound s = soundEffects.Find(sound => sound.clipName == soundName);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + soundName + " not found!");
            return;
        }
        s.source.Play();
    }
    public void updateSoundVolumes()
    {
        foreach (sound s in soundEffects)
        {
            s.source.volume = s.volume;
        }
    }
}
