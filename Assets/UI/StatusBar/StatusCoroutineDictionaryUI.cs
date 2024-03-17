using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusCoroutineDictionaryUI
{
    private Dictionary<StatusUI, Coroutine> _dictionary = new Dictionary<StatusUI, Coroutine>();

    public void Add(StatusUI status, Coroutine coroutine)
    {
        _dictionary.Add(status, coroutine);
    }

    public Coroutine Remove(StatusUI status)
    {
        var coroutine = FindCoroutine(status);
        _dictionary.Remove(status);
        return coroutine;
    }

    private Coroutine FindCoroutine(StatusUI key)
    {
        foreach(var pair in _dictionary)
        {
            if(pair.Key == key)
                return pair.Value;
        }
        return null;
    }
}
