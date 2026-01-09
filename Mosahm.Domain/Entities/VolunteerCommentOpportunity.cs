namespace Mosahm.Domain.Entities
{
    public class VolunteerCommentOpportunity : BaseEntity
    {
        public Guid VolunteerId { get; set; }
        public Volunteer Volunteer { get; set; }
        public Guid OpportunityId { get; set; }
        public Opportunity Opportunity { get; set; }
        public string Text { get; set; }
        public bool IsHidden { get; set; }

    }
}
