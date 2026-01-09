namespace Mosahm.Domain.Entities
{
    public class OpportunityRequireSkill
    {
        public Guid OpportunityId { get; set; }
        public Opportunity Opportunity { get; set; }
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
