using System;
using UnityEngine;

namespace Platforms
{
    public class PlatformTrigger : MonoBehaviour
    {
        public static Action OnPlatformTrigger;

        private void OnTriggerEnter2D(Collider2D other)
        {
            OnPlatformTrigger?.Invoke();
        }
    }
}
