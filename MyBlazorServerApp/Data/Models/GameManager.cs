using System.ComponentModel;

namespace MyBlazorServerApp.Data.Models
{
    public class GameManager
    {
        private readonly int gravity = 2;
        public BirdModel Bird { get;set; }
        public List<PipeModel> Pipes { get;set; }
        public bool IsRunning { get; set; } = false;

        public event EventHandler MainLoopCompleted;
        public GameManager()
        {
            Bird = new BirdModel();
            Pipes = new List<PipeModel>();
        }
        public async void MainLoop()
        {
            IsRunning = true;
            while (IsRunning)
            {
                MoveOjects();
                CollisionCheck();
                PipeMaker();

                MainLoopCompleted.Invoke(this, EventArgs.Empty);
                await Task.Delay(20); // Wait 20 ms
            }
        }

        public void StartGame()
        {
            Bird = new BirdModel();
            Pipes = new List<PipeModel>();
            MainLoop();
        }
        public void GameOver() 
        {
            IsRunning = false;
        }
        public void Jump()
        {
            if (IsRunning)
            {
                Bird.Jump();
            }
        }
        public void MoveOjects()
        {
            Bird.Fall(2); // Fall 2 px
            foreach (var pipe in Pipes)
            {
                pipe.Move();
            }
        }
        public void CollisionCheck()
        {
            //Check to see if the bird hit the ground (is 0 or less px from ground div)
            if (Bird.IsGrounded())
            {
                GameOver();
            }

            var centerPipe = Pipes.FirstOrDefault(pipe => pipe.PipeInCenter());

            if (centerPipe != null) 
            {
                bool hasBottomCollided = Bird.DistanceFromGround < centerPipe.GapBottom - 120; //120 height of ground
                bool hasTopCollided = Bird.DistanceFromGround + 36 > centerPipe.GapTop - 120; //36 height of bird

                if (hasBottomCollided || hasTopCollided)
                {
                    GameOver();
                }
            }
        }
        public void PipeMaker()
        {
            //If ante got no pipes, or if the last pipe past the middle
            if (!Pipes.Any() || Pipes.Last().DistanceFromLeft <= 200)
            {
                Pipes.Add(new PipeModel());
            }
            //Don't want too many pipes in our list, that might get a bit heavy as game goes on
            if (Pipes.First().IsOffScreen())
            {
                Pipes.Remove(Pipes.First());
            }
        }
    }
}
