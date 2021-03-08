namespace Heist
{
    public class TeamMember
    {
        public string Name { get; }
        public int SkillLevel { get; }
        public decimal CourageFactor { get; }

        // Construtor cause I want one
        public TeamMember(string name, int skillLevel, decimal courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }

    }
}