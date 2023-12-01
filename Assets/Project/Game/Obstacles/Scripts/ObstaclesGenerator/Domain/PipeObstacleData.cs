namespace Obstacles.Domain
{
    public class PipeObstacleData
    {
        private readonly float _apertureSize;
        private readonly float _height;
        
        public float ApertureSize => _apertureSize;
        public float Height => _height;

        public PipeObstacleData(float apertureSize, float height)
        {
            _apertureSize = apertureSize;
            _height = height;
        }
    }
}