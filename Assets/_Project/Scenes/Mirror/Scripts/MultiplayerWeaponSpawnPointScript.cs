using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scenes.Mirror.Scripts{
public class MultiplayerWeaponSpawnPointScript : MonoBehaviour
{

private void OnDrawGizmos(){
Gizmos.color=Color.blue;
Gizmos.DrawSphere(transform.position, 1f);
Gizmos.color=Color.green;
Gizmos.DrawLine(transform.position, transform.position + transform.forward * 2);
}
}
}
