using UnityEngine;

namespace Player.Components
{
    public class PlayerInput
    {
        public bool HasPressedSprint { get; private set; }
        public bool HasPressedAttack { get; private set; }
        public bool HasPressedDash { get; private set; }
        
        public Vector3 Direction { get; private set; }

        public void Update()
        {
            HasPressedSprint = Input.GetKey(KeyCode.LeftShift);
            HasPressedAttack = Input.GetMouseButtonDown(0);
            HasPressedDash = Input.GetKeyDown(KeyCode.Space);

            Direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));
        }
    }
}