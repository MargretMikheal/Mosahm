using Mosahm.Domain.Common.Localization;
using Mosahm.Domain.Enums;

namespace Mosahm.Domain.Entities
{
    public class Opportunity : GeneralLocalizableEntity
    {
        #region Properties
        public string Title { get; set; }
        public string Descripition { get; set; }
        public string LogoUrl { get; set; }
        public OpportunityStatus Status { get; set; }
        public VerficationStatus VerificationStatus { get; set; }
        public OpportunityWorkType WorkType { get; set; }
        public OpportunityLocationType LocationType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Vacancies { get; set; }
        public int ApplicantsCount { get; set; }
        public int LikesCount { get; set; }
        public int CommentsCount { get; set; }
        #endregion
        #region Navigations
        public Guid OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public Guid? FieldId { get; set; }
        public Field? Field { get; set; }
        public ICollection<Address>? Address { get; set; }
        public ICollection<VolunteerCommentOpportunity>? VolunteerCommentOpportunities { get; set; }
        public ICollection<VolunteerLikeOpportunity>? VolunteerLikeOpportunities { get; set; }
        public ICollection<VolunteerSaveOpportunity>? VolunteerSaveOpportunities { get; set; }
        public ICollection<VolunteerApplyOpportunity>? VolunteerApplyOpportunities { get; set; }
        public ICollection<OpportunityRequireSkill>? OpportunityRequireSkills { get; set; }
        public ICollection<OpportunityProvideSkill>? OpportunityProvideSkills { get; set; }
        public ICollection<Question>? Questions { get; set; }
        #endregion
    }
}
