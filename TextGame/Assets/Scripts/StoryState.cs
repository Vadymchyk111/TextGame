using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Story")]
public class StoryState : ScriptableObject
{
   [TextArea(14,10)][SerializeField] private string _story;

   public string Story { get { return _story; } }
}
