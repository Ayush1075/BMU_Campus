using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BMU.Tour
{
    // ------------------------------------------------------------------ keeps the canvas in front of the player
    public class BMUGazeFollow : MonoBehaviour
    {
        public Transform head;
        public float distance = 1.8f, heightOffset = 0.13f, yawThreshold = 40f, smooth = 3.0f;
        float currentYaw, targetYaw;
        bool init;

        public void Recenter(bool instant = false)
        {
            if (head == null) return;
            targetYaw = head.eulerAngles.y;
            if (instant) { currentYaw = targetYaw; Apply(); }
        }

        void LateUpdate()
        {
            if (head == null)
            {
                if (Camera.main != null) head = Camera.main.transform;
                return;
            }
            if (!init) { init = true; Recenter(true); }
            float yaw = head.eulerAngles.y;
            if (Mathf.Abs(Mathf.DeltaAngle(currentYaw, yaw)) > yawThreshold) targetYaw = yaw;
            currentYaw = Mathf.LerpAngle(currentYaw, targetYaw, 1f - Mathf.Exp(-smooth * Time.deltaTime));
            Apply();
        }

        void Apply()
        {
            var rot = Quaternion.Euler(0, currentYaw, 0);
            var p = head.position; p.y += heightOffset;
            transform.SetPositionAndRotation(p + rot * Vector3.forward * distance, rot);
        }
    }
}
