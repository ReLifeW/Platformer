namespace Platformer
{
    internal class Platform
    {
        public float PositionX { get; private set; }
        public float PositionY { get; private set; }

        public float Width { get; private set; }
        public float Height { get; private set; }

        public bool IsMoving { get; private set; }

        public float Speed { get; private set; }

        public Platform(float positionX, float positionY, float width, float height, bool isMoving = false, float speed = 0)
        {
            PositionX = positionX;
            PositionY = positionY;
            Width = width;
            Height = height;
            IsMoving = isMoving;
            Speed = speed;
        }

        public void Update(float deltaTime)
        {
            if (IsMoving)
            {
                PositionX += Speed * deltaTime;

                if (PositionX < 0 || PositionX > 800)
                {
                    Speed = -Speed;
                }
            }
        }

        public bool IsColliding(Player player)
        {
            return player.PositionX < PositionX + Width &&
                   player.PositionX + player.PositionX > PositionX &&
                   player.PositionY < PositionY + Height &&
                   player.PositionY + player.PositionY > PositionY;
        }
    }
}
