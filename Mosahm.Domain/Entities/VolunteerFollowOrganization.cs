namespace Mosahm.Domain.Entities
{
    public class VolunteerFollowOrganization
    {
        public Guid VolunteerId { get; set; }
        public Volunteer Volunteer { get; set; }
        public Guid OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
