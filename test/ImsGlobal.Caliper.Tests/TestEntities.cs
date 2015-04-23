using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NodaTime;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Entities;
	using ImsGlobal.Caliper.Entities.Agent;
	using ImsGlobal.Caliper.Entities.Assessment;
	using ImsGlobal.Caliper.Entities.Assignable;
	using ImsGlobal.Caliper.Entities.Lis;
	using ImsGlobal.Caliper.Entities.Media;
	using ImsGlobal.Caliper.Entities.Outcome;
	using ImsGlobal.Caliper.Entities.Reading;
	using ImsGlobal.Caliper.Entities.Session;
	using ImsGlobal.Caliper.Entities.W3c;

	internal static class TestEntities {

		public static readonly string Student554433_Id = "https://some-university.edu/user/554433";
		public static readonly string AmRev101_CourseOffering_Id = "https://some-university.edu/politicalScience/2015/american-revolution-101";
		public static readonly string AmRev101_CourseSection001_Id = "https://some-university.edu/politicalScience/2015/american-revolution-101/section/001";
		public static readonly string AmRev101_Group001_Id = "https://some-university.edu/politicalScience/2015/american-revolution-101/section/001/group/001";

		public static readonly Instant DefaultDateCreated = Instant.FromUtc( 2015, 8, 1, 6, 0, 0 );
		public static readonly Instant DefaultDateModified = Instant.FromUtc( 2015, 9, 2, 11, 30, 0 );
		public static readonly Instant DefaultDatePublished = Instant.FromUtc( 2015, 8, 15, 9, 30, 0 );
		public static readonly Instant DefaultDateToActivate = Instant.FromUtc( 2015, 8, 16, 5, 0, 0 );
		public static readonly Instant DefaultDateToShow = DefaultDateToActivate;
		public static readonly Instant DefaultDateToStartOn = DefaultDateToActivate;
		public static readonly Instant DefaultDateToSubmit = Instant.FromUtc( 2015, 9, 28, 11, 59, 59 );
		public static readonly Instant DefaultStartedAtTime = Instant.FromUtc( 2015, 9, 15, 10, 15, 0 );
		public static readonly Instant NodaDefaultStartedAtTime = Instant.FromUtc(  2015, 9, 15, 10, 15, 0 );
		public static readonly Instant DefaultEndedAtTime = Instant.FromUtc( 2015, 9, 15, 11, 05, 0 );

		public static readonly IMembership Student554433_AmRev101_CourseOffering_Membership =
			new Membership( "https://some-university.edu/membership/001" ) {
				MemberId = Student554433_Id,
				OrganizationId = AmRev101_CourseOffering_Id,
				Roles = new IRole[] { Role.Learner },
				Status = Status.Active,
				DateCreated = DefaultDateCreated
			};
		public static readonly IMembership Student554433_AmRev101_CourseSection001_Membership =
			new Membership( "https://some-university.edu/membership/002" ) {
				MemberId = Student554433_Id,
				OrganizationId = AmRev101_CourseSection001_Id,
				Roles = new IRole[] { Role.Learner },
				Status = Status.Active,
				DateCreated = DefaultDateCreated
			};
		public static readonly IMembership Student554433_AmRev101_Group001_Membership =
			new Membership( "https://some-university.edu/membership/003" ) {
				MemberId = Student554433_Id,
				OrganizationId = AmRev101_Group001_Id,
				Roles = new IRole[] { Role.Learner },
				Status = Status.Active,
				DateCreated = DefaultDateCreated
			};

		public static IList<IMembership> Student554433_Memberships = new IMembership[] {
			Student554433_AmRev101_CourseOffering_Membership,
			Student554433_AmRev101_CourseSection001_Membership,
			Student554433_AmRev101_Group001_Membership
		};

		public static Person Student554433 = new Person( Student554433_Id ) {
			Memberships = Student554433_Memberships,
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static CourseOffering AmRev101_CourseOffering = new CourseOffering( AmRev101_CourseOffering_Id ) {
			CourseNumber = "POL101",
			Name = "Political Science 101: The American Revolution",
			AcademicSession = "Fall-2015",
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static CourseSection AmRev101_CourseSection001 = new CourseSection( AmRev101_CourseSection001_Id ) {
			CourseNumber = "POL101",
			Name = "American Revolution 101",
			AcademicSession = "Fall-2015",
			Membership = new IMembership[] { Student554433_AmRev101_CourseSection001_Membership },
			SubOrganizationOf = AmRev101_CourseOffering,
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static Group AmRev101_Group001 = new Group( AmRev101_Group001_Id ) {
			Name = "Discussion Group 001",
			Membership = new IMembership[] { Student554433_AmRev101_Group001_Membership },
			SubOrganizationOf = AmRev101_CourseSection001,
			DateCreated = DefaultDateCreated
		};

		public static WebPage AmRev101LandingPage = new WebPage( "AmRev-101-landingPage" ) {
			Name = "American Revolution 101 Landing Page",
			DateModified = DefaultDateModified
		};

		public static SoftwareApplication Readium = new SoftwareApplication( "https://github.com/readium/readium-js-viewer" ) {
			Name = "Readium",
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static EPubVolume EpubVolume43 = new EPubVolume( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3)" ) {
			Name = "The Glorious Cause: The American Revolution, 1763-1789 (Oxford History of the United States)",
			DateModified = DefaultDateModified
		};

		public static EPubSubChapter EpubSubChap431 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/1)" ) {
			Name = "Key Figures: George Washington",
			Version = "2nd ed.",
			IsPartOf = EpubVolume43,
			DateModified = DefaultDateModified
		};

		public static Frame EpubSubChap431_Frame = new Frame( EpubSubChap431.Id ) {
			Name = EpubSubChap431.Name,
			Version = EpubSubChap431.Version,
			IsPartOf = EpubVolume43,
			Index = 1,
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static EPubSubChapter EpubSubChap432 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/2)" ) {
			Name = "Key Figures: Lord North",
			Version = "2nd ed.",
			IsPartOf = EpubVolume43,
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static Frame EpubSubChap432_Frame = new Frame( EpubSubChap432.Id ) {
			Name = EpubSubChap432.Name,
			Version = EpubSubChap432.Version,
			IsPartOf = EpubSubChap432.IsPartOf,
			Index = 2,
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static EPubSubChapter EpubSubChap433 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/3)" ) {
			Name = "Key Figures: John Adams",
			Version = "2nd ed.",
			IsPartOf = EpubVolume43,
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static Frame EpubSubChap433_Frame = new Frame( EpubSubChap433.Id ) {
			Name = EpubSubChap433.Name,
			Version = EpubSubChap433.Version,
			IsPartOf = EpubVolume43,
			Index = 3,
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static EPubSubChapter EpubSubChap434 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/4)" ) {
			Name = "The Stamp Act Crisis",
			Version = "2nd ed.",
			IsPartOf = EpubVolume43,
			DateModified = DefaultDateModified
		};

		public static Frame EpubSubChap434_Frame = new Frame( EpubSubChap434.Id ) {
			Name = EpubSubChap434.Name,
			Version = EpubSubChap434.Version,
			IsPartOf = EpubVolume43,
			Index = 4,
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static SoftwareApplication SuperMediaTool = new SoftwareApplication( "https://com.sat/super-media-tool" ) {
			Name = "Super Media Tool",
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static VideoObject VideoWithLearningObjective = new VideoObject( "https://com.sat/super-media-tool/video/video1" ) {
			Name = "American Revolution - Key Figures Video",
			AlignedLearningObjectives = new[] { 
				new LearningObjective( "http://americanrevolution.com/personalities/learn" ) {
					DateCreated = DefaultDateCreated
				}
			},
			Duration = 1420,
			Version = "1.0",
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static MediaLocation VideoWithLearningObjective_Location710 = new MediaLocation( VideoWithLearningObjective.Id ) {
			CurrentTime = 710,
			Version = "1.0",
			DateCreated = DefaultDateCreated
		};

		public static SoftwareApplication SuperAssessmentTool = new SoftwareApplication( "https://com.sat/super-assessment-tool" ) {
			Name = "Super Assessment Tool",
			DateCreated = DefaultDateCreated
		};

		private static string Assessment1_Id = "https://some-university.edu/politicalScience/2015/american-revolution-101/assessment1";

		public static AssessmentItem AssessmentItem1 =
			new AssessmentItem( "https://some-university.edu/politicalScience/2015/american-revolution-101/assessment1/item1" ) {
				Name = "Assessment Item 1",
				Version = "1.0",
				IsPartOf = new Assessment( Assessment1_Id ),
				MaxAttempts = 2,
				MaxSubmits = 2,
				MaxScore = 1.0,
				IsTimeDependent = false
			};
		public static AssessmentItem AssessmentItem2 =
			new AssessmentItem( "https://some-university.edu/politicalScience/2015/american-revolution-101/assessment1/item2" ) {
				Name = "Assessment Item 2",
				Version = "1.0",
				IsPartOf = new Assessment( Assessment1_Id ),
				MaxAttempts = 2,
				MaxSubmits = 2,
				MaxScore = 1.0,
				IsTimeDependent = false
			};
		public static AssessmentItem AssessmentItem3 =
			new AssessmentItem( "https://some-university.edu/politicalScience/2015/american-revolution-101/assessment1/item3" ) {
				Name = "Assessment Item 3",
				Version = "1.0",
				IsPartOf = new Assessment( Assessment1_Id ),
				MaxAttempts = 2,
				MaxSubmits = 2,
				MaxScore = 1.0,
				IsTimeDependent = false
			};

		public static Assessment Assessment1 = new Assessment( Assessment1_Id ) {
			Name = "American Revolution - Key Figures Assessment",
			Version = "1.0",
			DatePublished = DefaultDatePublished,
			DateToActivate = DefaultDateToActivate,
			DateToShow = DefaultDateToShow,
			DateToStartOn = DefaultDateToStartOn,
			DateToSubmit = DefaultDateToSubmit,
			MaxAttempts = 2,
			MaxSubmits = 2,
			MaxScore = 3.0,
			AssessmentItems = new[] {
				AssessmentItem1,
				AssessmentItem2,
				AssessmentItem3
			},
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified
		};

		public static Attempt Assessment1_Attempt1 = new Attempt( Assessment1_Id + "/attempt1" ) {
			Assignable = Assessment1,
			Actor = Student554433,
			Count = 1,
			DateCreated = DefaultDateCreated,
			StartedAtTime = DefaultStartedAtTime
		};

		public static Result Assessment1_Attempt1_Result = new Result( Assessment1_Attempt1.Id + "/result" ) {
			NormalScore = 3.0,
			PenaltyScore = 0.0,
			ExtraCreditScore = 0.0,
			TotalScore = 3.0,
			CurvedTotalScore = 3.0,
			CurveFactor = 0.0,
			Comment = "Well done.",
		//	ScoredBy = SuperAssessmentTool,
			DateModified = DefaultDateModified
		};

		public static Session SessionStart = new Session( "https://github.com/readium/session-123456789" ) {
			Name = "session-123456789",
			Actor = Student554433,
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified,
			StartedAt = NodaDefaultStartedAtTime
		};

		public static Session SessionEnd = new Session( "https://github.com/readium/session-123456789" ) {
			Name = "session-123456789",
			Actor = Student554433,
			DateCreated = DefaultDateCreated,
			DateModified = DefaultDateModified,
			StartedAt = NodaDefaultStartedAtTime,
			EndedAt = DefaultEndedAtTime,
			Duration = Period.FromSeconds( 3000 )
		};

	}

}
