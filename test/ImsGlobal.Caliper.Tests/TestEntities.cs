using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Entities;
	using ImsGlobal.Caliper.Entities.Lis;
	using ImsGlobal.Caliper.Entities.Reading;

	internal static class TestEntities {

		public static SoftwareApplication Readium = new SoftwareApplication( "https://github.com/readium/readium-js-viewer" ) {
			Name = "Readium",
			LastModifiedAt = 1402965614516L
		};

		public static Person Student554433 = new Person( "https://some-university.edu/user/554433" ) {
			LastModifiedAt = 1402965614516L
		};

		public static CourseSection AmRev101 = new CourseSection( "https://some-university.edu/politicalScience/2014/american-revolution-101" ) {
			Semester = "Spring-2014",
			CourseNumber = "AmRev-101",
			Label = "Am Rev 101",
			Name = "American Revolution 101",
			LastModifiedAt = 1402965614516L
		};

		public static WebPage AmRev101LandingPage = new WebPage( "AmRev-101-landingPage" ) {
			Name = "American Revolution 101 Landing Page",
			ParentRef = AmRev101,
			LastModifiedAt = 1402965614516L
		};

		public static EPubVolume EpubVolume43 = new EPubVolume( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3)" ) {
			Name = "The Glorious Cause: The American Revolution, 1763-1789 (Oxford History of the United States)",
			LastModifiedAt = 1402965614516L
		};

		public static EPubSubChapter EpubSubChap431 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/1)" ) {
			Name = "Key Figures: George Washington",
			ParentRef = EpubVolume43,
			LastModifiedAt = 1402965614516L
		};

		public static Frame EpubSubChap431_Frame = new Frame( EpubSubChap431.Id ) {
			Name = EpubSubChap431.Name,
			ParentRef = EpubVolume43,
			Index = 1,
			LastModifiedAt = 1402965614516L
		};

	}

}
