using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story")]
public class State : ScriptableObject
{
    [TextArea(14, 10)][SerializeField] private string _story;
    [SerializeField] private State[] nextStates;

    public string Story { get { return _story; } }
    public State[] NextStates { get { return nextStates; } }
}
