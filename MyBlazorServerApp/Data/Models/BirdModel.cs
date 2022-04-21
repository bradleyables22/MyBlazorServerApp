namespace MyBlazorServerApp.Data.Models
{
    public class BirdModel
    {
        public int DistanceFromGround { get; set; } = 80;
        public int JumpStrength { get; set; } = 40;

        public void Fall(int gravity)
        {
            DistanceFromGround -= gravity; //Gravity fed from GameManager.cs
        }

        public void Jump()
        {
            if (DistanceFromGround <= 390) //Only allow if under screen max. See site.css 
            {
                DistanceFromGround += JumpStrength;
            }
            
        }
        public bool IsGrounded()
        {
            if (DistanceFromGround <=0 )//If model is 0px from absolute bottom. See site.css
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
