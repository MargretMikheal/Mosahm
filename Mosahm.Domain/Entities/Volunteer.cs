using Mosahm.Domain.Common.Localization;
using Mosahm.Domain.Enums;

namespace Mosahm.Domain.Entities
{
    public class Volunteer : GeneralLocalizableEntity
    {
        #region Properties
        public string NationalId { get; set; }
        public string? ProfileImgUrl { get; set; }
        public string? CoverImgUrl { get; set; }
        public int TotalHours { get; set; }
        public int CompleteOpportunities { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        #endregion
        #region Navigations
        public Guid UserId { get; set; }
        public Address? Address { get; set; }
        public ICollection<VolunteerSkill> VolunteerSkills { get; set; }
        public ICollection<VolunteerField> VolunteerFields { get; set; }
        public ICollection<VolunteerApplyOpportunity>? VolunteerApplyOpportunities { get; set; }
        public ICollection<VolunteerSaveOpportunity>? VolunteerSaveOpportunities { get; set; }
        public ICollection<VolunteerLikeOpportunity>? VolunteerLikeOpportunities { get; set; }
        public ICollection<VolunteerCommentOpportunity>? VolunteerCommentOpportunities { get; set; }
        public ICollection<VolunteerFollowOrganization>? VolunteerFollowOrganizations { get; set; }
        public ICollection<VolunteerAnswerQuestion>? VolunteerAnswerQuestions { get; set; }
        #endregion
    }
}
