﻿using GTA;
using GTA.Math;
using GTA.Native;
using System;

namespace CWDM.Extensions
{
    public static class EntityExtensions
    {
        public static double DistanceTo(this Entity p1, Vector3 p2)
        {
            Vector3 v1 = p1.Position;
            Vector3 v2 = p2;
            double distance;
            double x = v2.X - v1.X;
            double y = v2.Y - v1.Y;
            double z = v2.Z - v1.Z;
            distance = Math.Sqrt((x * x) + (y * y) + (z * z));
            return distance;
        }

        public static double DistanceBetween(this Entity p1, Entity p2)
        {
            Vector3 v1 = p1.Position;
            Vector3 v2 = p2.Position;
            double distance;
            double x = v2.X - v1.X;
            double y = v2.Y - v1.Y;
            double z = v2.Z - v1.Z;
            distance = Math.Sqrt((x * x) + (y * y) + (z * z));
            return distance;
        }

        public static bool HasClearLineOfSight(this Entity entity, Entity target, float visionDistance)
        {
            return Function.Call<bool>(Hash.HAS_ENTITY_CLEAR_LOS_TO_ENTITY, entity.Handle, target.Handle) && entity.Position.DistanceTo(target.Position) < visionDistance;
        }
    }
}
