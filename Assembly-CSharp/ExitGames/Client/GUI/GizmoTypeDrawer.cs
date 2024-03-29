﻿using System;
using UnityEngine;

namespace ExitGames.Client.GUI
{
	// Token: 0x020002E5 RID: 741
	public class GizmoTypeDrawer
	{
		// Token: 0x0600AD32 RID: 44338 RVA: 0x003FC01C File Offset: 0x003FA21C
		public static void Draw(Vector3 center, GizmoType type, Color color, float size)
		{
			Gizmos.color = color;
			switch (type)
			{
			case GizmoType.WireSphere:
				Gizmos.DrawWireSphere(center, size * 0.5f);
				break;
			case GizmoType.Sphere:
				Gizmos.DrawSphere(center, size * 0.5f);
				break;
			case GizmoType.WireCube:
				Gizmos.DrawWireCube(center, Vector3.one * size);
				break;
			case GizmoType.Cube:
				Gizmos.DrawCube(center, Vector3.one * size);
				break;
			}
		}
	}
}
