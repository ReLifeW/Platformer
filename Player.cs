namespace Platformer
{
    public class Player
    {
       
        public float PositionY { get; private set; }
        public float PositionX { get; private set; }
        public float Speed { get; set; }
        public bool IsJumping { get; private set; }
        private float jumpForce;
        private float gravity;
        private float verticalVelocity;

        
        public Player(float startX, float startY, float speed, float jumpForce, float gravity)
        {
            PositionX = startX;
            PositionY = startY;
            Speed = speed;
            this.jumpForce = jumpForce;
            this.gravity = gravity;
            IsJumping = false;
            verticalVelocity = 0;
        }

        
        public void Move(float direction)
        {
            PositionX += direction * Speed;
        }

       
        public void Jump()
        {
            if (!IsJumping)
            {
                verticalVelocity = jumpForce;
                IsJumping = true;
            }
        }

       
        public void Update()
        {
           
            if (IsJumping)
            {
                verticalVelocity -= gravity; 
                PositionY += verticalVelocity; 
                if (PositionY <= 0) 
                    PositionY = 0;
                IsJumping = false;
                verticalVelocity = 0;
            }
        }
    }
}