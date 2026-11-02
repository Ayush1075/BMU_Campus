using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace BMU.Tour
{
    /// <summary>Teleport.GoTo(spawn): fade to dark, move the XR rig to the spawn, recentre the tour canvas, fade back in. Wired from Button OnClick.</summary>
    public class Teleport : MonoBehaviour
    {
        public Transform rig;                 // XR Origin
        public BMUGazeFollow follow;          // keeps the canvas in front of the head
        public Color fadeColor = new Color(0.03f, 0.07f, 0.12f, 1f);

        Material mat; MeshRenderer mr; Coroutine run;

        void Awake()
        {
            var quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
            Destroy(quad.GetComponent<Collider>());
            quad.name = "TeleportFade";
            quad.transform.SetParent(Camera.main != null ? Camera.main.transform : transform, false);
            quad.transform.localPosition = new Vector3(0, 0, 0.35f);
            quad.transform.localScale = new Vector3(4f, 4f, 1f);
            mr = quad.GetComponent<MeshRenderer>();
            mat = new Material(Shader.Find("UI/Default"));
            mat.SetInt("unity_GUIZTestMode", (int)CompareFunction.Always);
            mat.renderQueue = 4000;
            mr.sharedMaterial = mat; mr.shadowCastingMode = ShadowCastingMode.Off; mr.receiveShadows = false;
            SetAlpha(0f);
        }

        public void GoTo(Transform spawn)
        {
            if (spawn == null || rig == null) return;
            if (run != null) StopCoroutine(run);
            run = StartCoroutine(Go(spawn));
        }

        IEnumerator Go(Transform spawn)
        {
            yield return Fade(1f, 0.25f);
            var cc = rig.GetComponent<CharacterController>();
            if (cc != null) cc.enabled = false;
            rig.SetPositionAndRotation(spawn.position, spawn.rotation);
            if (cc != null) cc.enabled = true;
            yield return null;
            if (follow != null) follow.Recenter(true);
            yield return Fade(0f, 0.35f);
        }

        IEnumerator Fade(float target, float dur)
        {
            float a0 = mat.color.a, t = 0f;
            while (t < 1f) { t += Time.unscaledDeltaTime / dur; SetAlpha(Mathf.SmoothStep(a0, target, t)); yield return null; }
            SetAlpha(target);
        }

        void SetAlpha(float a) { var c = fadeColor; c.a = a; mat.color = c; mr.enabled = a > 0.002f; }
    }
}
