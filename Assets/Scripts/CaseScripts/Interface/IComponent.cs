using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IComponent
{
    GameObject gameObject { get; }
    Transform transform { get; }
    Component component { get; }
    bool isDestroyed { get; }
}
