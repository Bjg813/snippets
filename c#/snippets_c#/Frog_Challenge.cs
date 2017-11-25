namespace Treehouse.CodeChallenges
{
    class Frog
    {
        public readonly int TongueLength;
        public readonly int ReactionTime;

        public Frog(int tongueLength, int reactionTime)
        {
            TongueLength = tongueLength;
            ReactionTime = reactionTime;
        }

        public bool EatFly(int distanceToFly)
        {
            return TongueLength >= distanceToFly;
        }
        
        public bool EatFly(int distanceToFly, int flyReactionTime)
        {
         return TongueLength >= distanceToFly && ReactionTime <= flyReactionTime;   
        }
    }
}