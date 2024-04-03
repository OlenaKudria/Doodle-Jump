using UnityEngine;

namespace Player
{
    public class InputManager : MonoBehaviour
    {
        public float HorizontalInput { get; private set; }
        public bool JumpInput { get; private set; }

        private void Update()
        {
            HorizontalInput = Input.GetAxisRaw("Horizontal");
            JumpInput = Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W);
        }
    }
}
