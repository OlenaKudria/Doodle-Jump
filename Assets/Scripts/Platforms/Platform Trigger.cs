using Core;
using UnityEngine;

namespace Platforms
{
    public class PlatformTrigger : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            ColorManager.ChangeColor(gameObject);
        }
    }
}
