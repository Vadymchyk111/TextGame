using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private StoryState _storyState;

    private StoryState _state;

    void Start()
    {
       _state = _storyState;
        _text.text = _state.Story;
    }
}
