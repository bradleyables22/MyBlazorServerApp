namespace MyBlazorServerApp.Data.Models
{
    public class PipeModel
    {
        //Always start a little outside screen
        public int DistanceFromLeft { get; set; } = 400;
        
        //Random heights to zigzag through
        public int DistanceFromBottom { get; set; } = new Random().Next(0, 80);

        public int Speed { get;set; } = 2;

        public int Gap { get; set; } = 104; //Distance between top and bottom pipe

        public int GapBottom => DistanceFromBottom + 240;

        public int GapTop => GapBottom + Gap;  
        public void Move()
        { 
            DistanceFromLeft -= Speed;
        }
        public bool IsOffScreen()
        {
            if (DistanceFromLeft <= -48)//If the pipe is outside container (48 is pipe width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PipeInCenter()
        {
            int halfWidthOfScreen = 200;
            int halfWidthOfBird = 24;
            int fullWidthOfPipe = 48;

            //Trying something new here.
            //Bool on calculation. Then Return answer
            bool pipeEnteredCenter = DistanceFromLeft <= halfWidthOfScreen + halfWidthOfBird;
            bool pipeExitedCenter = DistanceFromLeft <= halfWidthOfScreen - halfWidthOfBird - fullWidthOfPipe;

            return pipeEnteredCenter && !pipeExitedCenter;

        }
    }
}
