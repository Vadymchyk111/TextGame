using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Game : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private State _storyState;

    private State _state;

    void Start()
    {
       _state = _storyState;
        _text.text = _state.Story;
    }
    private void Update()
    {
        ChooseNextStory();
    }

    private void ChooseNextStory()
    {
        const int COUNT_OF_STORIES=2;
        if(_state.NextStates!=null&&_state.NextStates.Length==COUNT_OF_STORIES)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
                _state = _state.NextStates[0];
            if (Input.GetKeyDown(KeyCode.Alpha2))
                _state = _state.NextStates[1];
        }
        _text.text = _state.Story;
    }
}
