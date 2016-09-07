using ImsGlobal.Caliper.Entities.W3c;
using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Lis
{
    [JsonConverter(typeof(JsonValueConverter<Role>))]
    public sealed class Role : IRole, IJsonValue
    {
        public static readonly Role Learner = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership#Learner");
        public static readonly Role ExternalLearner = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Learner#ExternalLearner");
        public static readonly Role GuestLearner = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Learner#GuestLearner");
        public static readonly Role LearnerInstructor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Learner#Instructor");
        public static readonly Role LearnerLearner = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Learner#Learner");
        public static readonly Role NoncreditLearner = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Learner#NonCreditLearner");

        public static readonly Role Instructor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership#Instructor");
        public static readonly Role ExternalInstructor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Instructor#ExternalInstructor");
        public static readonly Role GuestInstructor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Instructor#GuestInstructor");
        public static readonly Role Lecturer = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Instructor#Lecturer");
        public static readonly Role PrimaryInstructor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Instructor#PrimaryInstructor");

        public static readonly Role Administrator = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership#Administrator");
        public static readonly Role AdministratorAdministrator = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Administrator#Administrator");
        public static readonly Role AdministratorDeveloper = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Administrator#Developer");
        public static readonly Role AdministratorSupport = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Administrator#Support");
        public static readonly Role AdministratorSystemAdministrator = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Administrator#SystemAdministrator");

        public static readonly Role AdministratorExternalDeveloper = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Administrator#ExternalSupport");
        public static readonly Role AdministratorExternalSupport = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Administrator#ExternalDeveloper");

        public static readonly Role AdministratorExternalSystemAdministrator =
            new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Administrator#ExternalSystemAdministrator");

        public static readonly Role ContentDeveloper = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership#ContentDeveloper");
        public static readonly Role ContentDeveloperContentDeveloper = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/ContentDeveloper#ContentDeveloper");
        public static readonly Role ContentDeveloperLibrarian = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/ContentDeveloper#Librarian");
        public static readonly Role ContentDeveloperContentExpert = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/ContentDeveloper#ContentExpert");
        public static readonly Role ContentDeveloperExternalContentExpert = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/ContentDeveloper#ExternalContentExpert");

        public static readonly Role Manager = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership#Manager");
        public static readonly Role ManagerAreaManager = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Manager#AreaManager");
        public static readonly Role ManagerCourseCoordinator = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Manager#CourseCoordinator");
        public static readonly Role ManagerObserver = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Manager#Observer");
        public static readonly Role ManagerExternalObserver = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Manager#ExternalObserver");

        public static readonly Role Member = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership#Member");
        public static readonly Role MemberMember = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Member#Member");

        public static readonly Role Mentor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership#Mentor");
        public static readonly Role MentorMentor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Mentor#Mentor");
        public static readonly Role MentorAdvisor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Mentor#Advisor");
        public static readonly Role MentorAuditor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Mentor#Auditor");
        public static readonly Role MentorReviewer = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Mentor#Reviewer");
        public static readonly Role MentorTutor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Mentor#Tutor");
        public static readonly Role MentorLearningFacilitator = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Mentor#LearningFacilitator");

        public static readonly Role MentorExternalMentor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Mentor#ExternalMentor");
        public static readonly Role MentorExternalAdvisor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Mentor#ExternalAdvisor");
        public static readonly Role MentorExternalAuditor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Mentor#ExternalAuditor");
        public static readonly Role MentorExternalReviewer = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Mentor#ExternalReviewer");
        public static readonly Role MentorExternalTutor = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Mentor#ExternalTutor");
        public static readonly Role MentorExternalLearningFacilitator = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/Mentor/ExternalLearningFacilitator");

        public static readonly Role TeachingAssistant = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership#TeachingAssistant");
        public static readonly Role TeachingAssistantTeachingAssistant = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/TeachingAssistant#TeachingAssistant");
        public static readonly Role TeachingAssistantGrader = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/TeachingAssistant#Grader");

        public static readonly Role TeachingAssistantTeachingAssistantSection = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/TeachingAssistant#TeachingAssistantSection");

        public static readonly Role TeachingAssistantTeachingAssistantSectionAssociation = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/TeachingAssistant#TeachingAssistantSectionAssociation");

        public static readonly Role TeachingAssistantTeachingAssistantOffering = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/TeachingAssistant#TeachingAssistantOffering");

        public static readonly Role TeachingAssistantTeachingAssistantTemplate = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/TeachingAssistant#TeachingAssistantTemplate");

        public static readonly Role TeachingAssistantTeachingAssistantGroup = new Role("http://purl.imsglobal.org/vocab/lis/v2/membership/TeachingAssistant#TeachingAssistantGroup");

        public Role()
        {
        }

        public Role(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}