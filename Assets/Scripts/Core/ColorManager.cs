using UnityEngine;

namespace Core
{
    public class ColorManager : MonoBehaviour
    {
        public static void ChangeColor(GameObject gameObject)
        {
            SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.color = GetRandomColor();
        }

        private static Color GetRandomColor()
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            
            return new Color(r, g, b);
        }
    }
}
